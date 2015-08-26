using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/*
Author: Hai Tang (haitang@jhu.edu)
*/
namespace Hai_EMG_Game
{
    public partial class MainForm : Form
    {
        //Data Acquisition and Bit Manipulation
        int counter = 0;
        int[] receivedBuffer = new int[500];
        int firstByte;
        int secondByte;
        int thirdByte;
        int combine;
        bool sign = false;
        int[] envelop = new int[1000000];//1000s
        Encoding enc = Encoding.GetEncoding(1252);

        //Version D and OB Digitization
        int[] DACenvelop = new int[1000000];//Only for D2, 0-255
        int[] digitizedEnvelop = new int[1000000];
        int signalPeakD2 = 800;
        double stepSizeD2 = 256.0 / 77.0; //0-255, digitizedLevel = 77; NOTE: Must add XX.0 to ensure double accuracy. Otherwise 256/77=3.
        int signalPeakOB = 1024;
        double stepSizeOB = 1024.0 / 100.0; //digitiedLevel = 100

        //Display
        int DisplayLength = 10000; //Sampling rate = 1000
        int disp;
        Boolean showDigitized = false;
        Boolean showBar = true;

        //Target Levels and rest
        int elapsedTime = 0;
        int center = 0;
        int halfWidth = 5;
        int timeInterval = 5;
        int timeRest = 4; //3s + Go
        int restTimeElapsed = 0;
        int timeCountDownStart = 4;//3s + Go
        int hitCounts = 0;
        double hitThreshold = 0.2; //5*0.2=1s // 0.001; // hitThreshold of timeInterval in target area means really hit.
        Boolean isGameStart = false;
        int totalHits = 0;
        Boolean totalHitsCounted = false;
        int totalTrials = 0;
        Boolean isResting = false;
        int countDownTimer = 0;
        Random rnd = new Random();
        int maxTrials = 3;//10;

        //Recording and Reading
        string savingPath = "C:\\Users\\Owner\\Desktop\\Game_Data\\";
        FileStream myFileStream;
        StreamWriter myStreamWriter;
        Boolean recording = false;
        string readingPath;
        int[] savedEnvelop = new int[1000000];//1000s
        int[] savedDigitizedEnvelop = new int[1000000];
        string electrode = "";
        string filePath;

        //Training
        int trainingTime = 5;
        int trainingElapsed = 0;

        //Time cost to hit the target
        double hitCostTime = 0;
        List<String> hitCostTimeList = new List<String>(); //The tailing extra 0s will not be counted into length

        //Throughput
        double ID = 0;//Index of Difficulty
        double TP = 0;//Throughput
        double aveTP = 0;
        List<double> TPList = new List<double>();
        Boolean gameOver = true;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_stop_recording.Enabled = false;
            electrode = "IBT";
            button_IBTVD.Enabled = false;
            button_pause.Enabled = false;
            countDownTimer = timeInterval * 1000;
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            for (int i = 0; i < receivedBuffer.Length; i++)
            {
                if (serialPort.IsOpen)
                {
                    receivedBuffer[i] = serialPort.ReadByte();//Read a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.
                }
            }

