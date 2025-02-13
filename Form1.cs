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

namespace MyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            btn_Connect.Enabled = true;
            label_State.Text = "Coose port to connect.";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
        }


        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if(btn_Connect.Text == "Connect") {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = int.Parse(comboBox2.Text);

                    if (serialPort1.IsOpen)
                    {
                        label_State.Text = serialPort1.PortName + " port isent openned.";
                        btn_Connect.Text = "Disconnect";
                    }
                    else
                    {
                        serialPort1.Open();
                        if (serialPort1.IsOpen)
                        {
                            label_State.Text = serialPort1.PortName + " connect success.";
                            btn_Connect.Text = "Disconnect";
                        }
                        else
                        {
                            label_State.Text = serialPort1.PortName + " Connect unsuccess.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }              
            }

            else {              
                serialPort1.Close();
                if (serialPort1.IsOpen)
                {
                    label_State.Text = serialPort1.PortName + " disconnect unsuccess.";
                }
                else
                {
                    label_State.Text = "Coose port to connect.";
                    btn_Connect.Text = "Connect";
                }
            }
        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!btn_Connect.Enabled)
            {
                Variable.RxString = serialPort1.ReadExisting();
                Variable.RxString = Variable.RxString.Replace("\u0006", "[ACK]\n");
                Invoke(new EventHandler(display_info));
            }
            else { }
        }

        private void display_info(object s, EventArgs e) {
            richTextBox1.AppendText(Variable.RxString);
        }

        private void btn_command_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(command_box.Text + '\r' + '\n');
            }
            else { }
        }
    }
}
