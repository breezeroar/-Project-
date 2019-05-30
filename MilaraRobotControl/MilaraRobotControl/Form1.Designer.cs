namespace MilaraRobotControl
{
    partial class Form
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
            this.comboBox_PortSelect = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_PowerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_moveMent = new System.Windows.Forms.GroupBox();
            this.button_zAction = new System.Windows.Forms.Button();
            this.button_r2Action = new System.Windows.Forms.Button();
            this.button_r1Action = new System.Windows.Forms.Button();
            this.button_tAction = new System.Windows.Forms.Button();
            this.numericUpDown_zPosition = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_r2Position = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_r1Position = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_tPosition = new System.Windows.Forms.NumericUpDown();
            this.bkWorker_cpo = new System.ComponentModel.BackgroundWorker();
            this.btn_home = new System.Windows.Forms.Button();
            this.groupBox_systemStatus = new System.Windows.Forms.GroupBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_vacuumSwitch = new System.Windows.Forms.Button();
            this.btn_servoSwitch = new System.Windows.Forms.Button();
            this.btn_powerSwitch = new System.Windows.Forms.Button();
            this.groupBox_systemControl = new System.Windows.Forms.GroupBox();
            this.button_rmp = new System.Windows.Forms.Button();
            this.button_smp = new System.Windows.Forms.Button();
            this.button_resetRobot = new System.Windows.Forms.Button();
            this.groupBox_axesStatus = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label_zCpo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label_r2Cpo = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label_r1Cpo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label_tCpo = new System.Windows.Forms.Label();
            this.label_tSpd = new System.Windows.Forms.Label();
            this.groupBox_spdSetting = new System.Windows.Forms.GroupBox();
            this.comboBox_axisParameter = new System.Windows.Forms.ComboBox();
            this.button_zParameterSet = new System.Windows.Forms.Button();
            this.button_r2ParameterSet = new System.Windows.Forms.Button();
            this.button_r1ParameterSet = new System.Windows.Forms.Button();
            this.button_tParameterSet = new System.Windows.Forms.Button();
            this.numericUpDown_zSpd = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.numericUpDown_r2Spd = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDown_r1Spd = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.numericUpDown_tSpd = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label_r1Spd = new System.Windows.Forms.Label();
            this.label_r2Spd = new System.Windows.Forms.Label();
            this.label_zSpd = new System.Windows.Forms.Label();
            this.label_tAcl = new System.Windows.Forms.Label();
            this.label_r1Acl = new System.Windows.Forms.Label();
            this.label_r2Acl = new System.Windows.Forms.Label();
            this.label_zAcl = new System.Windows.Forms.Label();
            this.label_tDCL = new System.Windows.Forms.Label();
            this.label_r1DCL = new System.Windows.Forms.Label();
            this.label_r2DCL = new System.Windows.Forms.Label();
            this.label_zDCL = new System.Windows.Forms.Label();
            this.label_tAjk = new System.Windows.Forms.Label();
            this.label_r1Ajk = new System.Windows.Forms.Label();
            this.label_r2Ajk = new System.Windows.Forms.Label();
            this.label_zAjk = new System.Windows.Forms.Label();
            this.label_tDjk = new System.Windows.Forms.Label();
            this.label_r1Djk = new System.Windows.Forms.Label();
            this.label_r2Djk = new System.Windows.Forms.Label();
            this.label_zDjk = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox_moveMent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r2Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r1Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tPosition)).BeginInit();
            this.groupBox_systemStatus.SuspendLayout();
            this.groupBox_systemControl.SuspendLayout();
            this.groupBox_axesStatus.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_spdSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r2Spd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r1Spd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tSpd)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_PortSelect
            // 
            this.comboBox_PortSelect.FormattingEnabled = true;
            this.comboBox_PortSelect.Location = new System.Drawing.Point(5, 5);
            this.comboBox_PortSelect.Name = "comboBox_PortSelect";
            this.comboBox_PortSelect.Size = new System.Drawing.Size(66, 20);
            this.comboBox_PortSelect.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(77, 5);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(66, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_ConnectStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_PowerStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel1.Text = "ConnectStatus:";
            // 
            // toolStripStatusLabel_ConnectStatus
            // 
            this.toolStripStatusLabel_ConnectStatus.Name = "toolStripStatusLabel_ConnectStatus";
            this.toolStripStatusLabel_ConnectStatus.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel_ConnectStatus.Text = "Disconnect";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel2.Text = "| Power:";
            // 
            // toolStripStatusLabel_PowerStatus
            // 
            this.toolStripStatusLabel_PowerStatus.Name = "toolStripStatusLabel_PowerStatus";
            this.toolStripStatusLabel_PowerStatus.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel_PowerStatus.Text = "off";
            // 
            // groupBox_moveMent
            // 
            this.groupBox_moveMent.Controls.Add(this.button_zAction);
            this.groupBox_moveMent.Controls.Add(this.button_r2Action);
            this.groupBox_moveMent.Controls.Add(this.button_r1Action);
            this.groupBox_moveMent.Controls.Add(this.button_tAction);
            this.groupBox_moveMent.Controls.Add(this.numericUpDown_zPosition);
            this.groupBox_moveMent.Controls.Add(this.numericUpDown_r2Position);
            this.groupBox_moveMent.Controls.Add(this.numericUpDown_r1Position);
            this.groupBox_moveMent.Controls.Add(this.label4);
            this.groupBox_moveMent.Controls.Add(this.label3);
            this.groupBox_moveMent.Controls.Add(this.label2);
            this.groupBox_moveMent.Controls.Add(this.label1);
            this.groupBox_moveMent.Controls.Add(this.numericUpDown_tPosition);
            this.groupBox_moveMent.Enabled = false;
            this.groupBox_moveMent.Location = new System.Drawing.Point(5, 34);
            this.groupBox_moveMent.Name = "groupBox_moveMent";
            this.groupBox_moveMent.Size = new System.Drawing.Size(200, 138);
            this.groupBox_moveMent.TabIndex = 3;
            this.groupBox_moveMent.TabStop = false;
            this.groupBox_moveMent.Text = "Movement";
            // 
            // button_zAction
            // 
            this.button_zAction.Location = new System.Drawing.Point(120, 105);
            this.button_zAction.Name = "button_zAction";
            this.button_zAction.Size = new System.Drawing.Size(66, 22);
            this.button_zAction.TabIndex = 18;
            this.button_zAction.Text = "Action";
            this.button_zAction.UseVisualStyleBackColor = true;
            this.button_zAction.Click += new System.EventHandler(this.button_zAction_Click);
            // 
            // button_r2Action
            // 
            this.button_r2Action.Location = new System.Drawing.Point(120, 77);
            this.button_r2Action.Name = "button_r2Action";
            this.button_r2Action.Size = new System.Drawing.Size(66, 22);
            this.button_r2Action.TabIndex = 17;
            this.button_r2Action.Text = "Action";
            this.button_r2Action.UseVisualStyleBackColor = true;
            this.button_r2Action.Click += new System.EventHandler(this.button_r2Action_Click);
            // 
            // button_r1Action
            // 
            this.button_r1Action.Location = new System.Drawing.Point(120, 49);
            this.button_r1Action.Name = "button_r1Action";
            this.button_r1Action.Size = new System.Drawing.Size(66, 22);
            this.button_r1Action.TabIndex = 16;
            this.button_r1Action.Text = "Action";
            this.button_r1Action.UseVisualStyleBackColor = true;
            this.button_r1Action.Click += new System.EventHandler(this.button_r1Action_Click);
            // 
            // button_tAction
            // 
            this.button_tAction.Location = new System.Drawing.Point(120, 21);
            this.button_tAction.Name = "button_tAction";
            this.button_tAction.Size = new System.Drawing.Size(66, 22);
            this.button_tAction.TabIndex = 15;
            this.button_tAction.Text = "Action";
            this.button_tAction.UseVisualStyleBackColor = true;
            this.button_tAction.Click += new System.EventHandler(this.button_tAction_Click);
            // 
            // numericUpDown_zPosition
            // 
            this.numericUpDown_zPosition.Location = new System.Drawing.Point(49, 105);
            this.numericUpDown_zPosition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_zPosition.Name = "numericUpDown_zPosition";
            this.numericUpDown_zPosition.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_zPosition.TabIndex = 10;
            // 
            // numericUpDown_r2Position
            // 
            this.numericUpDown_r2Position.Location = new System.Drawing.Point(49, 77);
            this.numericUpDown_r2Position.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_r2Position.Name = "numericUpDown_r2Position";
            this.numericUpDown_r2Position.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_r2Position.TabIndex = 9;
            // 
            // numericUpDown_r1Position
            // 
            this.numericUpDown_r1Position.Location = new System.Drawing.Point(49, 49);
            this.numericUpDown_r1Position.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_r1Position.Name = "numericUpDown_r1Position";
            this.numericUpDown_r1Position.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_r1Position.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Z：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "R2：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R1：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "T：";
            // 
            // numericUpDown_tPosition
            // 
            this.numericUpDown_tPosition.Location = new System.Drawing.Point(49, 21);
            this.numericUpDown_tPosition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_tPosition.Name = "numericUpDown_tPosition";
            this.numericUpDown_tPosition.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_tPosition.TabIndex = 0;
            // 
            // bkWorker_cpo
            // 
            this.bkWorker_cpo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorker_cpo_DoWork);
            this.bkWorker_cpo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkWorker_cpo_ProgressChanged);
            // 
            // btn_home
            // 
            this.btn_home.Enabled = false;
            this.btn_home.Location = new System.Drawing.Point(149, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(93, 23);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "Home the axes";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // groupBox_systemStatus
            // 
            this.groupBox_systemStatus.Controls.Add(this.checkBox16);
            this.groupBox_systemStatus.Controls.Add(this.checkBox15);
            this.groupBox_systemStatus.Controls.Add(this.checkBox14);
            this.groupBox_systemStatus.Controls.Add(this.checkBox13);
            this.groupBox_systemStatus.Controls.Add(this.checkBox12);
            this.groupBox_systemStatus.Controls.Add(this.checkBox11);
            this.groupBox_systemStatus.Controls.Add(this.checkBox10);
            this.groupBox_systemStatus.Controls.Add(this.checkBox9);
            this.groupBox_systemStatus.Controls.Add(this.checkBox8);
            this.groupBox_systemStatus.Controls.Add(this.checkBox7);
            this.groupBox_systemStatus.Controls.Add(this.checkBox6);
            this.groupBox_systemStatus.Controls.Add(this.checkBox5);
            this.groupBox_systemStatus.Controls.Add(this.checkBox4);
            this.groupBox_systemStatus.Controls.Add(this.checkBox3);
            this.groupBox_systemStatus.Controls.Add(this.checkBox2);
            this.groupBox_systemStatus.Controls.Add(this.checkBox1);
            this.groupBox_systemStatus.Controls.Add(this.label20);
            this.groupBox_systemStatus.Controls.Add(this.label19);
            this.groupBox_systemStatus.Controls.Add(this.label18);
            this.groupBox_systemStatus.Controls.Add(this.label17);
            this.groupBox_systemStatus.Controls.Add(this.label16);
            this.groupBox_systemStatus.Controls.Add(this.label15);
            this.groupBox_systemStatus.Controls.Add(this.label14);
            this.groupBox_systemStatus.Controls.Add(this.label13);
            this.groupBox_systemStatus.Controls.Add(this.label12);
            this.groupBox_systemStatus.Controls.Add(this.label11);
            this.groupBox_systemStatus.Controls.Add(this.label10);
            this.groupBox_systemStatus.Controls.Add(this.label9);
            this.groupBox_systemStatus.Controls.Add(this.label8);
            this.groupBox_systemStatus.Controls.Add(this.label7);
            this.groupBox_systemStatus.Controls.Add(this.label6);
            this.groupBox_systemStatus.Controls.Add(this.label5);
            this.groupBox_systemStatus.Location = new System.Drawing.Point(372, 34);
            this.groupBox_systemStatus.Name = "groupBox_systemStatus";
            this.groupBox_systemStatus.Size = new System.Drawing.Size(245, 370);
            this.groupBox_systemStatus.TabIndex = 20;
            this.groupBox_systemStatus.TabStop = false;
            this.groupBox_systemStatus.Text = "SystemStatus";
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Enabled = false;
            this.checkBox16.Location = new System.Drawing.Point(9, 321);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 14);
            this.checkBox16.TabIndex = 33;
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Enabled = false;
            this.checkBox15.Location = new System.Drawing.Point(9, 301);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 32;
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Enabled = false;
            this.checkBox14.Location = new System.Drawing.Point(9, 281);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 31;
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Enabled = false;
            this.checkBox13.Location = new System.Drawing.Point(9, 261);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 30;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Enabled = false;
            this.checkBox12.Location = new System.Drawing.Point(9, 241);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 29;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Enabled = false;
            this.checkBox11.Location = new System.Drawing.Point(9, 221);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 28;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Enabled = false;
            this.checkBox10.Location = new System.Drawing.Point(9, 201);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 27;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Enabled = false;
            this.checkBox9.Location = new System.Drawing.Point(9, 181);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 26;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Location = new System.Drawing.Point(9, 161);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 25;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(9, 141);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 24;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(9, 121);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 23;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(9, 101);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(9, 81);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(9, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(9, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(9, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(25, 320);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "Prealigner Busy";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(25, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 15);
            this.label19.TabIndex = 14;
            this.label19.Text = "In Teach Scan Position(TSP)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(25, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 15);
            this.label18.TabIndex = 13;
            this.label18.Text = "I/O File error";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(25, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 15);
            this.label17.TabIndex = 12;
            this.label17.Text = "In search mode(PGO)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(25, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "In teach mode(TCH/EOT)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(25, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Servo OFF on one or more axes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(25, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Single-axis prealigner error";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(25, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Robot busy(Motion in progress)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(25, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Robot busy(User macro running)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(25, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Home procedure not executed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(25, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Software Motion limits violation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(25, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Motion or position error";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(25, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Vacuum Switch ON";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(25, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vacuum Sensor ON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Previous command returned an error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unable to execute motion commands";
            // 
            // btn_vacuumSwitch
            // 
            this.btn_vacuumSwitch.Location = new System.Drawing.Point(114, 14);
            this.btn_vacuumSwitch.Name = "btn_vacuumSwitch";
            this.btn_vacuumSwitch.Size = new System.Drawing.Size(52, 40);
            this.btn_vacuumSwitch.TabIndex = 21;
            this.btn_vacuumSwitch.Text = "Vacuum ON/OFF";
            this.btn_vacuumSwitch.UseVisualStyleBackColor = true;
            this.btn_vacuumSwitch.Click += new System.EventHandler(this.btn_vacuumSwitch_Click);
            // 
            // btn_servoSwitch
            // 
            this.btn_servoSwitch.Location = new System.Drawing.Point(60, 14);
            this.btn_servoSwitch.Name = "btn_servoSwitch";
            this.btn_servoSwitch.Size = new System.Drawing.Size(52, 40);
            this.btn_servoSwitch.TabIndex = 22;
            this.btn_servoSwitch.Text = "Servo ON/OFF";
            this.btn_servoSwitch.UseVisualStyleBackColor = true;
            this.btn_servoSwitch.Click += new System.EventHandler(this.btn_servoSwitch_Click);
            // 
            // btn_powerSwitch
            // 
            this.btn_powerSwitch.Location = new System.Drawing.Point(6, 14);
            this.btn_powerSwitch.Name = "btn_powerSwitch";
            this.btn_powerSwitch.Size = new System.Drawing.Size(52, 40);
            this.btn_powerSwitch.TabIndex = 23;
            this.btn_powerSwitch.Text = "Power ON/OFF";
            this.btn_powerSwitch.UseVisualStyleBackColor = true;
            this.btn_powerSwitch.Click += new System.EventHandler(this.btn_powerSwitch_Click);
            // 
            // groupBox_systemControl
            // 
            this.groupBox_systemControl.Controls.Add(this.button_rmp);
            this.groupBox_systemControl.Controls.Add(this.button_smp);
            this.groupBox_systemControl.Controls.Add(this.button_resetRobot);
            this.groupBox_systemControl.Controls.Add(this.btn_powerSwitch);
            this.groupBox_systemControl.Controls.Add(this.btn_servoSwitch);
            this.groupBox_systemControl.Controls.Add(this.btn_vacuumSwitch);
            this.groupBox_systemControl.Enabled = false;
            this.groupBox_systemControl.Location = new System.Drawing.Point(5, 341);
            this.groupBox_systemControl.Name = "groupBox_systemControl";
            this.groupBox_systemControl.Size = new System.Drawing.Size(361, 63);
            this.groupBox_systemControl.TabIndex = 24;
            this.groupBox_systemControl.TabStop = false;
            this.groupBox_systemControl.Text = "System Control";
            // 
            // button_rmp
            // 
            this.button_rmp.Location = new System.Drawing.Point(229, 14);
            this.button_rmp.Name = "button_rmp";
            this.button_rmp.Size = new System.Drawing.Size(59, 40);
            this.button_rmp.TabIndex = 26;
            this.button_rmp.Text = "Read\r\nParameter";
            this.button_rmp.UseVisualStyleBackColor = true;
            // 
            // button_smp
            // 
            this.button_smp.Location = new System.Drawing.Point(168, 14);
            this.button_smp.Name = "button_smp";
            this.button_smp.Size = new System.Drawing.Size(59, 40);
            this.button_smp.TabIndex = 25;
            this.button_smp.Text = "Save\r\nParameter";
            this.button_smp.UseVisualStyleBackColor = true;
            // 
            // button_resetRobot
            // 
            this.button_resetRobot.Location = new System.Drawing.Point(290, 14);
            this.button_resetRobot.Name = "button_resetRobot";
            this.button_resetRobot.Size = new System.Drawing.Size(60, 40);
            this.button_resetRobot.TabIndex = 24;
            this.button_resetRobot.Text = "Reset";
            this.button_resetRobot.UseVisualStyleBackColor = true;
            this.button_resetRobot.Click += new System.EventHandler(this.button_resetRobot_Click);
            // 
            // groupBox_axesStatus
            // 
            this.groupBox_axesStatus.Controls.Add(this.groupBox4);
            this.groupBox_axesStatus.Controls.Add(this.groupBox3);
            this.groupBox_axesStatus.Controls.Add(this.groupBox2);
            this.groupBox_axesStatus.Controls.Add(this.groupBox1);
            this.groupBox_axesStatus.Location = new System.Drawing.Point(211, 34);
            this.groupBox_axesStatus.Name = "groupBox_axesStatus";
            this.groupBox_axesStatus.Size = new System.Drawing.Size(155, 301);
            this.groupBox_axesStatus.TabIndex = 25;
            this.groupBox_axesStatus.TabStop = false;
            this.groupBox_axesStatus.Text = "AxesStatus";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_zDjk);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label_zAjk);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.label_zCpo);
            this.groupBox4.Controls.Add(this.label_zSpd);
            this.groupBox4.Controls.Add(this.label_zDCL);
            this.groupBox4.Controls.Add(this.label_zAcl);
            this.groupBox4.Location = new System.Drawing.Point(6, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 65);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Z";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label47.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label47.Location = new System.Drawing.Point(75, 47);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(26, 11);
            this.label47.TabIndex = 46;
            this.label47.Text = "DJK:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label52.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label52.Location = new System.Drawing.Point(3, 13);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(28, 11);
            this.label52.TabIndex = 41;
            this.label52.Text = "CPO:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label48.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label48.Location = new System.Drawing.Point(5, 47);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(26, 11);
            this.label48.TabIndex = 45;
            this.label48.Text = "AJK:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label51.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label51.Location = new System.Drawing.Point(75, 13);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(27, 11);
            this.label51.TabIndex = 42;
            this.label51.Text = "SPD:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label49.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label49.Location = new System.Drawing.Point(72, 30);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(28, 11);
            this.label49.TabIndex = 44;
            this.label49.Text = "DCL:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label50.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label50.Location = new System.Drawing.Point(2, 30);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(28, 11);
            this.label50.TabIndex = 43;
            this.label50.Text = "ACL:";
            // 
            // label_zCpo
            // 
            this.label_zCpo.AutoSize = true;
            this.label_zCpo.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_zCpo.Location = new System.Drawing.Point(29, 12);
            this.label_zCpo.Name = "label_zCpo";
            this.label_zCpo.Size = new System.Drawing.Size(30, 12);
            this.label_zCpo.TabIndex = 17;
            this.label_zCpo.Text = "zCpo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label_r2Djk);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.label_r2Ajk);
            this.groupBox3.Controls.Add(this.label_r2Cpo);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.label_r2Spd);
            this.groupBox3.Controls.Add(this.label_r2Acl);
            this.groupBox3.Controls.Add(this.label_r2DCL);
            this.groupBox3.Location = new System.Drawing.Point(6, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 65);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "R2";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label41.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label41.Location = new System.Drawing.Point(75, 47);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(26, 11);
            this.label41.TabIndex = 40;
            this.label41.Text = "DJK:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label46.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label46.Location = new System.Drawing.Point(3, 13);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(28, 11);
            this.label46.TabIndex = 35;
            this.label46.Text = "CPO:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label42.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label42.Location = new System.Drawing.Point(5, 47);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(26, 11);
            this.label42.TabIndex = 39;
            this.label42.Text = "AJK:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label45.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label45.Location = new System.Drawing.Point(75, 13);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(27, 11);
            this.label45.TabIndex = 36;
            this.label45.Text = "SPD:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label43.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label43.Location = new System.Drawing.Point(72, 30);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(28, 11);
            this.label43.TabIndex = 38;
            this.label43.Text = "DCL:";
            // 
            // label_r2Cpo
            // 
            this.label_r2Cpo.AutoSize = true;
            this.label_r2Cpo.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_r2Cpo.Location = new System.Drawing.Point(29, 12);
            this.label_r2Cpo.Name = "label_r2Cpo";
            this.label_r2Cpo.Size = new System.Drawing.Size(35, 12);
            this.label_r2Cpo.TabIndex = 18;
            this.label_r2Cpo.Text = "r2Cpo";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label44.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label44.Location = new System.Drawing.Point(2, 30);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(28, 11);
            this.label44.TabIndex = 37;
            this.label44.Text = "ACL:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.label_r1Djk);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label_r1Ajk);
            this.groupBox2.Controls.Add(this.label_r1Cpo);
            this.groupBox2.Controls.Add(this.label_r1Spd);
            this.groupBox2.Controls.Add(this.label_r1Acl);
            this.groupBox2.Controls.Add(this.label_r1DCL);
            this.groupBox2.Location = new System.Drawing.Point(6, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 65);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "R1";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label35.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label35.Location = new System.Drawing.Point(75, 47);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(26, 11);
            this.label35.TabIndex = 34;
            this.label35.Text = "DJK:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label40.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label40.Location = new System.Drawing.Point(3, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(28, 11);
            this.label40.TabIndex = 29;
            this.label40.Text = "CPO:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label36.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label36.Location = new System.Drawing.Point(5, 47);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(26, 11);
            this.label36.TabIndex = 33;
            this.label36.Text = "AJK:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label39.Location = new System.Drawing.Point(75, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 11);
            this.label39.TabIndex = 30;
            this.label39.Text = "SPD:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label37.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label37.Location = new System.Drawing.Point(72, 30);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 11);
            this.label37.TabIndex = 32;
            this.label37.Text = "DCL:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label38.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label38.Location = new System.Drawing.Point(2, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(28, 11);
            this.label38.TabIndex = 31;
            this.label38.Text = "ACL:";
            // 
            // label_r1Cpo
            // 
            this.label_r1Cpo.AutoSize = true;
            this.label_r1Cpo.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_r1Cpo.Location = new System.Drawing.Point(29, 12);
            this.label_r1Cpo.Name = "label_r1Cpo";
            this.label_r1Cpo.Size = new System.Drawing.Size(35, 12);
            this.label_r1Cpo.TabIndex = 16;
            this.label_r1Cpo.Text = "r1Cpo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label_tDjk);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label_tCpo);
            this.groupBox1.Controls.Add(this.label_tAjk);
            this.groupBox1.Controls.Add(this.label_tSpd);
            this.groupBox1.Controls.Add(this.label_tAcl);
            this.groupBox1.Controls.Add(this.label_tDCL);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 65);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "T";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label34.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label34.Location = new System.Drawing.Point(75, 47);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 11);
            this.label34.TabIndex = 28;
            this.label34.Text = "DJK:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label33.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label33.Location = new System.Drawing.Point(5, 47);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 11);
            this.label33.TabIndex = 27;
            this.label33.Text = "AJK:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label32.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label32.Location = new System.Drawing.Point(72, 30);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(28, 11);
            this.label32.TabIndex = 26;
            this.label32.Text = "DCL:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label31.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label31.Location = new System.Drawing.Point(2, 30);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(28, 11);
            this.label31.TabIndex = 25;
            this.label31.Text = "ACL:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label30.Location = new System.Drawing.Point(75, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 11);
            this.label30.TabIndex = 24;
            this.label30.Text = "SPD:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(3, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(28, 11);
            this.label29.TabIndex = 23;
            this.label29.Text = "CPO:";
            // 
            // label_tCpo
            // 
            this.label_tCpo.AutoSize = true;
            this.label_tCpo.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_tCpo.Location = new System.Drawing.Point(31, 12);
            this.label_tCpo.Name = "label_tCpo";
            this.label_tCpo.Size = new System.Drawing.Size(28, 12);
            this.label_tCpo.TabIndex = 15;
            this.label_tCpo.Text = "tCpo";
            // 
            // label_tSpd
            // 
            this.label_tSpd.AutoSize = true;
            this.label_tSpd.Location = new System.Drawing.Point(102, 12);
            this.label_tSpd.Name = "label_tSpd";
            this.label_tSpd.Size = new System.Drawing.Size(26, 12);
            this.label_tSpd.TabIndex = 27;
            this.label_tSpd.Text = "tSpd";
            // 
            // groupBox_spdSetting
            // 
            this.groupBox_spdSetting.Controls.Add(this.comboBox_axisParameter);
            this.groupBox_spdSetting.Controls.Add(this.button_zParameterSet);
            this.groupBox_spdSetting.Controls.Add(this.button_r2ParameterSet);
            this.groupBox_spdSetting.Controls.Add(this.button_r1ParameterSet);
            this.groupBox_spdSetting.Controls.Add(this.button_tParameterSet);
            this.groupBox_spdSetting.Controls.Add(this.numericUpDown_zSpd);
            this.groupBox_spdSetting.Controls.Add(this.label25);
            this.groupBox_spdSetting.Controls.Add(this.numericUpDown_r2Spd);
            this.groupBox_spdSetting.Controls.Add(this.label28);
            this.groupBox_spdSetting.Controls.Add(this.numericUpDown_r1Spd);
            this.groupBox_spdSetting.Controls.Add(this.label26);
            this.groupBox_spdSetting.Controls.Add(this.numericUpDown_tSpd);
            this.groupBox_spdSetting.Controls.Add(this.label27);
            this.groupBox_spdSetting.Enabled = false;
            this.groupBox_spdSetting.Location = new System.Drawing.Point(5, 178);
            this.groupBox_spdSetting.Name = "groupBox_spdSetting";
            this.groupBox_spdSetting.Size = new System.Drawing.Size(200, 157);
            this.groupBox_spdSetting.TabIndex = 26;
            this.groupBox_spdSetting.TabStop = false;
            this.groupBox_spdSetting.Text = "SpeedSetting";
            // 
            // comboBox_axisParameter
            // 
            this.comboBox_axisParameter.FormattingEnabled = true;
            this.comboBox_axisParameter.Items.AddRange(new object[] {
            "SPD",
            "ACL",
            "DCL",
            "AJK",
            "DJK"});
            this.comboBox_axisParameter.Location = new System.Drawing.Point(70, 16);
            this.comboBox_axisParameter.Name = "comboBox_axisParameter";
            this.comboBox_axisParameter.Size = new System.Drawing.Size(60, 20);
            this.comboBox_axisParameter.TabIndex = 27;
            // 
            // button_zParameterSet
            // 
            this.button_zParameterSet.Location = new System.Drawing.Point(111, 126);
            this.button_zParameterSet.Name = "button_zParameterSet";
            this.button_zParameterSet.Size = new System.Drawing.Size(75, 22);
            this.button_zParameterSet.TabIndex = 26;
            this.button_zParameterSet.Text = "Set Z axis";
            this.button_zParameterSet.UseVisualStyleBackColor = true;
            this.button_zParameterSet.Click += new System.EventHandler(this.button_zParameterSet_Click);
            // 
            // button_r2ParameterSet
            // 
            this.button_r2ParameterSet.Location = new System.Drawing.Point(111, 98);
            this.button_r2ParameterSet.Name = "button_r2ParameterSet";
            this.button_r2ParameterSet.Size = new System.Drawing.Size(75, 22);
            this.button_r2ParameterSet.TabIndex = 25;
            this.button_r2ParameterSet.Text = "Set R2 axis";
            this.button_r2ParameterSet.UseVisualStyleBackColor = true;
            this.button_r2ParameterSet.Click += new System.EventHandler(this.button_r2ParameterSet_Click);
            // 
            // button_r1ParameterSet
            // 
            this.button_r1ParameterSet.Location = new System.Drawing.Point(111, 70);
            this.button_r1ParameterSet.Name = "button_r1ParameterSet";
            this.button_r1ParameterSet.Size = new System.Drawing.Size(75, 22);
            this.button_r1ParameterSet.TabIndex = 24;
            this.button_r1ParameterSet.Text = "Set R1 axis";
            this.button_r1ParameterSet.UseVisualStyleBackColor = true;
            this.button_r1ParameterSet.Click += new System.EventHandler(this.button_r1ParameterSet_Click);
            // 
            // button_tParameterSet
            // 
            this.button_tParameterSet.Location = new System.Drawing.Point(111, 42);
            this.button_tParameterSet.Name = "button_tParameterSet";
            this.button_tParameterSet.Size = new System.Drawing.Size(75, 22);
            this.button_tParameterSet.TabIndex = 23;
            this.button_tParameterSet.Text = "Set T axis";
            this.button_tParameterSet.UseVisualStyleBackColor = true;
            this.button_tParameterSet.Click += new System.EventHandler(this.button_tParameterSet_Click);
            // 
            // numericUpDown_zSpd
            // 
            this.numericUpDown_zSpd.Location = new System.Drawing.Point(45, 126);
            this.numericUpDown_zSpd.Name = "numericUpDown_zSpd";
            this.numericUpDown_zSpd.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_zSpd.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label25.Location = new System.Drawing.Point(16, 131);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 22;
            this.label25.Text = "Z：";
            // 
            // numericUpDown_r2Spd
            // 
            this.numericUpDown_r2Spd.Location = new System.Drawing.Point(45, 98);
            this.numericUpDown_r2Spd.Name = "numericUpDown_r2Spd";
            this.numericUpDown_r2Spd.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_r2Spd.TabIndex = 21;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(16, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 13);
            this.label28.TabIndex = 19;
            this.label28.Text = "T：";
            // 
            // numericUpDown_r1Spd
            // 
            this.numericUpDown_r1Spd.Location = new System.Drawing.Point(45, 70);
            this.numericUpDown_r1Spd.Name = "numericUpDown_r1Spd";
            this.numericUpDown_r1Spd.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_r1Spd.TabIndex = 20;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.Location = new System.Drawing.Point(9, 103);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 21;
            this.label26.Text = "R2：";
            // 
            // numericUpDown_tSpd
            // 
            this.numericUpDown_tSpd.Location = new System.Drawing.Point(45, 42);
            this.numericUpDown_tSpd.Name = "numericUpDown_tSpd";
            this.numericUpDown_tSpd.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_tSpd.TabIndex = 19;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label27.Location = new System.Drawing.Point(9, 75);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 20;
            this.label27.Text = "R1：";
            // 
            // label_r1Spd
            // 
            this.label_r1Spd.AutoSize = true;
            this.label_r1Spd.Location = new System.Drawing.Point(100, 12);
            this.label_r1Spd.Name = "label_r1Spd";
            this.label_r1Spd.Size = new System.Drawing.Size(33, 12);
            this.label_r1Spd.TabIndex = 28;
            this.label_r1Spd.Text = "r1Spd";
            // 
            // label_r2Spd
            // 
            this.label_r2Spd.AutoSize = true;
            this.label_r2Spd.Location = new System.Drawing.Point(100, 12);
            this.label_r2Spd.Name = "label_r2Spd";
            this.label_r2Spd.Size = new System.Drawing.Size(33, 12);
            this.label_r2Spd.TabIndex = 29;
            this.label_r2Spd.Text = "r2Spd";
            // 
            // label_zSpd
            // 
            this.label_zSpd.AutoSize = true;
            this.label_zSpd.Location = new System.Drawing.Point(100, 12);
            this.label_zSpd.Name = "label_zSpd";
            this.label_zSpd.Size = new System.Drawing.Size(28, 12);
            this.label_zSpd.TabIndex = 30;
            this.label_zSpd.Text = "zSpd";
            // 
            // label_tAcl
            // 
            this.label_tAcl.AutoSize = true;
            this.label_tAcl.Location = new System.Drawing.Point(31, 29);
            this.label_tAcl.Name = "label_tAcl";
            this.label_tAcl.Size = new System.Drawing.Size(24, 12);
            this.label_tAcl.TabIndex = 31;
            this.label_tAcl.Text = "tAcl";
            // 
            // label_r1Acl
            // 
            this.label_r1Acl.AutoSize = true;
            this.label_r1Acl.Location = new System.Drawing.Point(29, 29);
            this.label_r1Acl.Name = "label_r1Acl";
            this.label_r1Acl.Size = new System.Drawing.Size(31, 12);
            this.label_r1Acl.TabIndex = 32;
            this.label_r1Acl.Text = "r1Acl";
            // 
            // label_r2Acl
            // 
            this.label_r2Acl.AutoSize = true;
            this.label_r2Acl.Location = new System.Drawing.Point(29, 29);
            this.label_r2Acl.Name = "label_r2Acl";
            this.label_r2Acl.Size = new System.Drawing.Size(31, 12);
            this.label_r2Acl.TabIndex = 33;
            this.label_r2Acl.Text = "r2Acl";
            // 
            // label_zAcl
            // 
            this.label_zAcl.AutoSize = true;
            this.label_zAcl.Location = new System.Drawing.Point(29, 29);
            this.label_zAcl.Name = "label_zAcl";
            this.label_zAcl.Size = new System.Drawing.Size(26, 12);
            this.label_zAcl.TabIndex = 34;
            this.label_zAcl.Text = "zAcl";
            // 
            // label_tDCL
            // 
            this.label_tDCL.AutoSize = true;
            this.label_tDCL.Location = new System.Drawing.Point(102, 29);
            this.label_tDCL.Name = "label_tDCL";
            this.label_tDCL.Size = new System.Drawing.Size(31, 12);
            this.label_tDCL.TabIndex = 35;
            this.label_tDCL.Text = "tDCL";
            // 
            // label_r1DCL
            // 
            this.label_r1DCL.AutoSize = true;
            this.label_r1DCL.Location = new System.Drawing.Point(100, 29);
            this.label_r1DCL.Name = "label_r1DCL";
            this.label_r1DCL.Size = new System.Drawing.Size(38, 12);
            this.label_r1DCL.TabIndex = 36;
            this.label_r1DCL.Text = "r1DCL";
            // 
            // label_r2DCL
            // 
            this.label_r2DCL.AutoSize = true;
            this.label_r2DCL.Location = new System.Drawing.Point(100, 29);
            this.label_r2DCL.Name = "label_r2DCL";
            this.label_r2DCL.Size = new System.Drawing.Size(38, 12);
            this.label_r2DCL.TabIndex = 37;
            this.label_r2DCL.Text = "r2DCL";
            // 
            // label_zDCL
            // 
            this.label_zDCL.AutoSize = true;
            this.label_zDCL.Location = new System.Drawing.Point(100, 29);
            this.label_zDCL.Name = "label_zDCL";
            this.label_zDCL.Size = new System.Drawing.Size(33, 12);
            this.label_zDCL.TabIndex = 38;
            this.label_zDCL.Text = "zDCL";
            // 
            // label_tAjk
            // 
            this.label_tAjk.AutoSize = true;
            this.label_tAjk.Location = new System.Drawing.Point(31, 46);
            this.label_tAjk.Name = "label_tAjk";
            this.label_tAjk.Size = new System.Drawing.Size(25, 12);
            this.label_tAjk.TabIndex = 39;
            this.label_tAjk.Text = "tAjk";
            // 
            // label_r1Ajk
            // 
            this.label_r1Ajk.AutoSize = true;
            this.label_r1Ajk.Location = new System.Drawing.Point(29, 46);
            this.label_r1Ajk.Name = "label_r1Ajk";
            this.label_r1Ajk.Size = new System.Drawing.Size(32, 12);
            this.label_r1Ajk.TabIndex = 40;
            this.label_r1Ajk.Text = "r1Ajk";
            // 
            // label_r2Ajk
            // 
            this.label_r2Ajk.AutoSize = true;
            this.label_r2Ajk.Location = new System.Drawing.Point(29, 46);
            this.label_r2Ajk.Name = "label_r2Ajk";
            this.label_r2Ajk.Size = new System.Drawing.Size(32, 12);
            this.label_r2Ajk.TabIndex = 41;
            this.label_r2Ajk.Text = "r2Ajk";
            // 
            // label_zAjk
            // 
            this.label_zAjk.AutoSize = true;
            this.label_zAjk.Location = new System.Drawing.Point(29, 47);
            this.label_zAjk.Name = "label_zAjk";
            this.label_zAjk.Size = new System.Drawing.Size(27, 12);
            this.label_zAjk.TabIndex = 42;
            this.label_zAjk.Text = "zAjk";
            // 
            // label_tDjk
            // 
            this.label_tDjk.AutoSize = true;
            this.label_tDjk.Location = new System.Drawing.Point(102, 46);
            this.label_tDjk.Name = "label_tDjk";
            this.label_tDjk.Size = new System.Drawing.Size(25, 12);
            this.label_tDjk.TabIndex = 43;
            this.label_tDjk.Text = "tDjk";
            // 
            // label_r1Djk
            // 
            this.label_r1Djk.AutoSize = true;
            this.label_r1Djk.Location = new System.Drawing.Point(100, 46);
            this.label_r1Djk.Name = "label_r1Djk";
            this.label_r1Djk.Size = new System.Drawing.Size(32, 12);
            this.label_r1Djk.TabIndex = 44;
            this.label_r1Djk.Text = "r1Djk";
            // 
            // label_r2Djk
            // 
            this.label_r2Djk.AutoSize = true;
            this.label_r2Djk.Location = new System.Drawing.Point(100, 46);
            this.label_r2Djk.Name = "label_r2Djk";
            this.label_r2Djk.Size = new System.Drawing.Size(32, 12);
            this.label_r2Djk.TabIndex = 45;
            this.label_r2Djk.Text = "r2Djk";
            // 
            // label_zDjk
            // 
            this.label_zDjk.AutoSize = true;
            this.label_zDjk.Location = new System.Drawing.Point(100, 46);
            this.label_zDjk.Name = "label_zDjk";
            this.label_zDjk.Size = new System.Drawing.Size(27, 12);
            this.label_zDjk.TabIndex = 46;
            this.label_zDjk.Text = "zDjk";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 430);
            this.Controls.Add(this.groupBox_spdSetting);
            this.Controls.Add(this.groupBox_axesStatus);
            this.Controls.Add(this.groupBox_systemControl);
            this.Controls.Add(this.groupBox_systemStatus);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.groupBox_moveMent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.comboBox_PortSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "MilaraRobot";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_moveMent.ResumeLayout(false);
            this.groupBox_moveMent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r2Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r1Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tPosition)).EndInit();
            this.groupBox_systemStatus.ResumeLayout(false);
            this.groupBox_systemStatus.PerformLayout();
            this.groupBox_systemControl.ResumeLayout(false);
            this.groupBox_axesStatus.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_spdSetting.ResumeLayout(false);
            this.groupBox_spdSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r2Spd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r1Spd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tSpd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_PortSelect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ConnectStatus;
        private System.Windows.Forms.GroupBox groupBox_moveMent;
        private System.Windows.Forms.Button button_zAction;
        private System.Windows.Forms.Button button_r2Action;
        private System.Windows.Forms.Button button_r1Action;
        private System.Windows.Forms.Button button_tAction;
        private System.Windows.Forms.NumericUpDown numericUpDown_zPosition;
        private System.Windows.Forms.NumericUpDown numericUpDown_r2Position;
        private System.Windows.Forms.NumericUpDown numericUpDown_r1Position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_tPosition;
        private System.ComponentModel.BackgroundWorker bkWorker_cpo;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.GroupBox groupBox_systemStatus;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_vacuumSwitch;
        private System.Windows.Forms.Button btn_servoSwitch;
        private System.Windows.Forms.Button btn_powerSwitch;
        private System.Windows.Forms.GroupBox groupBox_systemControl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_PowerStatus;
        private System.Windows.Forms.Button button_resetRobot;
        private System.Windows.Forms.GroupBox groupBox_axesStatus;
        private System.Windows.Forms.Label label_r2Cpo;
        private System.Windows.Forms.Label label_zCpo;
        private System.Windows.Forms.Label label_r1Cpo;
        private System.Windows.Forms.Label label_tCpo;
        private System.Windows.Forms.GroupBox groupBox_spdSetting;
        private System.Windows.Forms.NumericUpDown numericUpDown_zSpd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numericUpDown_r2Spd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numericUpDown_r1Spd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numericUpDown_tSpd;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button_zParameterSet;
        private System.Windows.Forms.Button button_r2ParameterSet;
        private System.Windows.Forms.Button button_r1ParameterSet;
        private System.Windows.Forms.Button button_rmp;
        private System.Windows.Forms.Button button_smp;
        private System.Windows.Forms.ComboBox comboBox_axisParameter;
        private System.Windows.Forms.Button button_tParameterSet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label_tSpd;
        private System.Windows.Forms.Label label_r1Spd;
        private System.Windows.Forms.Label label_r2Spd;
        private System.Windows.Forms.Label label_zSpd;
        private System.Windows.Forms.Label label_tAcl;
        private System.Windows.Forms.Label label_r1Acl;
        private System.Windows.Forms.Label label_r2Acl;
        private System.Windows.Forms.Label label_zAcl;
        private System.Windows.Forms.Label label_tDCL;
        private System.Windows.Forms.Label label_r1DCL;
        private System.Windows.Forms.Label label_r2DCL;
        private System.Windows.Forms.Label label_zDCL;
        private System.Windows.Forms.Label label_tAjk;
        private System.Windows.Forms.Label label_r1Ajk;
        private System.Windows.Forms.Label label_r2Ajk;
        private System.Windows.Forms.Label label_zAjk;
        private System.Windows.Forms.Label label_tDjk;
        private System.Windows.Forms.Label label_r1Djk;
        private System.Windows.Forms.Label label_r2Djk;
        private System.Windows.Forms.Label label_zDjk;
    }
}