            for (int i = 0; i <= receivedBuffer.Length - 5; i++)
            {
                //refresh the buffer and reset counter when it's full
                if (counter == 1000000) 
                {
                    Array.Clear(envelop, 0, envelop.Length);
                    Array.Clear(digitizedEnvelop, 0, digitizedEnvelop.Length);
                    counter = 0;
                }

                if (receivedBuffer[i] == 35 && receivedBuffer[i + 4] == 36)
                {
                    //NOTE: Least significant bit comes first!
                    firstByte = receivedBuffer[i + 1];
                    secondByte = receivedBuffer[i + 2];
                    thirdByte = receivedBuffer[i + 3];

                    combine = firstByte << 16 | secondByte << 8 | thirdByte; //Concat three bytes together bitwisely
                    sign = GetBit(firstByte, 7); //When the sign bit is 0 (false), positive; 1 (true), negative
                    if (!sign) //Positive number
                    {
                        envelop[counter] = combine;
                    }
                    else //Negative number
                    {
                        //combine = (~firstByte) << 16 | (~secondByte) << 8 | (~thirdByte); //Take the complement. ~ is complement!
                        //Pad the extra leading byte for int with 11111111. Which is the "sign byte"
                        for (int temp = 24; temp < 32; temp++)
                        {
                            combine = combine | (1 << temp);
                        }
                        envelop[counter] = combine; //Take the correct negative value. Not need to take complement and plus 1 any more.
                    }

                    if(electrode == "IBT")
                    {
                        if (signalPeakD2 != 0)//Handle special case.
                        {
                            DACenvelop[counter] = envelop[counter] * 255 / signalPeakD2;
                        }
                        
                        if (DACenvelop[counter] > 255)
                        {
                            DACenvelop[counter] = 255;
                        }
                        digitizedEnvelop[counter] = (int)(DACenvelop[counter] / stepSizeD2); //No need to floor an int since it's auto truncked.
                    }
                    else if(electrode == "OttoBock")
                    {
                        digitizedEnvelop[counter] = (int)(envelop[counter] / stepSizeOB);
                    }


                    //Put the data into recording file
                    if (recording)
                    {
                        myStreamWriter.Write(counter.ToString() + '\t' + envelop[counter].ToString() + "\t" + digitizedEnvelop[counter].ToString() + "\t");
                        myStreamWriter.WriteLine();
                    }

                    counter++;


                    if(timer_100ms.Enabled == true)
                    {
                        hitCostTime++; //Seems the timer is not running at 1000Hz, but 10Hz only instead. The DataReceived event is called every 1ms!!! So use this as a timer. Worked once but not anymore.
                        countDownTimer--;
                        if (countDownTimer == 0)
                        {
                            countDownTimer = timeInterval * 1000;
                        }
                    }
                    if (isGameStart && center != 0 && !isResting || showBar)
                    {
                        if (digitizedEnvelop[counter - 1] > center - halfWidth && digitizedEnvelop[counter - 1] < center + halfWidth)
                        {
                            hitCounts++; //Count the accumulated time in the target area
                        }
                    }

                }
            }

            System.Threading.Thread.Sleep(10);//Slightly delay for 100; 50 works fine; 30 works fine. 10 works fine. 
        }

        private static bool GetBit(int b, int bitNum) // a=11010010, GetBit(a,0) = 0; GetBit(a,7) = 1;
        {
            return (b & (1 << bitNum)) != 0;
        }

