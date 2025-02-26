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
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Threading;
using System.IO;
using System.Linq;

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
            UpdateRate_Box.SelectedIndex = 0;
            Variable.CmdStatus = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
        }


        /*********************************************************************************************************************
                                                            button
        **********************************************************************************************************************/
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "Connect") {
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
        private void btn_MS_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { "@MS," + Addr_Box.Text + "," + Sequence_Box.Text + "," + Point_Box.Text, Time_Box.Text });
            listView1.Items.Add(item);
        }


        private void btn_TS_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { "@TS," + Addr_Box.Text + "," + Sequence_Box.Text + "," + Point_Box.Text, Time_Box.Text });
            listView1.Items.Add(item);
        }

        private void btn_CmdStart_Click(object sender, EventArgs e)
        {
            Variable.CmdTimeCount = 0;           
            Variable.CmdIndex = 0;          
            timer_command.Start();           

            btn_CmdStart.Enabled = false;
            btn_CmdStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_MS.Enabled = false;
            btn_MS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_TS.Enabled = false;
            btn_TS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_ClnList.Enabled = false;
            btn_ClnList.BackColor = System.Drawing.SystemColors.ActiveBorder;      
        }

        private void btn_CmdStop_Click(object sender, EventArgs e)
        {
            StopCmdList();
        }

        private void btn_ClnList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btn_cap_Click(object sender, EventArgs e)
        {
            if (btn_cap.Text == "Capture")
            {
                if (FileName_Box.Text == "")
                {
                    MessageBox.Show("請輸入檔名!");
                    return;
                }
                else
                {
                    btn_cap.Text = "Stop";
                    UpdateRate_Box.Enabled = false;
                    Variable.CsvTimeCount = 0;
                    Variable.FileName = FileName_Box.Text;
                    string strResult = "Computer Time,Time,Diluted Gases,Diluent MFC (Control),Diluent MFC (Monitor),Source MFC (Control),Source MFC (Monitor),Total Flow(Control),Total Flow(Monitor),Source\n";      
                    using (StreamWriter strwrite = new StreamWriter("D:\\" + Variable.FileName + ".csv", false, Encoding.Default))
                    {
                        strwrite.Write(strResult);
                    }
                    timer_getStatus.Start();
                }               
            }
            else
            {
                btn_cap.Text = "Capture";
                UpdateRate_Box.Enabled = true;
                timer_getStatus.Stop();
            }
        }

        private void btn_CheckNow_Click(object sender, EventArgs e)
        {
            serialPort1_DataSend("@GS,001,D", "get status");
            if (Variable.CmdStatus != 1)
            {
                return;
            }
            string dilution = Variable.RxString;
            dilution = dilution.Replace("\r", "");
            string[] dilution_list = dilution.Split(',');
            if (dilution_list.Length != 11)
            {
                Array.Resize(ref dilution_list, 11);
                for (int i = dilution_list.Length - 1; i < 11; i++)
                {
                    dilution_list[i] = "Miss";
                }
            }
            /******************************************************/
            serialPort1_DataSend("@GS,001,G", "get status");
            if (Variable.CmdStatus != 1)
            {
                return;
            }
            string gas = Variable.RxString;
            gas = gas.Replace("\r", "");
            string[] gas_list = gas.Split(',');

            /*******************************************************/
            string strResult = string.Empty;
            gas_list[0] = (float.Parse(gas_list[0]) / 1000).ToString();
            if (gas_list.Length == 3)
            {
                label_Status1.Text = "Nothing";
                label_Status2.Text = "0.0";
                label_Measure6.Text = gas_list[0];
            }
            else if (gas_list.Length < 3)
            {
                label_Status1.Text = "Miss";
                label_Status2.Text = "Miss";
                label_Measure6.Text = "Miss";
            }
            else
            {
                label_Status1.Text = gas_list[2];
                label_Status2.Text = (float.Parse(gas_list[3]) / 1000).ToString();
                label_Measure6.Text = gas_list[0];
            }
            label_Measure1.Text = dilution_list[0] != null ? dilution_list[0] : "Miss";
            label_Measure2.Text = dilution_list[1] != null ? dilution_list[1] : "Miss";
            label_Measure3.Text = dilution_list[4] != null ? dilution_list[4] : "Miss";
            label_Measure4.Text = dilution_list[5] != null ? dilution_list[5] : "Miss";
            label_Measure5.Text = dilution_list[4] != null ? (float.Parse(dilution_list[0]) + float.Parse(dilution_list[4]) / 1000).ToString() : "Miss";

            LabelFlash();
        }

        private void btn_Purge_Click(object sender, EventArgs e)
        {
            serialPort1_DataSend("@P,001", "set point or stop");
            if (Variable.CmdStatus != 1)
            {
                return;
            }           
        }

        bool purgelock = true;
        private void btn_PurgeLock_Click(object sender, EventArgs e)
        {
            if (purgelock == true)
            {
                purgelock = false;
                btn_PurgeLock.BackgroundImage = Properties.Resources.unlock;
                btn_Purge.Enabled = true;
                btn_Purge.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
            else
            {
                purgelock = true;
                btn_PurgeLock.BackgroundImage = Properties.Resources._lock;
                btn_Purge.Enabled = false;
                btn_Purge.BackColor = SystemColors.ActiveBorder;
            }
        }

        /*********************************************************************************************************************
                                   receive & write
        **********************************************************************************************************************/
        private ManualResetEvent ackReceived = new ManualResetEvent(false);
        private ManualResetEvent EndLineReceived = new ManualResetEvent(false);
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Console.WriteLine("DataReceived triggered!");
            if (btn_Connect.Text == "Disconnect")
            {
                
                Variable.RxString += serialPort1.ReadExisting();
                Console.WriteLine(Variable.RxString);

                Variable.RxInfo = Variable.RxString.Replace("\u0006", "[ACK]\n");
                Variable.RxInfo = Variable.RxInfo.Replace("\u000D", "[CR]\n");

                if (Variable.RxString == "\u0006")
                {
                    ackReceived.Set();
                }
                if (Variable.StatusMode == 0 || Variable.StatusMode == 1)
                {
                    if (Variable.RxString.Count(c => c == '\r') == 2)
                    {
                        EndLineReceived.Set();
                    }
                }
                else if(Variable.StatusMode == 2)
                {
                    if (Variable.RxString.Count(c => c == '\r') == 3)
                    {
                        EndLineReceived.Set();
                    }
                }
            }
            else { }
        }

        
        private void serialPort1_DataSend(string command, string fun)
        {
            Variable.CmdStatus = 0;
            ackReceived.Reset();
            EndLineReceived.Reset();
            int send_count = 0;

            while (send_count < 5)
            {
                if (serialPort1.IsOpen)
                {
                    Console.WriteLine(command);
                    Variable.RxString = serialPort1.ReadExisting();//清空buffer
                    Variable.RxString = "";
                    serialPort1.WriteLine(command + '\r' + '\n');
                    Info_Box.AppendText(command + '\n');
                }
                else//結束流程
                {
                    Variable.CmdIndex = 0;
                    Variable.CmdTimeCount = 0;

                    btn_CmdStart.Enabled = true;
                    btn_CmdStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    btn_MS.Enabled = true;
                    btn_MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    btn_TS.Enabled = true;
                    btn_TS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    btn_ClnList.Enabled = true;
                    btn_ClnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    btn_cap.Text = "Capture";
                    UpdateRate_Box.Enabled = true;
                    timer_command.Stop();
                    timer_getStatus.Stop();
                    MessageBox.Show("Sabio 4010未連線");
                    return;
                }

                if(fun == "set point or stop")
                {
                    if (ackReceived.WaitOne(5000))
                    {
                        Variable.CmdStatus = 1;
                        display_info();
                        break;  // 收到 ACK，跳出迴圈
                    }
                }
                else if(fun == "get status")
                {
                    if (EndLineReceived.WaitOne(1000))
                    {
                        Variable.CmdStatus = 1;
                        display_info();
                        break;  // 收到 \r，跳出迴圈
                    }
                }
                send_count++;
            }

            if (send_count == 5)
            {
                Variable.CmdStatus = -1; // 4010沒有回應
                timer_command.Stop();
                timer_getStatus.Stop();
                MessageBox.Show("Sabio 4010沒有回應");
            }
        }


        /*********************************************************************************************************************
                                         clock
        **********************************************************************************************************************/
        private void timer_command_Tick(object sender, EventArgs e)
        {
            timer_command.Interval = 1000;
            if(Variable.CmdTimeCount == 0 && Variable.CmdIndex < listView1.Items.Count)
            {
                ListViewItem item = listView1.Items[Variable.CmdIndex]; // 取得第一個項目
                string command = item.Text; // 第一列
                int time = int.Parse(item.SubItems[1].Text)*60;
                Variable.CmdTimeCount = time;

                timer_command.Stop();  
                //timer_getStatus.Stop();
                serialPort1_DataSend(command, "set point or stop");               
                if (Variable.CmdStatus != 1)
                {
                    return;
                }
                else
                {
                    timer_command.Start();
                    //timer_getStatus.Start();
                    Variable.CmdIndex++;
                }              
            }
            else if(Variable.CmdTimeCount == 0 && Variable.CmdIndex >= listView1.Items.Count)
            {
                StopCmdList();
            }
            else
            {
                Variable.CmdTimeCount--;
                listView1.Items[Variable.CmdIndex-1].SubItems[1].Text = (Variable.CmdTimeCount/60).ToString() + ":" + (Variable.CmdTimeCount % 60).ToString();
            }
        }

        private void timer_getStatus_Tick(object sender, EventArgs e)
        {
            timer_getStatus.Interval = int.Parse(UpdateRate_Box.Text)*1000;
            Variable.StatusMode = 0;
            serialPort1_DataSend("@GS,001,D", "get status");
            if (Variable.CmdStatus != 1)
            {
                timer_getStatus.Stop();
                return;
            }
            string dilution = Variable.RxString;
            dilution = dilution.Replace("\r", "");
            string[] dilution_list = dilution.Split(',');
            if(dilution_list.Length != 11)
            {
                Array.Resize(ref dilution_list, 11);
                for (int i = dilution_list.Length-1; i < 11; i++)
                {
                    dilution_list[i] = "Miss";
                }
            }
            if (dilution_list[4] == "0.0" || dilution_list[4] == "Miss")
            {
                Variable.StatusMode = 1;
            }
            else
            {
                Variable.StatusMode = 2;
            }
            /******************************************************/
            serialPort1_DataSend("@GS,001,G", "get status");
            if (Variable.CmdStatus != 1)
            {
                timer_getStatus.Stop();
                return;
            }
            string gas = Variable.RxString;
            gas = gas.Replace("\r", "");
            string[] gas_list = gas.Split(',');

            /*******************************************************/
            string strResult = string.Empty;
            gas_list[0] = (float.Parse(gas_list[0])/1000).ToString();
            if (gas_list.Length == 3)
            {
                label_Status1.Text = "Nothing";
                label_Status2.Text = "0.0";
                label_Measure6.Text = gas_list[0];
            }
            else if(gas_list.Length < 3)
            {
                label_Status1.Text = "Miss";
                label_Status2.Text = "Miss";
                label_Measure6.Text = "Miss";
            }
            else
            {
                label_Status1.Text = gas_list[2];   
                label_Status2.Text = (float.Parse(gas_list[3])/1000).ToString();
                label_Measure6.Text = gas_list[0];
            }           
            label_Measure1.Text = dilution_list[0] != null ? dilution_list[0] : "Miss" ;
            label_Measure2.Text = dilution_list[1] != null ? dilution_list[1] : "Miss";
            label_Measure3.Text = dilution_list[4] != null ? dilution_list[4] : "Miss";
            label_Measure4.Text = dilution_list[5] != null ? dilution_list[5] : "Miss";
            label_Measure5.Text = dilution_list[4] != null ? (float.Parse(dilution_list[0]) + float.Parse(dilution_list[4]) / 1000).ToString() : "Miss";

            LabelFlash();

            strResult += DateTime.Now.ToString() + ',';
            strResult += Variable.CsvTimeCount.ToString() + ',';
            strResult += label_Status2.Text + ',';
            strResult += label_Measure1.Text + ',';
            strResult += label_Measure2.Text + ',';
            strResult += label_Measure3.Text + ',';
            strResult += label_Measure4.Text + ',';
            strResult += label_Measure5.Text + ',';
            strResult += label_Measure6.Text + ',';
            strResult += label_Status1.Text + '\n';
            using (StreamWriter strwrite = new StreamWriter("D:\\" + Variable.FileName + ".csv", true, Encoding.Default))
            {
                strwrite.Write(strResult);
            }

            Variable.CsvTimeCount += float.Parse(UpdateRate_Box.Text) / 60;
        }
        /*********************************************************************************************************************
                                         other
        **********************************************************************************************************************/
        private void display_info() {
            Info_Box.AppendText(Variable.RxInfo);
        }

        //固定欄寬
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopCmdList()
        {
            Variable.CmdIndex = 0;
            Variable.CmdStatus = 0;
            Variable.CmdTimeCount = 0;
            
            serialPort1_DataSend("@S,001", "set point or stop");
            if (Variable.CmdStatus != 1)
            {
                return;
            }
            timer_command.Stop();
            btn_CmdStart.Enabled = true;
            btn_CmdStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btn_MS.Enabled = true;
            btn_MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btn_TS.Enabled = true;
            btn_TS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btn_ClnList.Enabled = true;
            btn_ClnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(command_box.Text+'\r'+'\n');            
        }       

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Info_Box_TextChanged(object sender, EventArgs e)
        {
            Info_Box.SelectionStart = this.Info_Box.TextLength;
            Info_Box.ScrollToCaret();
        }

        private void brn_InfoCln_Click(object sender, EventArgs e)
        {
            Info_Box.Clear();
        }

        private async void LabelFlash()
        {
            Update_LED.ForeColor = Color.IndianRed;
            await Task.Delay(500);
            Update_LED.ForeColor = SystemColors.ControlLight;
        }

        
    }
}
