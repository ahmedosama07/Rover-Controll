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

namespace Robokid
{
    
    public partial class Form1 : Form
    {
        bool isManual = false;
        bool isConnected = false;
        String[] ports;
        SerialPort port;
		int error;

        int rightSpeed = 0, leftSpeed = 0, forwardSpeed = 0, backwardSpeed = 0;
        string rightProtocol = "", leftProtocol = "", forwardProtocol = "", backwardProtocol = "";
        int[] speed = new int[4];
        string[] protocols = new string[4];
        int count = 0;
        Camera mycamera = new Camera();

        public Form1()
        {
            InitializeComponent();

            //KeyDown += new KeyEventHandler(Form1_KeyDown);

            disableControls();
            getAvailableComPorts();

            GetInfo();
            mycamera.OnFrameArrived += MyCamera_OnFrameArrived;

            button1.Enabled = true;

            //.BackgroundImageLayout = ImageLayout.Stretch;

            motion_pan.BackColor = Color.Transparent;
            arm_pan.BackColor = Color.Transparent;
            serial_connection.BackColor = Color.Transparent;
            lcd_control.BackColor = Color.Transparent;
            controlpan.BackColor = Color.Transparent;
			try
			{
				foreach (string port in ports)
				{
					comboBox1.Items.Add(port);
					Console.WriteLine(port);
					if (ports[0] != null)
					{
						comboBox1.SelectedItem = ports[0];
						//comboBox1.SelectedItem = null;
					}
				}
			}
			catch
			{
				error = 2;
				MessageBox.Show("Check Camera Cable!\nerror code: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            

            

        }

        private void GetInfo()
        {
            var cameraDevices = mycamera.GetCameraSources();
            var cameraResolution = mycamera.GetSupportedResolutions();

            foreach (var d in cameraDevices)
                cmbCameraDevices.Items.Add(d);

            foreach (var r in cameraResolution)
                cmbCameraResolution.Items.Add(r);

            //cmbCameraResolution.SelectedIndex = 0;
            //cmbCameraDevices.SelectedIndex = 0;
        }

        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox2.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
				connectToArduino();
			}
            else
            {
                disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
			try
			{
				string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
				port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
				port.Open();
				port.Write("#STAR\n");
				button1.Text = "Disconnect";
				enableControls();
				isConnected = true;
			}
			catch
			{
				error = 1;
				MessageBox.Show("There is a problem with the selected Port!!!\nCheck your port and your device connection.\n\nerror code: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (isConnected && error == 1)
			{
				isConnected = false;
				error = 0;
			}
		}

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#TEXT" + textBox1.Text + "#\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#MOVELeft\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#MOVEForward\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#MOVERight\n");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#MOVEBackward\n");
            }
        }

        private void enableControls()
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            open.Enabled = true;
            close.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            textBox1.Enabled = true;
            serial_connection.Enabled = true;
            lcd_control.Enabled = true;
            motion_pan.Enabled = true;
            arm_pan.Enabled = true;
            controlpan.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            button12.Enabled = true;
        }

        private void disableControls()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            open.Enabled = false;
            close.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            textBox1.Enabled = false;
            //serial_connection.Enabled = false;
            lcd_control.Enabled = false;
            motion_pan.Enabled = false;
            arm_pan.Enabled = false;
            controlpan.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            button12.Enabled = false;
        }

        private void resetDefaults()
        {
            textBox1.Text = "";
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCameraDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            mycamera.ChangeCamera(cmbCameraDevices.SelectedIndex);
        }

        private void cmbCameraResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            mycamera.Start(cmbCameraResolution.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mycamera.Stop();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Image" + count.ToString();
            mycamera.Capture(filename);
            count++;
        }

        private void motion_pan_Enter(object sender, EventArgs e)
        {
            
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#GRBR" + "OPEN" + "#\n");
                open.Enabled = false;
                close.Enabled = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#GRBR" + "CLOSE" + "#\n");
                close.Enabled = false;
                open.Enabled = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            Console.WriteLine(port.ReadByte());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            speed[0] = forwardSpeed;
            speed[1] = backwardSpeed;
            speed[2] = rightSpeed;
            speed[3] = leftSpeed;
            protocols[0] = forwardProtocol;
            protocols[1] = backwardProtocol;
            protocols[2] = rightProtocol;
            protocols[3] = leftProtocol;
            serial_monitor serial = new serial_monitor(port, isConnected, isManual, speed, protocols);
            serial.ShowDialog();
        }

        /*private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                if (e.KeyCode == Keys.Up)
                {
                    port.Write("#MOVE" + "Forward" + "#\n");
                    button4.Focus();
                    button4.PerformClick();
                    MessageBox.Show("up");
                }

                if (e.KeyCode == Keys.Down)
                {
                    port.Write("#MOVE" + "Backward" + "#\n");
                    button6.Focus();
                    button6.PerformClick();
                }

                if (e.KeyCode == Keys.Right)
                {
                    port.Write("#MOVERight\n");
                    button5.Focus();
                    button5.PerformClick();
                }

                if (e.KeyCode == Keys.Left)
                {
                    port.Write("#MOVELeft\n");
                    button3.Focus();
                    button3.PerformClick();
                }

            }
        }*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isConnected && isManual)
            {

                if (keyData == Keys.Up)
                {
                    if (forwardSpeed < 255)
                    {
                        forwardSpeed++;
                    }
                    forwardProtocol = "#MOVEForward" + forwardSpeed.ToString() + "\n";
                    port.Write(forwardProtocol);
                    button4.Focus();
                    button4.BackColor = Color.Green;
                    return true;
                }
                

                if (keyData == Keys.Down)
                {
                    if (backwardSpeed < 255)
                    {
                        backwardSpeed++;
                    }
                    backwardProtocol = "#MOVEBackward" + backwardSpeed.ToString() + "\n";
                    port.Write(backwardProtocol);
                    button6.Focus();
                    button6.BackColor = Color.Green;
                    return true;
                }

                if (keyData == Keys.Right)
                {
                    if (rightSpeed < 255)
                    {
                        rightSpeed++;
                    }
                    rightProtocol = "#MOVERight" + rightSpeed.ToString() + "\n";
                    port.Write(rightProtocol);
                    button5.Focus();
                    button5.BackColor = Color.Green;
                    return true;
                }

                if (keyData == Keys.Left)
                {
                    if (leftSpeed < 255)
                    {
                        leftSpeed++;
                    }
                    leftProtocol = "#MOVELeft" + leftSpeed.ToString() + "\n";
                    port.Write(leftProtocol);
                    button3.Focus();
                    button3.BackColor = Color.Green;
                    return true;
                }
            }

            //textBox1.AppendText(forwardSpeed + " , " + backwardSpeed + " , " + rightSpeed + " , " + leftSpeed);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                isManual = false;
                port.Write("#AUTO\n");
                button8.BackColor = Color.Green;
                button7.BackColor = Color.Red;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                isManual = true;
                port.Write("#MANU\n");
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Red;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#ARM" + "STRTSH" + "#\n");
                button9.Enabled = false;
                button10.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#ARM" + "SHRNK" + "#\n");
                button10.Enabled = false;
                button9.Enabled = true;
            }
        }
        

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
