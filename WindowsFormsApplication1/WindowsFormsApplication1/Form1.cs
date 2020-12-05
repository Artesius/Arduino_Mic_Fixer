using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int x = 0;
        int firstIndex = -1, secondIndex = -1;
        int[] arraynumy = new int[0];
        int[]  arraynumx = new int[0];
        int y;
        string volume;
        double sum, sredn;
        public Form1()
        {
            InitializeComponent();
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            volume = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), volume);
        }

        private delegate void LineReceivedEvent(string volume);

        private void LineReceived(string volume)
        {
            lblVolume.Text = volume;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) label2.Text = "Остановите Программу";
            else
            {
                label2.Text = "";
                chart1.Visible = false;
                lblVolume.Visible = false;
                butStop.Visible = false;
                butRecord.Visible = false;
                butStart.Visible = false;
                listBox2.Visible = true;
                listBox3.Visible = true;
                butSave.Visible = true;
                butReset.Visible = true;
                comboBox1.Visible = false;
                lblSredn.Visible = true;
                label1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();

                serialPort1.DataReceived += serialPort1_DataReceived;
                timer1.Enabled = true;
            }
            else  
            {
                chart1.Series[0].Points.Clear();
                x = 0;
                listBox2.Items.Clear();
                listBox3.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            lblVolume.Visible = true;
            butStop.Visible =true;
            butRecord.Visible =true;
            butStart.Visible = true;
            listBox2.Visible = false;
            listBox3.Visible = false;
            butSave.Visible = false;
            butReset.Visible = false;
            lblSredn.Visible = false;
            label1.Visible = false;
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            chart1.Series[0].Points.Clear();
            x = 0;
            Array.Clear( arraynumx, 0, x);
            Array.Clear(arraynumy, 0, x);
            LineReceived(volume);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string file_out = "result.txt";
            saveFileDialog1.FileName = file_out;
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                file_out = saveFileDialog1.FileName;
            StreamWriter sw = File.CreateText(file_out);
            for(int i = 0; i < x; i++)
            {
                sw.WriteLine(arraynumx[i] + " " + arraynumy[i]);
            }
            sw.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (String.Compare(lblVolume.Text, "fatal error") == 1)
            {
                timer1.Stop();
                Thread.Sleep(1);
                serialPort1.Close();
                Thread.Sleep(2000);
                y = 1833;
                lblVolume.Text = "1833";
                serialPort1.Open();
                timer1.Start();
            }
            else
            {
                y = int.Parse(lblVolume.Text);
                chart1.Series[0].Points.AddXY(x, (y/10));
                Array.Resize(ref arraynumx, x);
                Array.Resize(ref arraynumy, x);
                arraynumx[x - 1] = x;
                arraynumy[x - 1] = y;
                listBox2.Items.Add(y);
                listBox3.Items.Add(x + " - " + y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] enableComPorts = SerialPort.GetPortNames();
            foreach(string port in enableComPorts)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(firstIndex == -1)
            {
                firstIndex = listBox2.SelectedIndex;
            }
            else
            {
                secondIndex = listBox2.SelectedIndex;
                sum = 0;
                if (firstIndex > secondIndex)
                {
                    for (int i = secondIndex; i <= firstIndex; i++)
                    {
                        sum += arraynumy[i];
                    }
                    sredn = sum / (firstIndex - secondIndex + 1);
                }
                else if (firstIndex < secondIndex)
                {
                    for (int i = firstIndex; i <= secondIndex; i++)
                    {
                        sum += arraynumy[i];
                    }
                    sredn = sum / (secondIndex - firstIndex + 1);
                }
                else
                {
                    sum = arraynumy[secondIndex];
                    sredn = arraynumy[secondIndex];
                }
                firstIndex = -1;
                secondIndex = -1;
                lblSredn.Text = "" + sredn;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { 
            if(e.CloseReason == CloseReason.UserClosing)
            {
                serialPort1.Close();
            }
        }
    }
}