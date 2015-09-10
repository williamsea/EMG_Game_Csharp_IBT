namespace Hai_EMG_Game
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button_startDisplay = new System.Windows.Forms.Button();
            this.timer_display = new System.Windows.Forms.Timer(this.components);
            this.chart_EMGrealtime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DigitBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar_displayLength = new System.Windows.Forms.TrackBar();
            this.label_trackBar = new System.Windows.Forms.Label();
            this.timer_targetLevel = new System.Windows.Forms.Timer(this.components);
            this.button_StartGame = new System.Windows.Forms.Button();
            this.button_switchGraph = new System.Windows.Forms.Button();
            this.button_start_recording = new System.Windows.Forms.Button();
            this.button_stop_recording = new System.Windows.Forms.Button();
            this.textBox_subjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_pause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_envelopWinLen = new System.Windows.Forms.TextBox();
            this.button_return_realtime = new System.Windows.Forms.Button();
            this.button_display_file = new System.Windows.Forms.Button();
            this.button_select_file = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_ReadDirectory = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_IBTVD = new System.Windows.Forms.Button();
            this.button_OB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_training = new System.Windows.Forms.Button();
            this.timer_training = new System.Windows.Forms.Timer(this.components);
            this.textBox_hitCostTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_100ms = new System.Windows.Forms.Timer(this.components);
            this.textBox_InstructionBoard = new System.Windows.Forms.TextBox();
            this.timer_rest = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_countDown = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_trials = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_measuringTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_reactionTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_completedRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_stdevTP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_timeInTarget = new System.Windows.Forms.TextBox();
            this.textBox_countUpTimer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_hits = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_aveTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_throughput = new System.Windows.Forms.TextBox();
            this.button_resetCursor = new System.Windows.Forms.Button();
            this.button_FFT = new System.Windows.Forms.Button();
            this.button_hideStats = new System.Windows.Forms.Button();
            this.pictureBox_hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EMGrealtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_displayLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 250000;
            this.serialPort.PortName = "COM2";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // button_startDisplay
            // 
            this.button_startDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startDisplay.Location = new System.Drawing.Point(4, 30);
            this.button_startDisplay.Name = "button_startDisplay";
            this.button_startDisplay.Size = new System.Drawing.Size(69, 50);
            this.button_startDisplay.TabIndex = 1;
            this.button_startDisplay.Text = "Start Display";
            this.button_startDisplay.UseVisualStyleBackColor = true;
            this.button_startDisplay.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer_display
            // 
            this.timer_display.Interval = 1;
            this.timer_display.Tick += new System.EventHandler(this.timer_display_Tick);
            // 
            // chart_EMGrealtime
            // 
            chartArea7.AxisX.Title = "Time (s)";
            chartArea7.AxisY.Title = "Envelop";
            chartArea7.BorderWidth = 2;
            chartArea7.CursorX.IsUserSelectionEnabled = true;
            chartArea7.CursorY.IsUserSelectionEnabled = true;
            chartArea7.Name = "ChartArea1";
            this.chart_EMGrealtime.ChartAreas.Add(chartArea7);
            this.chart_EMGrealtime.Location = new System.Drawing.Point(256, 69);
            this.chart_EMGrealtime.Name = "chart_EMGrealtime";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Name = "EMGVal";
            this.chart_EMGrealtime.Series.Add(series10);
            this.chart_EMGrealtime.Size = new System.Drawing.Size(825, 702);
            this.chart_EMGrealtime.TabIndex = 3;
            this.chart_EMGrealtime.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "EMG_Envelop";
            title7.Text = "EMG Envelop";
            this.chart_EMGrealtime.Titles.Add(title7);
            // 
            // chart_DigitBar
            // 
            chartArea8.AxisY.Interval = 10D;
            chartArea8.AxisY.Maximum = 80D;
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.BorderWidth = 2;
            chartArea8.CursorX.IsUserSelectionEnabled = true;
            chartArea8.Name = "ChartArea1";
            this.chart_DigitBar.ChartAreas.Add(chartArea8);
            this.chart_DigitBar.Location = new System.Drawing.Point(1087, 69);
            this.chart_DigitBar.Name = "chart_DigitBar";
            series11.BorderWidth = 5;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series11.Name = "BarEMGVal";
            series11.YValuesPerPoint = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series12.Name = "targetLevel";
            series12.YValuesPerPoint = 2;
            this.chart_DigitBar.Series.Add(series11);
            this.chart_DigitBar.Series.Add(series12);
            this.chart_DigitBar.Size = new System.Drawing.Size(328, 702);
            this.chart_DigitBar.TabIndex = 5;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Real Time Bar";
            title8.Text = "Real Time Bar";
            this.chart_DigitBar.Titles.Add(title8);
            // 
            // trackBar_displayLength
            // 
            this.trackBar_displayLength.Location = new System.Drawing.Point(11, 93);
            this.trackBar_displayLength.Maximum = 10000;
            this.trackBar_displayLength.Minimum = 1000;
            this.trackBar_displayLength.Name = "trackBar_displayLength";
            this.trackBar_displayLength.Size = new System.Drawing.Size(202, 45);
            this.trackBar_displayLength.TabIndex = 8;
            this.trackBar_displayLength.Value = 10000;
            this.trackBar_displayLength.Scroll += new System.EventHandler(this.trackBar_displayLength_Scroll);
            // 
            // label_trackBar
            // 
            this.label_trackBar.AutoSize = true;
            this.label_trackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trackBar.Location = new System.Drawing.Point(8, 136);
            this.label_trackBar.Name = "label_trackBar";
            this.label_trackBar.Size = new System.Drawing.Size(209, 15);
            this.label_trackBar.TabIndex = 9;
            this.label_trackBar.Text = "Select Display Length From 1s to 10s";
            // 
            // timer_targetLevel
            // 
            this.timer_targetLevel.Interval = 1000;
            this.timer_targetLevel.Tick += new System.EventHandler(this.timer_targetLevel_Tick);
            // 
            // button_StartGame
            // 
            this.button_StartGame.BackColor = System.Drawing.Color.Gold;
            this.button_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartGame.Location = new System.Drawing.Point(150, 30);
            this.button_StartGame.Name = "button_StartGame";
            this.button_StartGame.Size = new System.Drawing.Size(89, 50);
            this.button_StartGame.TabIndex = 10;
            this.button_StartGame.Text = "Start Game";
            this.button_StartGame.UseVisualStyleBackColor = false;
            this.button_StartGame.Click += new System.EventHandler(this.button_StartGame_Click);
            // 
            // button_switchGraph
            // 
            this.button_switchGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_switchGraph.Location = new System.Drawing.Point(453, 777);
            this.button_switchGraph.Name = "button_switchGraph";
            this.button_switchGraph.Size = new System.Drawing.Size(263, 36);
            this.button_switchGraph.TabIndex = 11;
            this.button_switchGraph.Text = "Show Digitalized EMG Envelop";
            this.button_switchGraph.UseVisualStyleBackColor = true;
            this.button_switchGraph.Click += new System.EventHandler(this.button_switchGraph_Click);
            // 
            // button_start_recording
            // 
            this.button_start_recording.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_recording.Location = new System.Drawing.Point(19, 153);
            this.button_start_recording.Name = "button_start_recording";
            this.button_start_recording.Size = new System.Drawing.Size(99, 50);
            this.button_start_recording.TabIndex = 12;
            this.button_start_recording.Text = "Start Recording";
            this.button_start_recording.UseVisualStyleBackColor = true;
            this.button_start_recording.Click += new System.EventHandler(this.button_start_recording_Click);
            // 
            // button_stop_recording
            // 
            this.button_stop_recording.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop_recording.Location = new System.Drawing.Point(118, 153);
            this.button_stop_recording.Name = "button_stop_recording";
            this.button_stop_recording.Size = new System.Drawing.Size(99, 50);
            this.button_stop_recording.TabIndex = 13;
            this.button_stop_recording.Text = "Stop Recording";
            this.button_stop_recording.UseVisualStyleBackColor = true;
            this.button_stop_recording.Click += new System.EventHandler(this.button_stop_recording_Click);
            // 
            // textBox_subjectName
            // 
            this.textBox_subjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subjectName.Location = new System.Drawing.Point(9, 64);
            this.textBox_subjectName.Name = "textBox_subjectName";
            this.textBox_subjectName.Size = new System.Drawing.Size(204, 26);
            this.textBox_subjectName.TabIndex = 14;
            this.textBox_subjectName.Text = "Temp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Subject:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.button_pause);
            this.groupBox1.Controls.Add(this.button_StartGame);
            this.groupBox1.Controls.Add(this.button_startDisplay);
            this.groupBox1.Controls.Add(this.trackBar_displayLength);
            this.groupBox1.Controls.Add(this.label_trackBar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 167);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // button_pause
            // 
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pause.Location = new System.Drawing.Point(76, 30);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(71, 50);
            this.button_pause.TabIndex = 11;
            this.button_pause.Text = "Pause Display";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_envelopWinLen);
            this.groupBox2.Controls.Add(this.button_stop_recording);
            this.groupBox2.Controls.Add(this.button_start_recording);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_subjectName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 211);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Envelop Window Length:";
            // 
            // textBox_envelopWinLen
            // 
            this.textBox_envelopWinLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_envelopWinLen.Location = new System.Drawing.Point(11, 121);
            this.textBox_envelopWinLen.Name = "textBox_envelopWinLen";
            this.textBox_envelopWinLen.Size = new System.Drawing.Size(50, 26);
            this.textBox_envelopWinLen.TabIndex = 16;
            this.textBox_envelopWinLen.Text = "300";
            // 
            // button_return_realtime
            // 
            this.button_return_realtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return_realtime.Location = new System.Drawing.Point(49, 135);
            this.button_return_realtime.Name = "button_return_realtime";
            this.button_return_realtime.Size = new System.Drawing.Size(168, 33);
            this.button_return_realtime.TabIndex = 52;
            this.button_return_realtime.Text = "Return Real Time";
            this.button_return_realtime.UseVisualStyleBackColor = true;
            this.button_return_realtime.Click += new System.EventHandler(this.button_return_realtime_Click);
            // 
            // button_display_file
            // 
            this.button_display_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_display_file.Location = new System.Drawing.Point(126, 96);
            this.button_display_file.Name = "button_display_file";
            this.button_display_file.Size = new System.Drawing.Size(91, 33);
            this.button_display_file.TabIndex = 51;
            this.button_display_file.Text = "(Display)";
            this.button_display_file.UseVisualStyleBackColor = true;
            this.button_display_file.Click += new System.EventHandler(this.button_display_file_Click);
            // 
            // button_select_file
            // 
            this.button_select_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_file.Location = new System.Drawing.Point(150, 36);
            this.button_select_file.Name = "button_select_file";
            this.button_select_file.Size = new System.Drawing.Size(67, 33);
            this.button_select_file.TabIndex = 50;
            this.button_select_file.Text = "Select File";
            this.button_select_file.UseVisualStyleBackColor = true;
            this.button_select_file.Click += new System.EventHandler(this.button_select_file_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(15, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 20);
            this.label28.TabIndex = 48;
            this.label28.Text = "Directory: ";
            // 
            // textBox_ReadDirectory
            // 
            this.textBox_ReadDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReadDirectory.Location = new System.Drawing.Point(20, 70);
            this.textBox_ReadDirectory.Name = "textBox_ReadDirectory";
            this.textBox_ReadDirectory.Size = new System.Drawing.Size(197, 20);
            this.textBox_ReadDirectory.TabIndex = 49;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.textBox_ReadDirectory);
            this.groupBox3.Controls.Add(this.button_return_realtime);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.button_display_file);
            this.groupBox3.Controls.Add(this.button_select_file);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 589);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 182);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read Existing";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.button_IBTVD);
            this.groupBox4.Controls.Add(this.button_OB);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 100);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Electrode";
            // 
            // button_IBTVD
            // 
            this.button_IBTVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IBTVD.Location = new System.Drawing.Point(124, 30);
            this.button_IBTVD.Name = "button_IBTVD";
            this.button_IBTVD.Size = new System.Drawing.Size(93, 50);
            this.button_IBTVD.TabIndex = 12;
            this.button_IBTVD.Text = "IBT Version D";
            this.button_IBTVD.UseVisualStyleBackColor = true;
            this.button_IBTVD.Click += new System.EventHandler(this.button_IBTVD_Click);
            // 
            // button_OB
            // 
            this.button_OB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OB.Location = new System.Drawing.Point(19, 30);
            this.button_OB.Name = "button_OB";
            this.button_OB.Size = new System.Drawing.Size(99, 50);
            this.button_OB.TabIndex = 11;
            this.button_OB.Text = "OttoBocks";
            this.button_OB.UseVisualStyleBackColor = true;
            this.button_OB.Click += new System.EventHandler(this.button_OB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 57);
            this.label4.TabIndex = 19;
            this.label4.Text = "The EMG Game";
            // 
            // button_training
            // 
            this.button_training.BackColor = System.Drawing.Color.Gold;
            this.button_training.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_training.Location = new System.Drawing.Point(1114, 16);
            this.button_training.Name = "button_training";
            this.button_training.Size = new System.Drawing.Size(271, 50);
            this.button_training.TabIndex = 12;
            this.button_training.Text = "Train (Calibrate Your Max Strength)";
            this.button_training.UseVisualStyleBackColor = false;
            this.button_training.Click += new System.EventHandler(this.button_training_Click);
            // 
            // timer_training
            // 
            this.timer_training.Interval = 1000;
            this.timer_training.Tick += new System.EventHandler(this.timer_training_Tick);
            // 
            // textBox_hitCostTime
            // 
            this.textBox_hitCostTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hitCostTime.Location = new System.Drawing.Point(560, 23);
            this.textBox_hitCostTime.Name = "textBox_hitCostTime";
            this.textBox_hitCostTime.Size = new System.Drawing.Size(62, 26);
            this.textBox_hitCostTime.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Total Hit Cost Time:";
            // 
            // timer_100ms
            // 
            this.timer_100ms.Interval = 1;
            this.timer_100ms.Tick += new System.EventHandler(this.timer_100ms_Tick);
            // 
            // textBox_InstructionBoard
            // 
            this.textBox_InstructionBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InstructionBoard.Location = new System.Drawing.Point(256, 364);
            this.textBox_InstructionBoard.Name = "textBox_InstructionBoard";
            this.textBox_InstructionBoard.Size = new System.Drawing.Size(825, 116);
            this.textBox_InstructionBoard.TabIndex = 19;
            this.textBox_InstructionBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InstructionBoard.Visible = false;
            // 
            // timer_rest
            // 
            this.timer_rest.Interval = 1000;
            this.timer_rest.Tick += new System.EventHandler(this.timer_rest_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Cnt Dwn Timer:";
            // 
            // textBox_countDown
            // 
            this.textBox_countDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_countDown.Location = new System.Drawing.Point(130, 52);
            this.textBox_countDown.Name = "textBox_countDown";
            this.textBox_countDown.Size = new System.Drawing.Size(62, 26);
            this.textBox_countDown.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Trials Cmpltd:";
            // 
            // textBox_trials
            // 
            this.textBox_trials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_trials.Location = new System.Drawing.Point(130, 78);
            this.textBox_trials.Name = "textBox_trials";
            this.textBox_trials.Size = new System.Drawing.Size(62, 26);
            this.textBox_trials.TabIndex = 57;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Controls.Add(this.pictureBox_hide);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBox_measuringTime);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox_reactionTime);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox_completedRate);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBox_stdevTP);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox_timeInTarget);
            this.groupBox5.Controls.Add(this.textBox_countUpTimer);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBox_hits);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.textBox_aveTP);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBox_throughput);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox_hitCostTime);
            this.groupBox5.Controls.Add(this.textBox_trials);
            this.groupBox5.Controls.Add(this.textBox_countDown);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(784, 777);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(631, 148);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Statistics";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(407, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 20);
            this.label16.TabIndex = 76;
            this.label16.Text = "Measuring  Time:";
            // 
            // textBox_measuringTime
            // 
            this.textBox_measuringTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_measuringTime.Location = new System.Drawing.Point(560, 50);
            this.textBox_measuringTime.Name = "textBox_measuringTime";
            this.textBox_measuringTime.Size = new System.Drawing.Size(62, 26);
            this.textBox_measuringTime.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 74;
            this.label15.Text = "Reaction Time:";
            // 
            // textBox_reactionTime
            // 
            this.textBox_reactionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reactionTime.Location = new System.Drawing.Point(130, 26);
            this.textBox_reactionTime.Name = "textBox_reactionTime";
            this.textBox_reactionTime.Size = new System.Drawing.Size(62, 26);
            this.textBox_reactionTime.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(407, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "Cmplted Rate:";
            // 
            // textBox_completedRate
            // 
            this.textBox_completedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_completedRate.Location = new System.Drawing.Point(560, 77);
            this.textBox_completedRate.Name = "textBox_completedRate";
            this.textBox_completedRate.Size = new System.Drawing.Size(62, 26);
            this.textBox_completedRate.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(407, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 70;
            this.label13.Text = "Stdev TP:";
            // 
            // textBox_stdevTP
            // 
            this.textBox_stdevTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stdevTP.Location = new System.Drawing.Point(560, 104);
            this.textBox_stdevTP.Name = "textBox_stdevTP";
            this.textBox_stdevTP.Size = new System.Drawing.Size(62, 26);
            this.textBox_stdevTP.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(202, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Cnt Up Timer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(202, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Time in Target:";
            // 
            // textBox_timeInTarget
            // 
            this.textBox_timeInTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_timeInTarget.Location = new System.Drawing.Point(329, 26);
            this.textBox_timeInTarget.Name = "textBox_timeInTarget";
            this.textBox_timeInTarget.Size = new System.Drawing.Size(62, 26);
            this.textBox_timeInTarget.TabIndex = 66;
            // 
            // textBox_countUpTimer
            // 
            this.textBox_countUpTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_countUpTimer.Location = new System.Drawing.Point(329, 52);
            this.textBox_countUpTimer.Name = "textBox_countUpTimer";
            this.textBox_countUpTimer.Size = new System.Drawing.Size(62, 26);
            this.textBox_countUpTimer.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(202, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "Total Hits:";
            // 
            // textBox_hits
            // 
            this.textBox_hits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hits.Location = new System.Drawing.Point(329, 78);
            this.textBox_hits.Name = "textBox_hits";
            this.textBox_hits.Size = new System.Drawing.Size(62, 26);
            this.textBox_hits.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Average TP:";
            // 
            // textBox_aveTP
            // 
            this.textBox_aveTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_aveTP.Location = new System.Drawing.Point(329, 104);
            this.textBox_aveTP.Name = "textBox_aveTP";
            this.textBox_aveTP.Size = new System.Drawing.Size(62, 26);
            this.textBox_aveTP.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Throughput:";
            // 
            // textBox_throughput
            // 
            this.textBox_throughput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_throughput.Location = new System.Drawing.Point(130, 104);
            this.textBox_throughput.Name = "textBox_throughput";
            this.textBox_throughput.Size = new System.Drawing.Size(62, 26);
            this.textBox_throughput.TabIndex = 59;
            // 
            // button_resetCursor
            // 
            this.button_resetCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetCursor.Location = new System.Drawing.Point(256, 777);
            this.button_resetCursor.Name = "button_resetCursor";
            this.button_resetCursor.Size = new System.Drawing.Size(134, 36);
            this.button_resetCursor.TabIndex = 53;
            this.button_resetCursor.Text = "Reset Cursor";
            this.button_resetCursor.UseVisualStyleBackColor = true;
            this.button_resetCursor.Click += new System.EventHandler(this.button_resetCursor_Click);
            // 
            // button_FFT
            // 
            this.button_FFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FFT.Location = new System.Drawing.Point(256, 829);
            this.button_FFT.Name = "button_FFT";
            this.button_FFT.Size = new System.Drawing.Size(168, 36);
            this.button_FFT.TabIndex = 60;
            this.button_FFT.Text = "Frequency Analysis";
            this.button_FFT.UseVisualStyleBackColor = true;
            this.button_FFT.Click += new System.EventHandler(this.button_FFT_Click);
            // 
            // button_hideStats
            // 
            this.button_hideStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hideStats.Location = new System.Drawing.Point(648, 885);
            this.button_hideStats.Name = "button_hideStats";
            this.button_hideStats.Size = new System.Drawing.Size(130, 36);
            this.button_hideStats.TabIndex = 61;
            this.button_hideStats.Text = "Hide Statistics";
            this.button_hideStats.UseVisualStyleBackColor = true;
            this.button_hideStats.Click += new System.EventHandler(this.button_hideStats_Click);
            // 
            // pictureBox_hide
            // 
            this.pictureBox_hide.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_hide.Name = "pictureBox_hide";
            this.pictureBox_hide.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_hide.TabIndex = 77;
            this.pictureBox_hide.TabStop = false;
            this.pictureBox_hide.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 928);
            this.Controls.Add(this.button_hideStats);
            this.Controls.Add(this.button_FFT);
            this.Controls.Add(this.button_resetCursor);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBox_InstructionBoard);
            this.Controls.Add(this.button_training);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_switchGraph);
            this.Controls.Add(this.chart_DigitBar);
            this.Controls.Add(this.chart_EMGrealtime);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_EMGrealtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_displayLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button_startDisplay;
        private System.Windows.Forms.Timer timer_display;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_EMGrealtime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DigitBar;
        private System.Windows.Forms.TrackBar trackBar_displayLength;
        private System.Windows.Forms.Label label_trackBar;
        private System.Windows.Forms.Timer timer_targetLevel;
        private System.Windows.Forms.Button button_StartGame;
        private System.Windows.Forms.Button button_switchGraph;
        private System.Windows.Forms.Button button_start_recording;
        private System.Windows.Forms.Button button_stop_recording;
        private System.Windows.Forms.TextBox textBox_subjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_return_realtime;
        private System.Windows.Forms.Button button_display_file;
        private System.Windows.Forms.Button button_select_file;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_ReadDirectory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_envelopWinLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_IBTVD;
        private System.Windows.Forms.Button button_OB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_training;
        private System.Windows.Forms.Timer timer_training;
        private System.Windows.Forms.TextBox textBox_hitCostTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_100ms;
        private System.Windows.Forms.TextBox textBox_InstructionBoard;
        private System.Windows.Forms.Timer timer_rest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_countDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_trials;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_throughput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_aveTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_hits;
        private System.Windows.Forms.Button button_resetCursor;
        private System.Windows.Forms.TextBox textBox_countUpTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_timeInTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_stdevTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_completedRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_reactionTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_measuringTime;
        private System.Windows.Forms.Button button_FFT;
        private System.Windows.Forms.Button button_hideStats;
        private System.Windows.Forms.PictureBox pictureBox_hide;
    }
}

