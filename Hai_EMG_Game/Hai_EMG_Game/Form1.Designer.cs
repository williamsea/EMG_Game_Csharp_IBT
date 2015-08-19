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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button_startDisplay = new System.Windows.Forms.Button();
            this.timer_display = new System.Windows.Forms.Timer(this.components);
            this.chart_EMGrealtime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DigitBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonTest = new System.Windows.Forms.Button();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.trackBar_displayLength = new System.Windows.Forms.TrackBar();
            this.label_trackBar = new System.Windows.Forms.Label();
            this.timer_targetLevel = new System.Windows.Forms.Timer(this.components);
            this.button_StartGame = new System.Windows.Forms.Button();
            this.button_switchGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EMGrealtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_displayLength)).BeginInit();
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
            this.button_startDisplay.Location = new System.Drawing.Point(28, 375);
            this.button_startDisplay.Name = "button_startDisplay";
            this.button_startDisplay.Size = new System.Drawing.Size(89, 50);
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
            chartArea3.BorderWidth = 2;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.Name = "ChartArea1";
            this.chart_EMGrealtime.ChartAreas.Add(chartArea3);
            this.chart_EMGrealtime.Location = new System.Drawing.Point(252, 3);
            this.chart_EMGrealtime.Name = "chart_EMGrealtime";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "EMGVal";
            this.chart_EMGrealtime.Series.Add(series4);
            this.chart_EMGrealtime.Size = new System.Drawing.Size(825, 702);
            this.chart_EMGrealtime.TabIndex = 3;
            this.chart_EMGrealtime.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "EMG_Envelop";
            title3.Text = "EMG Envelop";
            this.chart_EMGrealtime.Titles.Add(title3);
            // 
            // chart_DigitBar
            // 
            chartArea4.AxisY.Interval = 10D;
            chartArea4.AxisY.Maximum = 80D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.BorderWidth = 2;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.Name = "ChartArea1";
            this.chart_DigitBar.ChartAreas.Add(chartArea4);
            this.chart_DigitBar.Location = new System.Drawing.Point(1083, 3);
            this.chart_DigitBar.Name = "chart_DigitBar";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series5.Name = "BarEMGVal";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series6.Name = "targetLevel";
            series6.YValuesPerPoint = 2;
            this.chart_DigitBar.Series.Add(series5);
            this.chart_DigitBar.Series.Add(series6);
            this.chart_DigitBar.Size = new System.Drawing.Size(328, 702);
            this.chart_DigitBar.TabIndex = 5;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Real Time Bar";
            title4.Text = "Real Time Bar";
            this.chart_DigitBar.Titles.Add(title4);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(171, 711);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // timerTest
            // 
            this.timerTest.Interval = 1;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // trackBar_displayLength
            // 
            this.trackBar_displayLength.Location = new System.Drawing.Point(28, 288);
            this.trackBar_displayLength.Maximum = 10000;
            this.trackBar_displayLength.Minimum = 100;
            this.trackBar_displayLength.Name = "trackBar_displayLength";
            this.trackBar_displayLength.Size = new System.Drawing.Size(193, 45);
            this.trackBar_displayLength.TabIndex = 8;
            this.trackBar_displayLength.Value = 100;
            this.trackBar_displayLength.Scroll += new System.EventHandler(this.trackBar_displayLength_Scroll);
            // 
            // label_trackBar
            // 
            this.label_trackBar.AutoSize = true;
            this.label_trackBar.Location = new System.Drawing.Point(39, 320);
            this.label_trackBar.Name = "label_trackBar";
            this.label_trackBar.Size = new System.Drawing.Size(182, 13);
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
            this.button_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartGame.Location = new System.Drawing.Point(141, 375);
            this.button_StartGame.Name = "button_StartGame";
            this.button_StartGame.Size = new System.Drawing.Size(89, 50);
            this.button_StartGame.TabIndex = 10;
            this.button_StartGame.Text = "Start Game";
            this.button_StartGame.UseVisualStyleBackColor = true;
            this.button_StartGame.Click += new System.EventHandler(this.button_StartGame_Click);
            // 
            // button_switchGraph
            // 
            this.button_switchGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_switchGraph.Location = new System.Drawing.Point(559, 703);
            this.button_switchGraph.Name = "button_switchGraph";
            this.button_switchGraph.Size = new System.Drawing.Size(263, 36);
            this.button_switchGraph.TabIndex = 11;
            this.button_switchGraph.Text = "Show Digitalized EMG Envelop";
            this.button_switchGraph.UseVisualStyleBackColor = true;
            this.button_switchGraph.Click += new System.EventHandler(this.button_switchGraph_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 740);
            this.Controls.Add(this.button_switchGraph);
            this.Controls.Add(this.button_StartGame);
            this.Controls.Add(this.label_trackBar);
            this.Controls.Add(this.trackBar_displayLength);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.chart_DigitBar);
            this.Controls.Add(this.chart_EMGrealtime);
            this.Controls.Add(this.button_startDisplay);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_EMGrealtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_displayLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button_startDisplay;
        private System.Windows.Forms.Timer timer_display;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_EMGrealtime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DigitBar;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.TrackBar trackBar_displayLength;
        private System.Windows.Forms.Label label_trackBar;
        private System.Windows.Forms.Timer timer_targetLevel;
        private System.Windows.Forms.Button button_StartGame;
        private System.Windows.Forms.Button button_switchGraph;
    }
}

