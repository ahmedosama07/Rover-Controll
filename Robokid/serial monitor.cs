using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using DarrenLee.Media;
using AForge.Video;
using ArduinoUploader;
using ArduinoUploader.BootloaderProgrammers;
using ArduinoUploader.Hardware;
using ArduinoUploader.Config;

namespace Robokid
{
    public partial class serial_monitor : Form
    {
        SerialPort p;
        bool c, m;
        string message, forwardProtocol, backwardProtocol, rightProtocol, leftProtocol;
        DateTime dateTime;
        int count = 0, forwardSpeed, backwardSpeed, rightSpeed, leftSpeed;
        public serial_monitor(SerialPort port, bool isConnected, bool isManual, int[] speed, string[] protocols)
        {
            forwardSpeed = speed[0];
            backwardSpeed = speed[1];
            rightSpeed = speed[2];
            leftSpeed = speed[3];
            forwardProtocol = protocols[0];
            backwardProtocol = protocols[1];
            rightProtocol = protocols[2];
            leftProtocol = protocols[3];
            InitializeComponent();
            p = port;
            c = isConnected;
            m = isManual;
        }

        OpenFileDialog browse = new OpenFileDialog();

        private void button3_Click(object sender, EventArgs e)
        {
            browse.Filter = "INO|*.ino|HEX|*.hex|All Arduino Files|*.ino;*.hex;";

            if(browse.ShowDialog() == DialogResult.OK)
            {
                string path = browse.SafeFileName;
                string name = browse.FileName;

                label3.Text = path;
                label4.Text = name;
                label6.Text = p.ToString();
                var uploader = new ArduinoSketchUploader(
                    new ArduinoSketchUploaderOptions()
                         {
                            FileName = "@"+path,
                            PortName = p.ToString(),
                            ArduinoModel = ArduinoModel.UnoR3
                          });

                uploader.UploadSketch();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void serial_monitor_Load(object sender, EventArgs e)
        {
            //message = p.ReadLine();
            this.Invoke(new EventHandler(displayData));


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (c && m)
            {

                if (keyData == Keys.Up)
                {
                    if (forwardSpeed < 255)
                    {
                        forwardSpeed++;
                    }
                    forwardProtocol = "#MOVEForward" + forwardSpeed.ToString() + "\n";
                    p.Write(forwardProtocol);

                    return true;
                }

                if (keyData == Keys.Down)
                {
                    if (backwardSpeed < 255)
                    {
                        backwardSpeed++;
                    }
                    backwardProtocol = "#MOVEBackward" + backwardSpeed.ToString() + "\n";
                    p.Write(backwardProtocol);

                    return true;
                }

                if (keyData == Keys.Right)
                {
                    if (rightSpeed < 255)
                    {
                        rightSpeed++;
                    }
                    rightProtocol = "#MOVERight" + rightSpeed.ToString() + "\n";
                    p.Write(rightProtocol);

                    return true;
                }

                if (keyData == Keys.Left)
                {
                    if (leftSpeed < 255)
                    {
                        leftSpeed++;
                    }
                    leftProtocol = "#MOVELeft" + leftSpeed.ToString() + "\n";
                    p.Write(leftProtocol);

                    return true;
                }

            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void displayData(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            string time = "(" + dateTime.Day + @"\" + dateTime.Month + @"\" + dateTime.Year + "\t" + dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second + ":" + ")";
            textBox1.AppendText(time + "\t\t\t\t" + message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Serial Output " + count.ToString();
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Saved");
            count++;
        }
    }
}
