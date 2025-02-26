using System.Drawing;
using System.Windows.Forms;

namespace MyTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label_State = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_CmdStart = new System.Windows.Forms.Button();
            this.Info_Box = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateRate_Box = new System.Windows.Forms.ComboBox();
            this.btn_CheckNow = new System.Windows.Forms.Button();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.Update_LED = new System.Windows.Forms.Label();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Status1 = new System.Windows.Forms.Label();
            this.label_Status2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Measure5 = new System.Windows.Forms.Label();
            this.label_Measure6 = new System.Windows.Forms.Label();
            this.label_Measure4 = new System.Windows.Forms.Label();
            this.label_Measure2 = new System.Windows.Forms.Label();
            this.label_Measure3 = new System.Windows.Forms.Label();
            this.label_Measure1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_Purge = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Addr_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sequence_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Point_Box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Time_Box = new System.Windows.Forms.TextBox();
            this.btn_MS = new System.Windows.Forms.Button();
            this.btn_TS = new System.Windows.Forms.Button();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.FileName_Box = new System.Windows.Forms.TextBox();
            this.btn_cap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.brn_InfoCln = new System.Windows.Forms.Button();
            this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_CmdStop = new System.Windows.Forms.Button();
            this.btn_ClnList = new System.Windows.Forms.Button();
            this.command_box = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.timer_command = new System.Windows.Forms.Timer(this.components);
            this.timer_getStatus = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.btn_PurgeLock = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.flowLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Connect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Connect.Location = new System.Drawing.Point(452, 0);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(132, 31);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_State.Location = new System.Drawing.Point(614, 10);
            this.label_State.Margin = new System.Windows.Forms.Padding(10);
            this.label_State.Name = "label_State";
            this.label_State.Padding = new System.Windows.Forms.Padding(2, 6, 25, 6);
            this.label_State.Size = new System.Drawing.Size(267, 31);
            this.label_State.TabIndex = 3;
            this.label_State.Text = "Choose port to connect.";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Consolas", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400"});
            this.comboBox2.Location = new System.Drawing.Point(101, 0);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 31);
            this.comboBox2.TabIndex = 4;
            // 
            // btn_CmdStart
            // 
            this.btn_CmdStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CmdStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_CmdStart.Location = new System.Drawing.Point(0, 270);
            this.btn_CmdStart.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CmdStart.Name = "btn_CmdStart";
            this.btn_CmdStart.Size = new System.Drawing.Size(180, 32);
            this.btn_CmdStart.TabIndex = 6;
            this.btn_CmdStart.Text = "Start";
            this.btn_CmdStart.UseVisualStyleBackColor = false;
            this.btn_CmdStart.Click += new System.EventHandler(this.btn_CmdStart_Click);
            // 
            // Info_Box
            // 
            this.Info_Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Info_Box.Location = new System.Drawing.Point(0, 314);
            this.Info_Box.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Info_Box.Name = "Info_Box";
            this.Info_Box.Size = new System.Drawing.Size(202, 140);
            this.Info_Box.TabIndex = 8;
            this.Info_Box.Text = "";
            this.Info_Box.TextChanged += new System.EventHandler(this.Info_Box_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(26, 4, 25, 5);
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(26, 4, 25, 5);
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.84974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.15026F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_State, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 609);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.btn_Connect);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.comboBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(203, 31);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.comboBox2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(223, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(204, 31);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel3.Controls.Add(this.btn_PurgeLock);
            this.flowLayoutPanel3.Controls.Add(this.btn_Purge);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(614, 103);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(10, 52, 10, 10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(520, 496);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.label9);
            this.flowLayoutPanel11.Controls.Add(this.UpdateRate_Box);
            this.flowLayoutPanel11.Controls.Add(this.btn_CheckNow);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(520, 32);
            this.flowLayoutPanel11.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label9.Size = new System.Drawing.Size(160, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Updata rate(s)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateRate_Box
            // 
            this.UpdateRate_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateRate_Box.Font = new System.Drawing.Font("Consolas", 15F);
            this.UpdateRate_Box.FormattingEnabled = true;
            this.UpdateRate_Box.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "60"});
            this.UpdateRate_Box.Location = new System.Drawing.Point(160, 0);
            this.UpdateRate_Box.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateRate_Box.Name = "UpdateRate_Box";
            this.UpdateRate_Box.Size = new System.Drawing.Size(67, 31);
            this.UpdateRate_Box.TabIndex = 30;
            // 
            // btn_CheckNow
            // 
            this.btn_CheckNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CheckNow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_CheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckNow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckNow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CheckNow.Location = new System.Drawing.Point(407, 0);
            this.btn_CheckNow.Margin = new System.Windows.Forms.Padding(180, 0, 0, 0);
            this.btn_CheckNow.Name = "btn_CheckNow";
            this.btn_CheckNow.Size = new System.Drawing.Size(113, 31);
            this.btn_CheckNow.TabIndex = 21;
            this.btn_CheckNow.Text = "Check now";
            this.btn_CheckNow.UseVisualStyleBackColor = false;
            this.btn_CheckNow.Click += new System.EventHandler(this.btn_CheckNow_Click);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label13);
            this.flowLayoutPanel9.Controls.Add(this.Update_LED);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0, 15, 0, 10);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(520, 98);
            this.flowLayoutPanel9.TabIndex = 28;
            // 
            // Update_LED
            // 
            this.Update_LED.AutoSize = true;
            this.Update_LED.BackColor = System.Drawing.Color.Transparent;
            this.Update_LED.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_LED.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Update_LED.Location = new System.Drawing.Point(470, 0);
            this.Update_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Update_LED.Name = "Update_LED";
            this.Update_LED.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.Update_LED.Size = new System.Drawing.Size(33, 30);
            this.Update_LED.TabIndex = 22;
            this.Update_LED.Text = "●";
            this.Update_LED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel13.Controls.Add(this.label10);
            this.flowLayoutPanel13.Controls.Add(this.label11);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(160, 67);
            this.flowLayoutPanel13.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label10.Size = new System.Drawing.Size(80, 31);
            this.label10.TabIndex = 23;
            this.label10.Text = "Source";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label11.Size = new System.Drawing.Size(150, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "Diluted Gases";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel14.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(160, 31);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(360, 67);
            this.flowLayoutPanel14.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label_Status1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_Status2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_Status1
            // 
            this.label_Status1.AutoSize = true;
            this.label_Status1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Status1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status1.Location = new System.Drawing.Point(0, 0);
            this.label_Status1.Margin = new System.Windows.Forms.Padding(0);
            this.label_Status1.Name = "label_Status1";
            this.label_Status1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Status1.Size = new System.Drawing.Size(40, 31);
            this.label_Status1.TabIndex = 24;
            this.label_Status1.Text = "--";
            this.label_Status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Status2
            // 
            this.label_Status2.AutoSize = true;
            this.label_Status2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Status2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status2.Location = new System.Drawing.Point(0, 33);
            this.label_Status2.Margin = new System.Windows.Forms.Padding(0);
            this.label_Status2.Name = "label_Status2";
            this.label_Status2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Status2.Size = new System.Drawing.Size(40, 31);
            this.label_Status2.TabIndex = 25;
            this.label_Status2.Text = "--";
            this.label_Status2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(296, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(64, 67);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label14.Size = new System.Drawing.Size(50, 31);
            this.label14.TabIndex = 25;
            this.label14.Text = "PPB";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.label21);
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel16);
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel17);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(0, 177);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(0, 12, 0, 10);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(520, 156);
            this.flowLayoutPanel12.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0, 0, 400, 0);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label21.Size = new System.Drawing.Size(110, 31);
            this.label21.TabIndex = 27;
            this.label21.Text = "Measure :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(520, 31);
            this.flowLayoutPanel7.TabIndex = 28;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel6.Controls.Add(this.label22, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(520, 31);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(160, 0);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label22.Size = new System.Drawing.Size(90, 31);
            this.label22.TabIndex = 26;
            this.label22.Text = "Control";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label15.Size = new System.Drawing.Size(90, 31);
            this.label15.TabIndex = 25;
            this.label15.Text = "Monitor";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel16.Controls.Add(this.label17);
            this.flowLayoutPanel16.Controls.Add(this.label16);
            this.flowLayoutPanel16.Controls.Add(this.label25);
            this.flowLayoutPanel16.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(160, 92);
            this.flowLayoutPanel16.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label17.Size = new System.Drawing.Size(130, 31);
            this.label17.TabIndex = 25;
            this.label17.Text = "Diluted MFC";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label16.Size = new System.Drawing.Size(120, 31);
            this.label16.TabIndex = 23;
            this.label16.Text = "Source MFC";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(0, 62);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label25.Size = new System.Drawing.Size(120, 31);
            this.label25.TabIndex = 29;
            this.label25.Text = "Total Flow";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel17.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel17.Location = new System.Drawing.Point(160, 62);
            this.flowLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(360, 93);
            this.flowLayoutPanel17.TabIndex = 26;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label_Measure5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label_Measure6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label_Measure4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_Measure2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_Measure3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_Measure1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(296, 92);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label_Measure5
            // 
            this.label_Measure5.AutoSize = true;
            this.label_Measure5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Measure5.Location = new System.Drawing.Point(0, 60);
            this.label_Measure5.Margin = new System.Windows.Forms.Padding(0);
            this.label_Measure5.Name = "label_Measure5";
            this.label_Measure5.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Measure5.Size = new System.Drawing.Size(40, 31);
            this.label_Measure5.TabIndex = 31;
            this.label_Measure5.Text = "--";
            this.label_Measure5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Measure6
            // 
            this.label_Measure6.AutoSize = true;
            this.label_Measure6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Measure6.Location = new System.Drawing.Point(148, 60);
            this.label_Measure6.Margin = new System.Windows.Forms.Padding(0);
            this.label_Measure6.Name = "label_Measure6";
            this.label_Measure6.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Measure6.Size = new System.Drawing.Size(40, 31);
            this.label_Measure6.TabIndex = 30;
            this.label_Measure6.Text = "--";
            this.label_Measure6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Measure4
            // 
            this.label_Measure4.AutoSize = true;
            this.label_Measure4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Measure4.Location = new System.Drawing.Point(148, 30);
            this.label_Measure4.Margin = new System.Windows.Forms.Padding(0);
            this.label_Measure4.Name = "label_Measure4";
            this.label_Measure4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Measure4.Size = new System.Drawing.Size(40, 30);
            this.label_Measure4.TabIndex = 26;
            this.label_Measure4.Text = "--";
            this.label_Measure4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Measure2
            // 
            this.label_Measure2.AutoSize = true;
            this.label_Measure2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Measure2.Location = new System.Drawing.Point(148, 0);
            this.label_Measure2.Margin = new System.Windows.Forms.Padding(0);
            this.label_Measure2.Name = "label_Measure2";
            this.label_Measure2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Measure2.Size = new System.Drawing.Size(40, 30);
            this.label_Measure2.TabIndex = 29;
            this.label_Measure2.Text = "--";
            this.label_Measure2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Measure3
            // 
            this.label_Measure3.AutoSize = true;
            this.label_Measure3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Measure3.Location = new System.Drawing.Point(0, 30);
            this.label_Measure3.Margin = new System.Windows.Forms.Padding(0);
            this.label_Measure3.Name = "label_Measure3";
            this.label_Measure3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Measure3.Size = new System.Drawing.Size(40, 30);
            this.label_Measure3.TabIndex = 25;
            this.label_Measure3.Text = "--";
            this.label_Measure3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Measure1
            // 
            this.label_Measure1.AutoSize = true;
            this.label_Measure1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Measure1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Measure1.Location = new System.Drawing.Point(0, 0);
            this.label_Measure1.Margin = new System.Windows.Forms.Padding(0);
            this.label_Measure1.Name = "label_Measure1";
            this.label_Measure1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label_Measure1.Size = new System.Drawing.Size(40, 30);
            this.label_Measure1.TabIndex = 24;
            this.label_Measure1.Text = "--";
            this.label_Measure1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(296, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(64, 92);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 30);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label20.Size = new System.Drawing.Size(60, 30);
            this.label20.TabIndex = 25;
            this.label20.Text = "SCCM";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label28.Size = new System.Drawing.Size(60, 30);
            this.label28.TabIndex = 29;
            this.label28.Text = "SLPM";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(0, 60);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label29.Size = new System.Drawing.Size(60, 31);
            this.label29.TabIndex = 30;
            this.label29.Text = "SLPM";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Purge
            // 
            this.btn_Purge.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Purge.Enabled = false;
            this.btn_Purge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Purge.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Purge.Location = new System.Drawing.Point(372, 363);
            this.btn_Purge.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btn_Purge.Name = "btn_Purge";
            this.btn_Purge.Size = new System.Drawing.Size(113, 32);
            this.btn_Purge.TabIndex = 25;
            this.btn_Purge.Text = "Purge";
            this.btn_Purge.UseVisualStyleBackColor = false;
            this.btn_Purge.Click += new System.EventHandler(this.btn_Purge_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel19);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(10, 71);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(584, 528);
            this.flowLayoutPanel5.TabIndex = 12;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel10.Controls.Add(this.label7);
            this.flowLayoutPanel10.Controls.Add(this.Info_Box);
            this.flowLayoutPanel10.Controls.Add(this.brn_InfoCln);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0, 32, 10, 0);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(203, 494);
            this.flowLayoutPanel10.TabIndex = 3;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Controls.Add(this.Addr_Box);
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.Sequence_Box);
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.Point_Box);
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.Time_Box);
            this.flowLayoutPanel6.Controls.Add(this.btn_MS);
            this.flowLayoutPanel6.Controls.Add(this.btn_TS);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(202, 166);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 4, 16, 5);
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Addr_Box
            // 
            this.Addr_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Addr_Box.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addr_Box.Location = new System.Drawing.Point(101, 0);
            this.Addr_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Addr_Box.Name = "Addr_Box";
            this.Addr_Box.ReadOnly = true;
            this.Addr_Box.Size = new System.Drawing.Size(101, 31);
            this.Addr_Box.TabIndex = 13;
            this.Addr_Box.Text = "001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 4, 6, 5);
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sequence";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sequence_Box
            // 
            this.Sequence_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sequence_Box.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sequence_Box.Location = new System.Drawing.Point(101, 31);
            this.Sequence_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Sequence_Box.Name = "Sequence_Box";
            this.Sequence_Box.Size = new System.Drawing.Size(101, 31);
            this.Sequence_Box.TabIndex = 14;
            this.Sequence_Box.Text = "C4H8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 4, 36, 5);
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Point";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Point_Box
            // 
            this.Point_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Point_Box.Font = new System.Drawing.Font("Consolas", 15F);
            this.Point_Box.FormattingEnabled = true;
            this.Point_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.Point_Box.Location = new System.Drawing.Point(101, 62);
            this.Point_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Point_Box.Name = "Point_Box";
            this.Point_Box.Size = new System.Drawing.Size(101, 31);
            this.Point_Box.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 4, 16, 5);
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time(m)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time_Box
            // 
            this.Time_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time_Box.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Box.Location = new System.Drawing.Point(101, 93);
            this.Time_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Time_Box.Name = "Time_Box";
            this.Time_Box.Size = new System.Drawing.Size(101, 31);
            this.Time_Box.TabIndex = 17;
            this.Time_Box.Text = "5";
            // 
            // btn_MS
            // 
            this.btn_MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_MS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_MS.Location = new System.Drawing.Point(0, 124);
            this.btn_MS.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MS.Name = "btn_MS";
            this.btn_MS.Size = new System.Drawing.Size(101, 31);
            this.btn_MS.TabIndex = 18;
            this.btn_MS.Text = "MS";
            this.btn_MS.UseVisualStyleBackColor = false;
            this.btn_MS.Click += new System.EventHandler(this.btn_MS_Click);
            // 
            // btn_TS
            // 
            this.btn_TS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_TS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_TS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TS.Location = new System.Drawing.Point(101, 124);
            this.btn_TS.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TS.Name = "btn_TS";
            this.btn_TS.Size = new System.Drawing.Size(101, 31);
            this.btn_TS.TabIndex = 4;
            this.btn_TS.Text = "TS";
            this.btn_TS.UseVisualStyleBackColor = false;
            this.btn_TS.Click += new System.EventHandler(this.btn_TS_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label12);
            this.flowLayoutPanel8.Controls.Add(this.FileName_Box);
            this.flowLayoutPanel8.Controls.Add(this.btn_cap);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 166);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(203, 107);
            this.flowLayoutPanel8.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label12.Size = new System.Drawing.Size(130, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "File name :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileName_Box
            // 
            this.FileName_Box.Font = new System.Drawing.Font("Consolas", 15F);
            this.FileName_Box.Location = new System.Drawing.Point(0, 41);
            this.FileName_Box.Margin = new System.Windows.Forms.Padding(0);
            this.FileName_Box.Name = "FileName_Box";
            this.FileName_Box.Size = new System.Drawing.Size(203, 31);
            this.FileName_Box.TabIndex = 28;
            // 
            // btn_cap
            // 
            this.btn_cap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cap.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_cap.Location = new System.Drawing.Point(0, 72);
            this.btn_cap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(202, 32);
            this.btn_cap.TabIndex = 25;
            this.btn_cap.Text = "Capture";
            this.btn_cap.UseVisualStyleBackColor = false;
            this.btn_cap.Click += new System.EventHandler(this.btn_cap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label7.Size = new System.Drawing.Size(80, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Info :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brn_InfoCln
            // 
            this.brn_InfoCln.Location = new System.Drawing.Point(3, 467);
            this.brn_InfoCln.Name = "brn_InfoCln";
            this.brn_InfoCln.Size = new System.Drawing.Size(75, 23);
            this.brn_InfoCln.TabIndex = 25;
            this.brn_InfoCln.Text = "clean";
            this.brn_InfoCln.UseVisualStyleBackColor = true;
            this.brn_InfoCln.Click += new System.EventHandler(this.brn_InfoCln_Click);
            // 
            // flowLayoutPanel19
            // 
            this.flowLayoutPanel19.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel19.Controls.Add(this.listView1);
            this.flowLayoutPanel19.Controls.Add(this.btn_CmdStart);
            this.flowLayoutPanel19.Controls.Add(this.btn_CmdStop);
            this.flowLayoutPanel19.Controls.Add(this.btn_ClnList);
            this.flowLayoutPanel19.Controls.Add(this.command_box);
            this.flowLayoutPanel19.Controls.Add(this.btn_test);
            this.flowLayoutPanel19.Location = new System.Drawing.Point(223, 0);
            this.flowLayoutPanel19.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel19.Name = "flowLayoutPanel19";
            this.flowLayoutPanel19.Size = new System.Drawing.Size(361, 420);
            this.flowLayoutPanel19.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel7.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(361, 32);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label30.Size = new System.Drawing.Size(160, 31);
            this.label30.TabIndex = 25;
            this.label30.Text = "Command List :";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(361, 238);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 226;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rest time(m)";
            this.columnHeader2.Width = 130;
            // 
            // btn_CmdStop
            // 
            this.btn_CmdStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CmdStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CmdStop.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_CmdStop.Location = new System.Drawing.Point(180, 270);
            this.btn_CmdStop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CmdStop.Name = "btn_CmdStop";
            this.btn_CmdStop.Size = new System.Drawing.Size(181, 32);
            this.btn_CmdStop.TabIndex = 7;
            this.btn_CmdStop.Text = "Stop";
            this.btn_CmdStop.UseVisualStyleBackColor = false;
            this.btn_CmdStop.Click += new System.EventHandler(this.btn_CmdStop_Click);
            // 
            // btn_ClnList
            // 
            this.btn_ClnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ClnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClnList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_ClnList.Location = new System.Drawing.Point(0, 302);
            this.btn_ClnList.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ClnList.Name = "btn_ClnList";
            this.btn_ClnList.Size = new System.Drawing.Size(361, 32);
            this.btn_ClnList.TabIndex = 8;
            this.btn_ClnList.Text = "Clean list";
            this.btn_ClnList.UseVisualStyleBackColor = false;
            this.btn_ClnList.Click += new System.EventHandler(this.btn_ClnList_Click);
            // 
            // command_box
            // 
            this.command_box.Location = new System.Drawing.Point(2, 336);
            this.command_box.Margin = new System.Windows.Forms.Padding(2);
            this.command_box.Name = "command_box";
            this.command_box.Size = new System.Drawing.Size(129, 22);
            this.command_box.TabIndex = 5;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(136, 337);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 24;
            this.btn_test.Text = "send";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // timer_command
            // 
            this.timer_command.Tick += new System.EventHandler(this.timer_command_Tick);
            // 
            // timer_getStatus
            // 
            this.timer_getStatus.Tick += new System.EventHandler(this.timer_getStatus_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 370, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.label13.Size = new System.Drawing.Size(100, 31);
            this.label13.TabIndex = 27;
            this.label13.Text = "Status :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_PurgeLock
            // 
            this.btn_PurgeLock.BackColor = System.Drawing.Color.LightGray;
            this.btn_PurgeLock.BackgroundImage = global::MyTest.Properties.Resources._lock;
            this.btn_PurgeLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PurgeLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PurgeLock.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_PurgeLock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PurgeLock.Location = new System.Drawing.Point(485, 363);
            this.btn_PurgeLock.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btn_PurgeLock.Name = "btn_PurgeLock";
            this.btn_PurgeLock.Size = new System.Drawing.Size(35, 32);
            this.btn_PurgeLock.TabIndex = 30;
            this.btn_PurgeLock.UseVisualStyleBackColor = false;
            this.btn_PurgeLock.Click += new System.EventHandler(this.btn_PurgeLock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1144, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.flowLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel19.ResumeLayout(false);
            this.flowLayoutPanel19.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_CmdStart;
        private System.Windows.Forms.RichTextBox Info_Box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label4;
        private Label label5;
        private TextBox Addr_Box;
        private Button btn_TS;
        private TextBox Sequence_Box;
        private Label label6;
        private TextBox Time_Box;
        private Button btn_MS;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label label9;
        private Button btn_CheckNow;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label Update_LED;
        private FlowLayoutPanel flowLayoutPanel13;
        private Label label10;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label_Status2;
        private Label label_Status1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label14;
        private FlowLayoutPanel flowLayoutPanel12;
        private FlowLayoutPanel flowLayoutPanel16;
        private Label label17;
        private FlowLayoutPanel flowLayoutPanel17;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label_Measure3;
        private Label label_Measure1;
        private Label label21;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label15;
        private Label label22;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label_Measure4;
        private Label label_Measure2;
        private Label label16;
        private Label label25;
        private Label label_Measure5;
        private Label label_Measure6;
        private FlowLayoutPanel flowLayoutPanel19;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label30;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label20;
        private Label label28;
        private Label label29;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label7;
        private Button btn_CmdStop;
        private Button btn_ClnList;
        private ColumnHeader columnHeader2;
        private ComboBox Point_Box;
        private Timer timer_command;
        private Timer timer_getStatus;
        private Button btn_test;
        private Button brn_InfoCln;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label12;
        private TextBox FileName_Box;
        private Button btn_cap;
        private TextBox command_box;
        private ComboBox UpdateRate_Box;
        private Button btn_Purge;
        private Label label13;
        private Button btn_PurgeLock;
    }
}

