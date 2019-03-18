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

            button1.Enabled = true;

            //.BackgroundImageLayout = ImageLayout.Stretch;
            serial_connection.BackColor = Color.Transparent;
            controlpan.BackColor = Color.Transparent;

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }

            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
                enableControls();
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
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            enableControls();
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
            open.Enabled = true;
            close.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            serial_connection.Enabled = true;
            controlpan.Enabled = true;
            button12.Enabled = true;
        }

        private void disableControls()
        {
            open.Enabled = false;
            close.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            controlpan.Enabled = false;
        }

        private void resetDefaults()
        {
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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
}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            port.Write("G");
            port.Write("1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            port.Write("G");
            port.Write("2");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            port.Write("G");
            port.Write("3");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            port.Write("G");
            port.Write("4");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            port.Write("G");
            port.Write("5");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            port.Write("G");
            port.Write("6");
        }

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
                    port.Write("u");
                    return true;
                }
                

                if (keyData == Keys.Down)
                {
                    if (backwardSpeed < 255)
                    {
                        backwardSpeed++;
                    }
                    backwardProtocol = "#MOVEBackward" + backwardSpeed.ToString() + "\n";
                    port.Write("b");
                    return true;
                }

                if (keyData == Keys.Right)
                {
                    if (rightSpeed < 255)
                    {
                        rightSpeed++;
                    }
                    rightProtocol = "#MOVERight" + rightSpeed.ToString() + "\n";
                    port.Write("r");
                    return true;
                }

                if (keyData == Keys.Left)
                {
                    if (leftSpeed < 255)
                    {
                        leftSpeed++;
                    }
                    leftProtocol = "#MOVELeft" + leftSpeed.ToString() + "\n";
                    port.Write("l");
                    return true;
                }
            }
            port.Write("R");
            //textBox1.AppendText(forwardSpeed + " , " + backwardSpeed + " , " + rightSpeed + " , " + leftSpeed);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                isManual = false;
                port.Write("A");
                button8.BackColor = Color.Green;
                button7.BackColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                isManual = true;
                port.Write("M");
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Red;
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
