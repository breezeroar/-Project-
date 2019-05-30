namespace HPSC_1005_4_LS
{
    partial class BrightnessChange
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
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.btn_con = new System.Windows.Forms.Button();
            this.groupBox_brightch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_L4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_L3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_L2 = new System.Windows.Forms.NumericUpDown();
            this.btn_brichg = new System.Windows.Forms.Button();
            this.checkBox_L4 = new System.Windows.Forms.CheckBox();
            this.numericUpDown_L1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_L1 = new System.Windows.Forms.CheckBox();
            this.checkBox_L3 = new System.Windows.Forms.CheckBox();
            this.checkBox_L2 = new System.Windows.Forms.CheckBox();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_id = new System.Windows.Forms.GroupBox();
            this.btn_idresel = new System.Windows.Forms.Button();
            this.btn_idsec = new System.Windows.Forms.Button();
            this.btn_chgid = new System.Windows.Forms.Button();
            this.comboBox_idchg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_curid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_cubri = new System.Windows.Forms.GroupBox();
            this.label1_L4b = new System.Windows.Forms.Label();
            this.label1_L3b = new System.Windows.Forms.Label();
            this.label1_L2b = new System.Windows.Forms.Label();
            this.label1_L1b = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bkWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox_brightch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L1)).BeginInit();
            this.groupBox_id.SuspendLayout();
            this.groupBox_cubri.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_com
            // 
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(7, 12);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(91, 23);
            this.comboBox_com.TabIndex = 0;
            // 
            // btn_con
            // 
            this.btn_con.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_con.Location = new System.Drawing.Point(7, 41);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(91, 24);
            this.btn_con.TabIndex = 1;
            this.btn_con.Text = "Connect";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // groupBox_brightch
            // 
            this.groupBox_brightch.Controls.Add(this.label2);
            this.groupBox_brightch.Controls.Add(this.numericUpDown_L4);
            this.groupBox_brightch.Controls.Add(this.label1);
            this.groupBox_brightch.Controls.Add(this.numericUpDown_L3);
            this.groupBox_brightch.Controls.Add(this.numericUpDown_L2);
            this.groupBox_brightch.Controls.Add(this.btn_brichg);
            this.groupBox_brightch.Controls.Add(this.checkBox_L4);
            this.groupBox_brightch.Controls.Add(this.numericUpDown_L1);
            this.groupBox_brightch.Controls.Add(this.checkBox_L1);
            this.groupBox_brightch.Controls.Add(this.checkBox_L3);
            this.groupBox_brightch.Controls.Add(this.checkBox_L2);
            this.groupBox_brightch.Enabled = false;
            this.groupBox_brightch.Location = new System.Drawing.Point(12, 140);
            this.groupBox_brightch.Name = "groupBox_brightch";
            this.groupBox_brightch.Size = new System.Drawing.Size(201, 216);
            this.groupBox_brightch.TabIndex = 2;
            this.groupBox_brightch.TabStop = false;
            this.groupBox_brightch.Text = "BrightnessChange";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Passway";
            // 
            // numericUpDown_L4
            // 
            this.numericUpDown_L4.Location = new System.Drawing.Point(106, 147);
            this.numericUpDown_L4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_L4.Name = "numericUpDown_L4";
            this.numericUpDown_L4.Size = new System.Drawing.Size(80, 25);
            this.numericUpDown_L4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(103, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brightness";
            // 
            // numericUpDown_L3
            // 
            this.numericUpDown_L3.Location = new System.Drawing.Point(106, 116);
            this.numericUpDown_L3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_L3.Name = "numericUpDown_L3";
            this.numericUpDown_L3.Size = new System.Drawing.Size(80, 25);
            this.numericUpDown_L3.TabIndex = 11;
            // 
            // numericUpDown_L2
            // 
            this.numericUpDown_L2.Location = new System.Drawing.Point(106, 84);
            this.numericUpDown_L2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_L2.Name = "numericUpDown_L2";
            this.numericUpDown_L2.Size = new System.Drawing.Size(80, 25);
            this.numericUpDown_L2.TabIndex = 10;
            // 
            // btn_brichg
            // 
            this.btn_brichg.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_brichg.Location = new System.Drawing.Point(35, 178);
            this.btn_brichg.Name = "btn_brichg";
            this.btn_brichg.Size = new System.Drawing.Size(151, 28);
            this.btn_brichg.TabIndex = 9;
            this.btn_brichg.Text = "Change";
            this.btn_brichg.UseVisualStyleBackColor = true;
            this.btn_brichg.Click += new System.EventHandler(this.btn_brichg_Click);
            // 
            // checkBox_L4
            // 
            this.checkBox_L4.AutoSize = true;
            this.checkBox_L4.Location = new System.Drawing.Point(35, 148);
            this.checkBox_L4.Name = "checkBox_L4";
            this.checkBox_L4.Size = new System.Drawing.Size(45, 19);
            this.checkBox_L4.TabIndex = 6;
            this.checkBox_L4.Text = "L4";
            this.checkBox_L4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_L1
            // 
            this.numericUpDown_L1.Location = new System.Drawing.Point(106, 54);
            this.numericUpDown_L1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_L1.Name = "numericUpDown_L1";
            this.numericUpDown_L1.Size = new System.Drawing.Size(80, 25);
            this.numericUpDown_L1.TabIndex = 8;
            // 
            // checkBox_L1
            // 
            this.checkBox_L1.AutoSize = true;
            this.checkBox_L1.Location = new System.Drawing.Point(35, 55);
            this.checkBox_L1.Name = "checkBox_L1";
            this.checkBox_L1.Size = new System.Drawing.Size(45, 19);
            this.checkBox_L1.TabIndex = 3;
            this.checkBox_L1.Text = "L1";
            this.checkBox_L1.UseVisualStyleBackColor = true;
            // 
            // checkBox_L3
            // 
            this.checkBox_L3.AutoSize = true;
            this.checkBox_L3.Location = new System.Drawing.Point(35, 117);
            this.checkBox_L3.Name = "checkBox_L3";
            this.checkBox_L3.Size = new System.Drawing.Size(45, 19);
            this.checkBox_L3.TabIndex = 5;
            this.checkBox_L3.Text = "L3";
            this.checkBox_L3.UseVisualStyleBackColor = true;
            // 
            // checkBox_L2
            // 
            this.checkBox_L2.AutoSize = true;
            this.checkBox_L2.Location = new System.Drawing.Point(35, 86);
            this.checkBox_L2.Name = "checkBox_L2";
            this.checkBox_L2.Size = new System.Drawing.Size(45, 19);
            this.checkBox_L2.TabIndex = 4;
            this.checkBox_L2.Text = "L2";
            this.checkBox_L2.UseVisualStyleBackColor = true;
            // 
            // comboBox_id
            // 
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(168, 18);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(58, 23);
            this.comboBox_id.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(48, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select device ID:";
            // 
            // groupBox_id
            // 
            this.groupBox_id.Controls.Add(this.btn_idresel);
            this.groupBox_id.Controls.Add(this.btn_idsec);
            this.groupBox_id.Controls.Add(this.btn_chgid);
            this.groupBox_id.Controls.Add(this.comboBox_idchg);
            this.groupBox_id.Controls.Add(this.label6);
            this.groupBox_id.Controls.Add(this.label3);
            this.groupBox_id.Controls.Add(this.comboBox_id);
            this.groupBox_id.Enabled = false;
            this.groupBox_id.Location = new System.Drawing.Point(104, 12);
            this.groupBox_id.Name = "groupBox_id";
            this.groupBox_id.Size = new System.Drawing.Size(258, 122);
            this.groupBox_id.TabIndex = 15;
            this.groupBox_id.TabStop = false;
            this.groupBox_id.Text = "ID Control";
            // 
            // btn_idresel
            // 
            this.btn_idresel.Enabled = false;
            this.btn_idresel.Location = new System.Drawing.Point(144, 50);
            this.btn_idresel.Name = "btn_idresel";
            this.btn_idresel.Size = new System.Drawing.Size(72, 24);
            this.btn_idresel.TabIndex = 20;
            this.btn_idresel.Text = "Reselect";
            this.btn_idresel.UseVisualStyleBackColor = true;
            this.btn_idresel.Click += new System.EventHandler(this.btn_idresel_Click);
            // 
            // btn_idsec
            // 
            this.btn_idsec.Location = new System.Drawing.Point(51, 50);
            this.btn_idsec.Name = "btn_idsec";
            this.btn_idsec.Size = new System.Drawing.Size(72, 24);
            this.btn_idsec.TabIndex = 19;
            this.btn_idsec.Text = "Select";
            this.btn_idsec.UseVisualStyleBackColor = true;
            this.btn_idsec.Click += new System.EventHandler(this.btn_idsec_Click);
            // 
            // btn_chgid
            // 
            this.btn_chgid.Location = new System.Drawing.Point(168, 85);
            this.btn_chgid.Name = "btn_chgid";
            this.btn_chgid.Size = new System.Drawing.Size(72, 24);
            this.btn_chgid.TabIndex = 18;
            this.btn_chgid.Text = "Change";
            this.btn_chgid.UseVisualStyleBackColor = true;
            this.btn_chgid.Click += new System.EventHandler(this.btn_chgid_Click);
            // 
            // comboBox_idchg
            // 
            this.comboBox_idchg.FormattingEnabled = true;
            this.comboBox_idchg.Location = new System.Drawing.Point(104, 85);
            this.comboBox_idchg.Name = "comboBox_idchg";
            this.comboBox_idchg.Size = new System.Drawing.Size(58, 23);
            this.comboBox_idchg.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(11, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Change ID to:";
            // 
            // label_curid
            // 
            this.label_curid.AutoSize = true;
            this.label_curid.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_curid.Location = new System.Drawing.Point(38, 91);
            this.label_curid.Name = "label_curid";
            this.label_curid.Size = new System.Drawing.Size(34, 24);
            this.label_curid.TabIndex = 16;
            this.label_curid.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current ID:";
            // 
            // groupBox_cubri
            // 
            this.groupBox_cubri.Controls.Add(this.label1_L4b);
            this.groupBox_cubri.Controls.Add(this.label1_L3b);
            this.groupBox_cubri.Controls.Add(this.label1_L2b);
            this.groupBox_cubri.Controls.Add(this.label1_L1b);
            this.groupBox_cubri.Controls.Add(this.label10);
            this.groupBox_cubri.Controls.Add(this.label9);
            this.groupBox_cubri.Controls.Add(this.label8);
            this.groupBox_cubri.Controls.Add(this.label7);
            this.groupBox_cubri.Location = new System.Drawing.Point(222, 140);
            this.groupBox_cubri.Name = "groupBox_cubri";
            this.groupBox_cubri.Size = new System.Drawing.Size(139, 216);
            this.groupBox_cubri.TabIndex = 16;
            this.groupBox_cubri.TabStop = false;
            this.groupBox_cubri.Text = "CurrentBrightness";
            // 
            // label1_L4b
            // 
            this.label1_L4b.AutoSize = true;
            this.label1_L4b.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1_L4b.Location = new System.Drawing.Point(74, 170);
            this.label1_L4b.Name = "label1_L4b";
            this.label1_L4b.Size = new System.Drawing.Size(48, 24);
            this.label1_L4b.TabIndex = 24;
            this.label1_L4b.Text = "N/A";
            // 
            // label1_L3b
            // 
            this.label1_L3b.AutoSize = true;
            this.label1_L3b.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1_L3b.Location = new System.Drawing.Point(74, 125);
            this.label1_L3b.Name = "label1_L3b";
            this.label1_L3b.Size = new System.Drawing.Size(48, 24);
            this.label1_L3b.TabIndex = 23;
            this.label1_L3b.Text = "N/A";
            // 
            // label1_L2b
            // 
            this.label1_L2b.AutoSize = true;
            this.label1_L2b.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1_L2b.Location = new System.Drawing.Point(74, 80);
            this.label1_L2b.Name = "label1_L2b";
            this.label1_L2b.Size = new System.Drawing.Size(48, 24);
            this.label1_L2b.TabIndex = 22;
            this.label1_L2b.Text = "N/A";
            // 
            // label1_L1b
            // 
            this.label1_L1b.AutoSize = true;
            this.label1_L1b.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1_L1b.Location = new System.Drawing.Point(74, 35);
            this.label1_L1b.Name = "label1_L1b";
            this.label1_L1b.Size = new System.Drawing.Size(48, 24);
            this.label1_L1b.TabIndex = 21;
            this.label1_L1b.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(20, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "L4:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(20, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "L3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(20, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "L2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "L1:";
            // 
            // bkWorker
            // 
            this.bkWorker.WorkerReportsProgress = true;
            this.bkWorker.WorkerSupportsCancellation = true;
            this.bkWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorker_DoWork);
            this.bkWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkWorker_ProgressChanged);
            // 
            // BrightnessChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 368);
            this.Controls.Add(this.groupBox_cubri);
            this.Controls.Add(this.groupBox_id);
            this.Controls.Add(this.groupBox_brightch);
            this.Controls.Add(this.label_curid);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.comboBox_com);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BrightnessChange";
            this.Text = "BrightnessChange";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrightnessChange_FormClosing);
            this.groupBox_brightch.ResumeLayout(false);
            this.groupBox_brightch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_L1)).EndInit();
            this.groupBox_id.ResumeLayout(false);
            this.groupBox_id.PerformLayout();
            this.groupBox_cubri.ResumeLayout(false);
            this.groupBox_cubri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.GroupBox groupBox_brightch;
        private System.Windows.Forms.CheckBox checkBox_L4;
        private System.Windows.Forms.CheckBox checkBox_L1;
        private System.Windows.Forms.CheckBox checkBox_L3;
        private System.Windows.Forms.CheckBox checkBox_L2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_brichg;
        private System.Windows.Forms.NumericUpDown numericUpDown_L1;
        private System.Windows.Forms.NumericUpDown numericUpDown_L4;
        private System.Windows.Forms.NumericUpDown numericUpDown_L3;
        private System.Windows.Forms.NumericUpDown numericUpDown_L2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_id;
        private System.Windows.Forms.Button btn_chgid;
        private System.Windows.Forms.ComboBox comboBox_idchg;
        private System.Windows.Forms.Label label_curid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_cubri;
        private System.Windows.Forms.Label label1_L4b;
        private System.Windows.Forms.Label label1_L3b;
        private System.Windows.Forms.Label label1_L2b;
        private System.Windows.Forms.Label label1_L1b;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_idsec;
        private System.ComponentModel.BackgroundWorker bkWorker;
        private System.Windows.Forms.Button btn_idresel;
    }
}

