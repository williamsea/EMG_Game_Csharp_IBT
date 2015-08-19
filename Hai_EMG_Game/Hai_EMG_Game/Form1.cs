using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
Author: Hai Tang (haitang@jhu.edu)
*/
namespace Hai_EMG_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Data Acquisition and Bit Manipulation
        int counter = 0;
        int[] receivedBuffer = new int[500];
        int firstByte;
        int secondByte;
        int thirdByte;
        int combine;
        bool sign = false;
        int[] envelop = new int[1000000];//1000s
        int[] DACenvelop = new int[1000000];
        int[] digitizedEnvelop = new int[1000000];
        int signalPeak = 800;
        double stepSize = 255 / 77; //0-255, digitizedLevel = 77;
        Encoding enc = Encoding.GetEncoding(1252);

        //Display
        int DisplayLength = 10000; //Sampling rate = 1000
        int disp;

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            for (int i = 0; i < receivedBuffer.Length; i++)
            {
                receivedBuffer[i] = serialPort.ReadByte();
                //Read a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.
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
                    DACenvelop[counter] = envelop[counter] * 255 / signalPeak;
                    if (DACenvelop[counter] > 255)
                    {
                        DACenvelop[counter] = 255;
                    }
                    digitizedEnvelop[counter] = (int)(DACenvelop[counter] / stepSize); //No need to floor an int since it's auto truncked.
                    counter++;
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

            if (counter > 1)
            {
                this.chart_DigitBar.Series["BarEMGVal"].Points.Clear();
                this.chart_DigitBar.Series["BarEMGVal"].Points.AddXY("Strength", digitizedEnvelop[counter-1]); //Note that counter++ after putting in data. So we need counter - 1 here!!!
            }


            this.chart_EMGrealtime.Series["EMGVal"].Points.Clear();
            if (counter >= DisplayLength)
            {
                for (disp = counter - DisplayLength; disp < counter; disp++)
                {
                    this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), envelop[disp]);
                }
            }
            else
            {
                for (disp = 0; disp < DisplayLength; disp++)
                {
                    this.chart_EMGrealtime.Series["EMGVal"].Points.AddXY((disp / 1000).ToString(), envelop[disp]);
                }
            }
        }



        //Test button and timer for debugging
        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.chart_DigitBar.Series["BarEMGVal"].Points.Clear();
            this.chart_DigitBar.Series["BarEMGVal"].Points.AddXY("Halo", 100);
            timerTest.Enabled = true;
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            disp++;
            this.chart_DigitBar.Series["BarEMGVal"].Points.Clear();
            this.chart_DigitBar.Series["BarEMGVal"].Points.AddXY("Halo", disp);
        }
    }
}