        private Byte ReverseBits(Byte originalByte)
        {
            int result = 0;
            for(int i=0; i<8; i++)
            {
                result = result << 1;
                result += originalByte & 1;
                originalByte = (Byte)(originalByte >> 1);
            }
            return (Byte)result;
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open(); 
                }
                button_startDisplay.Enabled = false;
                button_pause.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Cannot Open Serial Port. Check COM Number or Availability.");
            }

            timer_display.Enabled = true;
        }

        private void timer_display_Tick(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(DisplayData));
        }

        private void DisplayData(object s, EventArgs e)
        {
            //Bar Graph
            if (counter > 1)
            {
                if (isGameStart && center != 0 && !isResting || showBar)
                {
                    this.chart_DigitBar.Series["BarEMGVal"].Points.Clear();
                    this.chart_DigitBar.Series["targetLevel"].Points.Clear();

                    if (electrode == "IBT")
                    {
                        this.chart_DigitBar.ChartAreas[0].AxisY.Maximum = 80;
                        this.chart_DigitBar.ChartAreas[0].AxisY.Minimum = 0;
                        this.chart_DigitBar.ChartAreas[0].AxisY.Interval = 10;
                        this.chart_DigitBar.Titles["Real Time Bar"].Text = "D2 Real Time Bar (0-77)";
                    }
                    else if (electrode == "OttoBock")
                    {
                        this.chart_DigitBar.ChartAreas[0].AxisY.Maximum = 100;
                        this.chart_DigitBar.ChartAreas[0].AxisY.Minimum = 0;
                        this.chart_DigitBar.ChartAreas[0].AxisY.Interval = 10;
                        this.chart_DigitBar.Titles["Real Time Bar"].Text = "OB Real Time Bar (0-100)";
                    }

                    this.chart_DigitBar.Series["BarEMGVal"].Points.AddXY("Strength", 0, digitizedEnvelop[counter - 1]); //Note that counter++ after putting in data. So we need counter - 1 here!!!
                    this.chart_DigitBar.Series["BarEMGVal"]["DrawSideBySide"] = "false"; //Overlap two series
                    this.chart_DigitBar.Series[0].Color = Color.FromArgb(200, 255, 0, 0); //Set color and transparency //Red
                    this.chart_DigitBar.Series[0].BorderColor = Color.FromArgb(200, 0, 0, 128); //Navy

                    this.chart_DigitBar.Series["targetLevel"].Points.AddXY("Strength", center - halfWidth, center + halfWidth);
                    this.chart_DigitBar.Series["targetLevel"]["DrawSideBySide"] = "false";
                    this.chart_DigitBar.Series[1].Color = Color.FromArgb(200, 255, 215, 0); //Gold
                    this.chart_DigitBar.Series[1].BorderColor = Color.FromArgb(200, 184, 131, 11); //Dark Gold
                    this.chart_DigitBar.Series[1].BorderWidth = 5;

                    if (hitCounts > timeInterval * 1000 * hitThreshold)
                    {
                        this.chart_DigitBar.Series[1].Color = Color.FromArgb(200, 0, 255, 0); //Green
                        this.chart_DigitBar.Series[1].BorderColor = Color.FromArgb(200, 0, 100, 0); //Dark Green
                        this.chart_DigitBar.Series[1].BorderWidth = 5;

                        if (!totalHitsCounted && !gameOver)
                        {
                            totalHits++;
                            totalHitsCounted = true;
                            textBox_hitCostTime.Text = (hitCostTime / 1000.0).ToString() + "s";
                            hitCostTimeList.Add((hitCostTime / 1000.0).ToString());

                            //Calculate the throughput
                            ID = Math.Log((double)(center / (2 * halfWidth)) + 1, 2);
                            TP = Math.Round(ID / (hitCostTime / 1000), 2);
                            TPList.Add(TP);
                            textBox_throughput.Text = TP.ToString();
                        }
                    }

                    if (center == 0)
                    {
                        this.chart_DigitBar.Series[1].Color = Color.FromArgb(0, 0, 0, 0); //Disappear
                        this.chart_DigitBar.Series[1].BorderWidth = 0;
                    }
                }
                else
                {
                    this.chart_DigitBar.Series["BarEMGVal"].Points.Clear();
                    this.chart_DigitBar.Series["targetLevel"].Points.Clear();
                }
            }

            //Real Time EMG Graph
            this.chart_EMGrealtime.Series["EMGVal"].Points.Clear();
            if (counter >= DisplayLength)
            {
                for (disp = counter - DisplayLength; disp < counter; disp++)
                {
                    if (!showDigitized)
                    {
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = Double.NaN; //Default AutoScale
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = Double.NaN;
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = Double.NaN;
                        this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Filtered EMG Signal";
                        this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), envelop[disp]);
                    }
                    else //Show Digitized EMG
                    {
                        if(electrode == "IBT")
                        {
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = 80;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = 0;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = 10;
                            this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Digitized EMG Signal (0-77)";
                        }
                        else if(electrode == "OttoBock")
                        {
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = 100;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = 0;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = 10;
                            this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Digitized EMG Signal (0-100)";
                        }
                        this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), digitizedEnvelop[disp]);

                    }
                }
            }
            else //Time elapsed less than display length
            {
                for (disp = 0; disp < DisplayLength; disp++)
                {
                    if (!showDigitized)
                    {
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = Double.NaN;//Default AutoScale
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = Double.NaN;
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = Double.NaN;
                        this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Filtered EMG Signal";
                        this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), envelop[disp]);
                    }
                    else //Show Digitized EMG
                    {
                        if (electrode == "IBT")
                        {
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = 80;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = 0;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = 10;
                            this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Digitized EMG Signal (0-77)";
                        }
                        else if (electrode == "OttoBock")
                        {
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = 100;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = 0;
                            this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = 10;
                            this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Digitized EMG Signal (0-100)";
                        }
                        this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), digitizedEnvelop[disp]);
                    }
                }
            }
        }

        private void trackBar_displayLength_Scroll(object sender, EventArgs e)
        {
            DisplayLength = trackBar_displayLength.Value;
            label_trackBar.Text = "Display Length: " + (trackBar_displayLength.Value / 1000).ToString() + " s";
        }

        private void timer_targetLevel_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            if (elapsedTime < timeCountDownStart-1)
            {
                textBox_InstructionBoard.Text = "Game Starts in " + (timeCountDownStart - elapsedTime-1) + "s";
            }
            else if (elapsedTime == timeCountDownStart - 1)
            {
                textBox_InstructionBoard.Text = "Go!";
            }
            else //The game really starts here after 3s count down
            {
                isGameStart = true;
                timer_100ms.Enabled = true;

                textBox_InstructionBoard.Visible = false;
                if ((elapsedTime - timeCountDownStart) % timeInterval == 0 && (elapsedTime - timeCountDownStart)!=0) // update every timeInterval second
                {
                    //Handle the missed cases
                    if (totalHitsCounted == false)
                    {
                        hitCostTimeList.Add("Missed");
                        textBox_hitCostTime.Text = "Missed";

                        TP = 0;
                        TPList.Add(TP);
                        textBox_throughput.Text = TP.ToString();
                    }

                    if (electrode == "IBT")
                    {
                        center = rnd.Next(1, 8) * 10; //number from 1 to 7
                    }
                    if (electrode == "OttoBock")
                    {
                        center = rnd.Next(1, 10) * 10;//number from 1 to 9
                    }

                    totalTrials++;
                    textBox_trials.Text = totalTrials.ToString();
                    textBox_hits.Text = totalHits.ToString();
                    hitCounts = 0;
                    totalHitsCounted = false;
                    hitCostTime = 0;//reset hitCostTime everytime the target bar changes

                    //Rest stuffs handling
                    textBox_InstructionBoard.Visible = true;
                    textBox_InstructionBoard.Text = "Rest for " + (timeRest - restTimeElapsed - 1) + "s";
                    timer_targetLevel.Enabled = false;
                    timer_100ms.Enabled = false;
                    timer_rest.Enabled = true;
                    isResting = true;
                }

                if (totalTrials == maxTrials)
                {
                    gameOver = true;
                    aveTP = Math.Round(TPList.Average(),2);
                    textBox_aveTP.Text = aveTP.ToString();
                    textBox_aveTP.BackColor = Color.Lime;

                    timer_targetLevel.Enabled = false;
                    timer_rest.Enabled = false;
                    center = 0;
                    MessageBox.Show("Game Finished! You get " + totalHits + " Hits out of " + totalTrials + " Trials!");
                    isGameStart = false;
                    button_StartGame.Enabled = true;
                    myStreamWriter.Write("Game Finished! You get " + totalHits + " Hits out of " + totalTrials + " Trials!");
                    myStreamWriter.WriteLine();
                    for (int i = 0; i < hitCostTimeList.Count; i++)
                    {
                        myStreamWriter.Write(hitCostTimeList[i] + "\t");
                    }
                    myStreamWriter.WriteLine();
                    for (int i = 0; i < TPList.Count; i++)
                    {
                        myStreamWriter.Write(TPList[i] + "\t");
                    }
                    myStreamWriter.WriteLine();
                    myStreamWriter.Write(aveTP);

                    button_stop_recording_Click(sender, e);
                    button_StartGame.BackColor = Color.Gold;
                    timer_100ms.Enabled = false;
                    textBox_countDown.Text = "";
                    textBox_hitCostTime.Text = "";
                    textBox_InstructionBoard.Visible = false;

                    showBar = true;
                }
            }
            
        }

        private void button_StartGame_Click(object sender, EventArgs e)
        {
            if (textBox_subjectName.Text != "")
            {
                hitCostTimeList.Clear();
                TPList.Clear();

                gameOver = false;
                showBar = false;
                elapsedTime = 0;
                textBox_trials.Text = "0";
                textBox_hits.Text = "0";
                textBox_throughput.Text = "";
                textBox_aveTP.Text = "";
                textBox_aveTP.BackColor = Color.White;
                isResting = false;
                hitCounts = 0;

                textBox_InstructionBoard.Visible = true;
                textBox_InstructionBoard.Text = "Game Starts in " + (timeCountDownStart - elapsedTime - 1) + "s";
                textBox_InstructionBoard.BackColor = Color.Lime;
                hitCostTime = 0;//reset after game start
                totalHits = 0;
                totalTrials = 0; //Already including the initial one, since it actually counts from 10, 20, ... 80 to get stopped, but the real number should be 7 (10-70).
                if(electrode == "IBT")
                {
                    center = rnd.Next(1, 8)*10; //number from 1 to 7
                }
                if(electrode == "OttoBock")
                {
                    center = rnd.Next(1, 10)*10;//number from 1 to 9
                }

                button_start_Click(sender, e);
                button_StartGame.BackColor = Color.Lime;
                button_StartGame.Enabled = false;
                button_start_recording_Click(sender, e);

                timer_targetLevel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Enter Your Name!");
            }
        }

        private void button_switchGraph_Click(object sender, EventArgs e)
        {
            showDigitized = !showDigitized;
            if (showDigitized)
            {
                button_switchGraph.Text = "Show Filtered EMG Signal";
            }
            else
            {
                button_switchGraph.Text = "Show Digitalized EMG Envelopl";
            }

            if(timer_display.Enabled == false)
            {
                button_display_file_Click(sender, e);
            }
        }

        private void button_start_recording_Click(object sender, EventArgs e)
        {
            if (textBox_subjectName.Text != "")
            {
                
                if (electrode == "IBT")
                {
                    if (!Directory.Exists(savingPath + textBox_subjectName.Text + electrode + textBox_envelopWinLen.Text))
                    {
                        Directory.CreateDirectory(savingPath + textBox_subjectName.Text + electrode + textBox_envelopWinLen.Text);
                    }
                    filePath = savingPath + textBox_subjectName.Text + electrode + textBox_envelopWinLen.Text + "\\" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".txt";
                }
                else if(electrode == "OttoBock")
                {
                    if (!Directory.Exists(savingPath + textBox_subjectName.Text + electrode ))
                    {
                        Directory.CreateDirectory(savingPath + textBox_subjectName.Text + electrode );
                    }
                    filePath = savingPath + textBox_subjectName.Text + electrode + "\\" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".txt";
                }
                
                myFileStream = new FileStream(filePath, System.IO.FileMode.Create);
                myStreamWriter = new StreamWriter(myFileStream);
                recording = true;

                button_start_recording.Enabled = false;
                button_stop_recording.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please input the subject's name!");
            }
        }

        private void button_stop_recording_Click(object sender, EventArgs e)
        {
            recording = false;
            myStreamWriter.Close();
            myFileStream.Close();

            button_start_recording.Enabled = true;
            button_stop_recording.Enabled = false;
        }

        private void button_select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.InitialDirectory = savingPath;
            myOpenFileDialog.Filter = "txt Files(*.txt)|*.txt|All Files(*.*)|*.*";
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                readingPath = myOpenFileDialog.FileName;
            }
            textBox_ReadDirectory.Text = readingPath;
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            button_display_file_Click(sender, e);
        }

        private void button_display_file_Click(object sender, EventArgs e)
        {
            if (textBox_ReadDirectory.Text != "")
            {
                timer_display.Enabled = false;
                readingPath = textBox_ReadDirectory.Text;
                Read_txt();
                this.chart_EMGrealtime.ChartAreas[0].AxisX.ScaleView.ZoomReset();//Reset the manually selected cursors if there are
                this.chart_EMGrealtime.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            }
            else
            {
                MessageBox.Show("Please Select or Input the Read File");
            }
        }

        private void Read_txt()
        {
            StreamReader myStreamReader = new StreamReader(readingPath, Encoding.Default);
            string wholeString;
            string[] wholeStringArray;
            int[] wholeIntArray;
            wholeString = myStreamReader.ReadToEnd();
            wholeStringArray = wholeString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            string readAveTP = wholeStringArray[wholeStringArray.Length - 1];
            string readHit = wholeStringArray[wholeStringArray.Length - 27];
            string readTrials = wholeStringArray[wholeStringArray.Length - 23];
            textBox_aveTP.Text = readAveTP; textBox_aveTP.BackColor = Color.Lime;
            textBox_hits.Text = readHit; textBox_trials.Text = readTrials;
            Array.Resize(ref wholeStringArray, wholeStringArray.Length - 31 );//Remove the last 10 elements in array by resizing, which are "Game Finished! You get " + totalHits + " Hits out of " + totalTrials + " Trials!" 
                                                                            //Remove the 10 hitCostTime values
                                                                            //Remove the 10 TPArray values
                                                                            //Remove 1 aveTP values
            wholeIntArray = Array.ConvertAll(wholeStringArray, int.Parse);
            myStreamReader.Close();

            int id = 0;
            for(int i=1; i< wholeIntArray.Length; i += 3)
            {
                savedEnvelop[id] = wholeIntArray[i];
                id++;
            }
            id = 0;
            for(int i=2; i<wholeIntArray.Length; i += 3)
            {
                savedDigitizedEnvelop[id] = wholeIntArray[i];
                id++;
            }

            DisplayFileData(id);
        }

        private void DisplayFileData(int dispLength)
        {
            this.chart_EMGrealtime.Series["EMGVal"].Points.Clear();
            for (disp = 0; disp < dispLength; disp++)
            {

                if (!showDigitized)
                {
                    this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = Double.NaN; //Default AutoScale
                    this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = Double.NaN;
                    this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = Double.NaN;
                    this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Filtered EMG Signal From File";
                    this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), savedEnvelop[disp]);
                }
                else
                {
                    if(electrode == "IBT")
                    {
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = 80;
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = 0;
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = 10;
                        this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Digitized EMG Signal (0-77) From File";
                        this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), savedDigitizedEnvelop[disp]);
                    }
                    else
                    {
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Maximum = 100;
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Minimum = 0;
                        this.chart_EMGrealtime.ChartAreas[0].AxisY.Interval = 10;
                        this.chart_EMGrealtime.Titles["EMG_Envelop"].Text = "Digitized EMG Signal (0-100) From File";
                        this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), savedDigitizedEnvelop[disp]);
                    }
                }
            }
        }

        private void button_return_realtime_Click(object sender, EventArgs e)
        {
            timer_display.Enabled = true;
        }

        private void button_IBTVD_Click(object sender, EventArgs e)
        {
            electrode = "IBT";
            button_IBTVD.Enabled = false;
            button_OB.Enabled = true;
        }

        private void button_OB_Click(object sender, EventArgs e)
        {
            electrode = "OttoBock";
            button_OB.Enabled = false;
            button_IBTVD.Enabled = true;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer_display.Enabled = false;
            button_pause.Enabled = false;
            button_startDisplay.Enabled = true;
        }

        private void timer_training_Tick(object sender, EventArgs e)
        {
            trainingElapsed++;

            if (trainingElapsed == trainingTime)
            {
                int[] TrainingData = new int[10000];//10s
                for (int i = counter - trainingTime * 1000; i < counter; i++)
                {
                    TrainingData[i - (counter - trainingTime * 1000)] = envelop[i];
                }

                if (electrode == "IBT")
                {
                    signalPeakD2 = TrainingData.Max(); //stepSizeD2 = 256/77
                }
                else if(electrode == "OttoBock")
                {
                    signalPeakOB = TrainingData.Max();
                    stepSizeOB = signalPeakOB / 100;
                }
                button_training.BackColor = Color.Lime;
                button_training.Text = "Your Trained Max Strength is " + TrainingData.Max().ToString() + "\n"+ "(Click to Retrain)";
                timer_training.Enabled = false;
                trainingElapsed = 0;//Reset training timer value
            }
        }

        private void button_training_Click(object sender, EventArgs e)
        {
            button_start_Click(sender,e);
            timer_training.Enabled = true;
            button_training.BackColor = Color.Cyan;
            button_training.Text = "Training: Perform Hard Flexions";
        }

        private void timer_100ms_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (hitCostTime / 1000.0).ToString()+"s";
            textBox_countDown.Text = (countDownTimer / 1000.0).ToString() + "s";

        }

        private void timer_rest_Tick(object sender, EventArgs e)
        {
            timer_targetLevel.Enabled = false;
            restTimeElapsed++;
            if (restTimeElapsed < timeRest - 1)
            {
                textBox_InstructionBoard.Text = "Rest for " + (timeRest - restTimeElapsed - 1) + "s";
            }
           if(restTimeElapsed == timeRest - 1)
            {
                textBox_InstructionBoard.Text = "Go!";
            }

            if(restTimeElapsed == timeRest)
            {
                textBox_InstructionBoard.Visible = false;
                timer_targetLevel.Enabled = true;
                timer_100ms.Enabled = true;
                countDownTimer = timeInterval * 1000;
                timer_rest.Enabled = false;
                restTimeElapsed = 0;
                isResting = false;
            }

        }

        private void button_resetCursor_Click(object sender, EventArgs e)
        {
            this.chart_EMGrealtime.ChartAreas[0].AxisX.ScaleView.ZoomReset();//Reset the manually selected cursors if there are
            this.chart_EMGrealtime.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }
    }
}
