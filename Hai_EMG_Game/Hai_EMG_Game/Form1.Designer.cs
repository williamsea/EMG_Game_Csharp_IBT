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
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.timer_display = new System.Windows.Forms.Timer(this.components);
            this.chart_EMGrealtime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DigitBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonTest = new System.Windows.Forms.Button();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.chart_digitEMG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar_displayLength = new System.Windows.Forms.TrackBar();
            this.label_trackBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EMGrealtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_digitEMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_displayLength)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 250000;
            this.serialPort.PortName = "COM2";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(28, 402);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer_display
            // 
            this.timer_display.Interval = 1;
            this.timer_display.Tick += new System.EventHandler(this.timer_display_Tick);
            // 
            // chart_EMGrealtime
            // 
            chartArea7.BorderWidth = 2;
            chartArea7.CursorX.IsUserSelectionEnabled = true;
            chartArea7.Name = "ChartArea1";
            this.chart_EMGrealtime.ChartAreas.Add(chartArea7);
            this.chart_EMGrealtime.Location = new System.Drawing.Point(252, 3);
            this.chart_EMGrealtime.Name = "chart_EMGrealtime";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Name = "EMGVal";
            this.chart_EMGrealtime.Series.Add(series7);
            this.chart_EMGrealtime.Size = new System.Drawing.Size(825, 702);
            this.chart_EMGrealtime.TabIndex = 3;
            this.chart_EMGrealtime.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "EMG Envelop";
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
            this.chart_DigitBar.Location = new System.Drawing.Point(1083, 3);
            this.chart_DigitBar.Name = "chart_DigitBar";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.Name = "BarEMGVal";
            series8.YValuesPerPoint = 2;
            this.chart_DigitBar.Series.Add(series8);
            this.chart_DigitBar.Size = new System.Drawing.Size(328, 702);
            this.chart_DigitBar.TabIndex = 5;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Real Time Bar";
            title8.Text = "Real Time Bar";
            this.chart_DigitBar.Titles.Add(title8);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(146, 402);
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
            // chart_digitEMG
            // 
            chartArea9.BorderWidth = 2;
            chartArea9.CursorX.IsUserSelectionEnabled = true;
            chartArea9.Name = "ChartArea1";
            this.chart_digitEMG.ChartAreas.Add(chartArea9);
            this.chart_digitEMG.Location = new System.Drawing.Point(252, 711);
            this.chart_digitEMG.Name = "chart_digitEMG";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Name = "digitEMGVal";
            this.chart_digitEMG.Series.Add(series9);
            this.chart_digitEMG.Size = new System.Drawing.Size(825, 17);
            this.chart_digitEMG.TabIndex = 7;
            this.chart_digitEMG.Text = "chart1";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "Digitized EMG Envelop";
            title9.Text = "Digitized EMG Envelop";
            this.chart_digitEMG.Titles.Add(title9);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 740);
            this.Controls.Add(this.label_trackBar);
            this.Controls.Add(this.trackBar_displayLength);
            this.Controls.Add(this.chart_digitEMG);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.chart_DigitBar);
            this.Controls.Add(this.chart_EMGrealtime);
            this.Controls.Add(this.button_start);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_EMGrealtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DigitBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_digitEMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_displayLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer_display;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_EMGrealtime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DigitBar;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_digitEMG;
        private System.Windows.Forms.TrackBar trackBar_displayLength;
        private System.Windows.Forms.Label label_trackBar;
    }
}

