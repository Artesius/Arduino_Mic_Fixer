namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butStart = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.butRecord = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSredn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Magenta;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(470, 472);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(539, 12);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(134, 36);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Старт/Скид";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(549, 51);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(18, 20);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "0";
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(539, 103);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(134, 61);
            this.butStop.TabIndex = 4;
            this.butStop.Text = "Стоп";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // butRecord
            // 
            this.butRecord.Location = new System.Drawing.Point(539, 170);
            this.butRecord.Name = "butRecord";
            this.butRecord.Size = new System.Drawing.Size(134, 65);
            this.butRecord.TabIndex = 5;
            this.butRecord.Text = "Запис";
            this.butRecord.UseVisualStyleBackColor = true;
            this.butRecord.Click += new System.EventHandler(this.button3_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(539, 412);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(134, 72);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Вихід";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(539, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 89);
            this.label2.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(81, 464);
            this.listBox2.TabIndex = 9;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(508, 54);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(165, 85);
            this.butSave.TabIndex = 10;
            this.butSave.Text = "Зберегти";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Visible = false;
            this.butSave.Click += new System.EventHandler(this.button5_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(508, 241);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(165, 85);
            this.butReset.TabIndex = 11;
            this.butReset.Text = "Скинути";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Visible = false;
            this.butReset.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(99, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(193, 464);
            this.listBox3.TabIndex = 12;
            this.listBox3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(539, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Середнє значення:";
            this.label1.Visible = false;
            // 
            // lblSredn
            // 
            this.lblSredn.AutoSize = true;
            this.lblSredn.Location = new System.Drawing.Point(504, 167);
            this.lblSredn.Name = "lblSredn";
            this.lblSredn.Size = new System.Drawing.Size(0, 20);
            this.lblSredn.TabIndex = 15;
            this.lblSredn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 496);
            this.Controls.Add(this.lblSredn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butRecord);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butRecord;
        private System.Windows.Forms.Button butExit;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSredn;
    }
}

