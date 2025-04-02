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
            Variable.O3Flag = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("@S,001" + '\r' + '\n');
            }
            serialPort1.Close();
            serialPort1.Dispose();
        }


        /*********************************************************************************************************************
                                                            button
        **********************************************************************************************************************/
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "Connect")
            {
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

            else
            {
                if (serialPort1.IsOpen)
                {
                    StopCmdList();
                }
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
            ListViewItem item = new ListViewItem(new string[] { "@MS," + Addr_Box.Text + "," + Sequence_Box.Text + "," + Point_Box.Text, Time_Box.Text + ":" + "00" });
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
            lock_btn();
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
                    string strResult = "Computer Time,Time,Source,Diluted Gases,Diluent MFC (Control),Diluent MFC (Monitor),Source MFC (Control),Source MFC (Monitor)," +
                        "Total Flow(Control),Total Flow(Monitor),1st Gases,1st Diluted Gases,2st Gases,2st Diluted Gases,3st Gases,3st Diluted Gases\n";
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
            get_Status();
        }

        private void btn_Purge_Click(object sender, EventArgs e)
        {
            Variable.CommandMode = 3;
            serialPort1_DataSend("@P,001");
            if (Variable.CmdStatus != 1)
            {
                return;
            }
            get_Status();
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
        private ManualResetEvent ResponseReceived = new ManualResetEvent(false);
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Console.WriteLine("DataReceived triggered!");
            if (btn_Connect.Text == "Disconnect")
            {

                Variable.RxString += serialPort1.ReadExisting();
                Console.WriteLine(Variable.RxString);

                Variable.RxInfo = Variable.RxString.Replace("\u0006", "[ACK]\n");
                Variable.RxInfo = Variable.RxInfo.Replace("\u000D", "[CR]\n");

                if (Variable.CommandMode == 0 || Variable.CommandMode == 1)
                {
                    if (Variable.RxString.Count(c => c == '\r') == 2)
                    {
                        ResponseReceived.Set();
                    }
                }
                else if (Variable.CommandMode == 2)
                {
                    if (Variable.O3Flag)
                    {
                        if (Variable.RxString.Count(c => c == '\r') == 6)
                        {
                            ResponseReceived.Set();
                        }
                    }
                    else
                    {
                        if (Variable.RxString.Count(c => c == '\r') == 3)
                        {
                            ResponseReceived.Set();
                        }
                    }

                }

                else if (Variable.CommandMode == 3)
                {
                    if (Variable.RxString == "\u0006")
                    {
                        ResponseReceived.Set();
                    }
                }
            }
            else { }
        }


        private void serialPort1_DataSend(string command)
        {
            Variable.CmdStatus = 0;
            ResponseReceived.Reset();
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

                    unlock_btn();
                    btn_cap.Text = "Capture";
                    UpdateRate_Box.Enabled = true;
                    timer_command.Stop();
                    timer_getStatus.Stop();
                    MessageBox.Show("Sabio 4010未連線");
                    return;
                }

                if (Variable.CommandMode == 3)//ms/ts/stop/purge
                {
                    if (ResponseReceived.WaitOne(5000))//要等比較久
                    {
                        Variable.CmdStatus = 1;
                        display_info();
                        return;  // 收到 ACK，結束函式
                    }
                }
                else if (Variable.CommandMode == 0 || Variable.CommandMode == 1 || Variable.CommandMode == 2)//GetStatus
                {
                    if (ResponseReceived.WaitOne(1000))//讀資料比較快
                    {
                        Variable.CmdStatus = 1;
                        display_info();
                        return;  // 收到 \r，結束函式
                    }
                }
                send_count++;
            }

            Variable.CmdStatus = -1; // 4010沒有回應
            timer_command.Stop();
            timer_getStatus.Stop();
            MessageBox.Show("Sabio 4010沒有回應");
        }


        /*********************************************************************************************************************
                                         clock
        **********************************************************************************************************************/
        private void timer_command_Tick(object sender, EventArgs e)
        {
            timer_command.Interval = 1000;
            if (Variable.CmdTimeCount == 0 && Variable.CmdIndex < listView1.Items.Count)
            {
                ListViewItem item = listView1.Items[Variable.CmdIndex]; // 取得第一個項目
                string command = item.Text; // 第一列
                string[] timelist = item.SubItems[1].Text.Split(':');
                int time = int.Parse(timelist[0]) * 60 + int.Parse(timelist[1]);
                Variable.CmdTimeCount = time;

                if (command.Contains("+O3"))
                {
                    Variable.O3Flag = true;
                }
                else
                {
                    Variable.O3Flag = false;
                }

                timer_command.Stop();
                //timer_getStatus.Stop();
                Variable.CommandMode = 3;
                serialPort1_DataSend(command);
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
            else if (Variable.CmdTimeCount == 0 && Variable.CmdIndex >= listView1.Items.Count)
            {
                StopCmdList();
            }
            else
            {
                Variable.CmdTimeCount--;
                listView1.Items[Variable.CmdIndex - 1].SubItems[1].Text = (Variable.CmdTimeCount / 60).ToString() + ":" + (Variable.CmdTimeCount % 60).ToString();
            }
        }

        private void timer_getStatus_Tick(object sender, EventArgs e)
        {
            timer_getStatus.Interval = int.Parse(UpdateRate_Box.Text) * 1000;

            get_Status();
            string strResult = string.Empty;
            strResult += DateTime.Now.ToString() + ',';
            strResult += Variable.CsvTimeCount.ToString() + ',';
            strResult += label_Status1.Text + ',';
            strResult += label_Status2.Text + ',';
            strResult += label_Measure1.Text + ',';
            strResult += label_Measure2.Text + ',';
            strResult += label_Measure3.Text + ',';
            strResult += label_Measure4.Text + ',';
            strResult += label_Measure5.Text + ',';
            strResult += label_Measure6.Text + ',';
            strResult += label_Status3.Text + ',';
            strResult += label_Status4.Text + ',';
            strResult += label_Status5.Text + ',';
            strResult += label_Status6.Text + ',';
            strResult += label_Status7.Text + ',';
            strResult += label_Status8.Text + '\n';
            using (StreamWriter strwrite = new StreamWriter("D:\\" + Variable.FileName + ".csv", true, Encoding.Default))
            {
                strwrite.Write(strResult);
            }

            Variable.CsvTimeCount += float.Parse(UpdateRate_Box.Text) / 60;
        }
        /*********************************************************************************************************************
                                         other
        **********************************************************************************************************************/
        private void display_info()
        {
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
            Variable.O3Flag = false;

            Variable.CommandMode = 3;
            serialPort1_DataSend("@S,001");
            if (Variable.CmdStatus != 1)
            {
                return;
            }
            timer_command.Stop();
            unlock_btn();
        }

        private void get_Status()
        {
            Variable.CommandMode = 0;
            serialPort1_DataSend("@GS,001,D");
            if (Variable.CmdStatus != 1)
            {
                timer_getStatus.Stop();
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
            if (dilution_list[4] == "0.0" || dilution_list[4] == "Miss")
            {
                Variable.CommandMode = 1;
            }
            else
            {
                Variable.CommandMode = 2;
            }
            /******************************************************/
            serialPort1_DataSend("@GS,001,G");
            if (Variable.CmdStatus != 1)
            {
                timer_getStatus.Stop();
                return;
            }
            string gas = Variable.RxString;
            gas = gas.Replace("\r", "");
            string[] gas_list = gas.Split(',');

            /*******************************************************/
            gas_list[0] = (float.Parse(gas_list[0]) / 1000).ToString();
            if (gas_list.Length == 3)
            {
                label_Status1.Text = "Nothing";
                label_Status2.Text = "0.0";
                label_Status3.Text = "--";
                label_Status4.Text = "0.0";
                label_Status5.Text = "--";
                label_Status6.Text = "0.0";
                label_Status7.Text = "--";
                label_Status8.Text = "0.0";
                label_Measure6.Text = gas_list[0];
            }
            else if (gas_list.Length == 5)
            {
                label_Status1.Text = gas_list[2];
                label_Status2.Text = (float.Parse(gas_list[3]) / 1000).ToString();
                label_Status3.Text = "Nothing";
                label_Status4.Text = "0.0";
                label_Status5.Text = "--";
                label_Status6.Text = "0.0";
                label_Status7.Text = "--";
                label_Status8.Text = "0.0";
                label_Measure6.Text = gas_list[0];
            }
            else if (gas_list.Length == 11)
            {
                label_Status1.Text = gas_list[2];
                label_Status2.Text = (float.Parse(gas_list[3]) / 1000).ToString();
                label_Status3.Text = gas_list[4];
                label_Status4.Text = (float.Parse(gas_list[5]) / 1000).ToString();
                label_Status5.Text = gas_list[6];
                label_Status6.Text = (float.Parse(gas_list[7]) / 1000).ToString();
                label_Status7.Text = gas_list[8];
                label_Status8.Text = (float.Parse(gas_list[9]) / 1000).ToString();
                label_Measure6.Text = gas_list[0];
            }
            else
            {
                label_Status1.Text = "Miss";
                label_Status2.Text = "Miss";
                label_Status3.Text = "Miss";
                label_Status4.Text = "Miss";
                label_Status5.Text = "Miss";
                label_Status6.Text = "Miss";
                label_Measure6.Text = "Miss";
            }

            if(dilution_list.Length == 11)
            {
                label_Measure1.Text = dilution_list[0];
                label_Measure2.Text = dilution_list[1];
                label_Measure3.Text = dilution_list[4];
                label_Measure4.Text = dilution_list[5];
                label_Measure5.Text = (float.Parse(dilution_list[0]) + float.Parse(dilution_list[4]) / 1000).ToString();
            }
            else
            {
                label_Measure1.Text = "Miss";
                label_Measure2.Text = "Miss";
                label_Measure3.Text = "Miss";
                label_Measure4.Text = "Miss";
                label_Measure5.Text = "Miss";
            }

            LEDFlash();
        }

        private void lock_btn()
        {
            btn_CmdStart.Enabled = false;
            btn_CmdStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_MS.Enabled = false;
            btn_MS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_TS.Enabled = false;
            btn_TS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_ClnList.Enabled = false;
            btn_ClnList.BackColor = System.Drawing.SystemColors.ActiveBorder;
        }

        private void unlock_btn()
        {
            btn_CmdStart.Enabled = true;
            btn_CmdStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btn_MS.Enabled = true;
            btn_MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btn_TS.Enabled = true;
            btn_TS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btn_ClnList.Enabled = true;
            btn_ClnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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

        private async void LEDFlash()
        {
            Update_LED.ForeColor = Color.IndianRed;
            await Task.Delay(500);
            Update_LED.ForeColor = SystemColors.ControlLight;
        }
    }
}
