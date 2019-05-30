namespace ChangeCamMagnification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.select_com_box = new System.Windows.Forms.ComboBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.groupBox_dst = new System.Windows.Forms.GroupBox();
            this.TBox_dst = new System.Windows.Forms.TextBox();
            this.btn_moveto = new System.Windows.Forms.Button();
            this.groupBox_auto = new System.Windows.Forms.GroupBox();
            this.label_filename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_loadxml = new System.Windows.Forms.Button();
            this.btn_savexml = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_meautomove = new System.Windows.Forms.Button();
            this.label_pos = new System.Windows.Forms.Label();
            this.label_locate = new System.Windows.Forms.Label();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.btn_memove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_locate = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslb_max = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslb_pos = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_select.SuspendLayout();
            this.groupBox_dst.SuspendLayout();
            this.groupBox_auto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_select
            // 
            this.groupBox_select.Controls.Add(this.btn_disconnect);
            this.groupBox_select.Controls.Add(this.btn_connect);
            this.groupBox_select.Controls.Add(this.select_com_box);
            this.groupBox_select.Location = new System.Drawing.Point(21, 22);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.Size = new System.Drawing.Size(263, 57);
            this.groupBox_select.TabIndex = 1;
            this.groupBox_select.TabStop = false;
            this.groupBox_select.Text = "Select COM Port";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Location = new System.Drawing.Point(170, 24);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(82, 23);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "Discnnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(82, 24);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(82, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // select_com_box
            // 
            this.select_com_box.FormattingEnabled = true;
            this.select_com_box.Location = new System.Drawing.Point(5, 24);
            this.select_com_box.Name = "select_com_box";
            this.select_com_box.Size = new System.Drawing.Size(71, 23);
            this.select_com_box.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(6, 23);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 23);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // groupBox_dst
            // 
            this.groupBox_dst.Controls.Add(this.btn_home);
            this.groupBox_dst.Controls.Add(this.TBox_dst);
            this.groupBox_dst.Controls.Add(this.btn_moveto);
            this.groupBox_dst.Enabled = false;
            this.groupBox_dst.Location = new System.Drawing.Point(290, 23);
            this.groupBox_dst.Name = "groupBox_dst";
            this.groupBox_dst.Size = new System.Drawing.Size(268, 56);
            this.groupBox_dst.TabIndex = 8;
            this.groupBox_dst.TabStop = false;
            this.groupBox_dst.Text = "Move To Destination";
            // 
            // TBox_dst
            // 
            this.TBox_dst.Location = new System.Drawing.Point(169, 21);
            this.TBox_dst.Name = "TBox_dst";
            this.TBox_dst.Size = new System.Drawing.Size(88, 25);
            this.TBox_dst.TabIndex = 5;
            this.TBox_dst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_moveto
            // 
            this.btn_moveto.Location = new System.Drawing.Point(82, 23);
            this.btn_moveto.Name = "btn_moveto";
            this.btn_moveto.Size = new System.Drawing.Size(81, 23);
            this.btn_moveto.TabIndex = 4;
            this.btn_moveto.Text = "MoveTo:";
            this.btn_moveto.UseVisualStyleBackColor = true;
            this.btn_moveto.Click += new System.EventHandler(this.btn_moveto_Click);
            // 
            // groupBox_auto
            // 
            this.groupBox_auto.Controls.Add(this.label_filename);
            this.groupBox_auto.Controls.Add(this.label3);
            this.groupBox_auto.Controls.Add(this.btn_loadxml);
            this.groupBox_auto.Controls.Add(this.btn_savexml);
            this.groupBox_auto.Controls.Add(this.btn_clear);
            this.groupBox_auto.Controls.Add(this.btn_meautomove);
            this.groupBox_auto.Controls.Add(this.label_pos);
            this.groupBox_auto.Controls.Add(this.label_locate);
            this.groupBox_auto.Controls.Add(this.textBox_save);
            this.groupBox_auto.Controls.Add(this.btn_memove);
            this.groupBox_auto.Controls.Add(this.label2);
            this.groupBox_auto.Controls.Add(this.label1);
            this.groupBox_auto.Controls.Add(this.comboBox_locate);
            this.groupBox_auto.Controls.Add(this.btn_save);
            this.groupBox_auto.Enabled = false;
            this.groupBox_auto.Location = new System.Drawing.Point(21, 85);
            this.groupBox_auto.Name = "groupBox_auto";
            this.groupBox_auto.Size = new System.Drawing.Size(537, 163);
            this.groupBox_auto.TabIndex = 10;
            this.groupBox_auto.TabStop = false;
            this.groupBox_auto.Text = "Move To Saved Position";
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_filename.Location = new System.Drawing.Point(102, 134);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(62, 17);
            this.label_filename.TabIndex = 14;
            this.label_filename.Text = "filename";
            this.label_filename.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current file:";
            // 
            // btn_loadxml
            // 
            this.btn_loadxml.Location = new System.Drawing.Point(127, 98);
            this.btn_loadxml.Name = "btn_loadxml";
            this.btn_loadxml.Size = new System.Drawing.Size(106, 23);
            this.btn_loadxml.TabIndex = 12;
            this.btn_loadxml.Text = "Load";
            this.btn_loadxml.UseVisualStyleBackColor = true;
            this.btn_loadxml.Click += new System.EventHandler(this.btn_loadxml_Click);
            // 
            // btn_savexml
            // 
            this.btn_savexml.Location = new System.Drawing.Point(15, 98);
            this.btn_savexml.Name = "btn_savexml";
            this.btn_savexml.Size = new System.Drawing.Size(106, 23);
            this.btn_savexml.TabIndex = 11;
            this.btn_savexml.Text = "Save as...";
            this.btn_savexml.UseVisualStyleBackColor = true;
            this.btn_savexml.Click += new System.EventHandler(this.btn_savexml_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(127, 62);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 27);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_meautomove
            // 
            this.btn_meautomove.Location = new System.Drawing.Point(403, 24);
            this.btn_meautomove.Name = "btn_meautomove";
            this.btn_meautomove.Size = new System.Drawing.Size(98, 23);
            this.btn_meautomove.TabIndex = 9;
            this.btn_meautomove.Text = "AutoMove";
            this.btn_meautomove.UseVisualStyleBackColor = true;
            this.btn_meautomove.Click += new System.EventHandler(this.btn_meautomove_Click);
            // 
            // label_pos
            // 
            this.label_pos.AutoSize = true;
            this.label_pos.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_pos.Location = new System.Drawing.Point(358, 98);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(67, 20);
            this.label_pos.TabIndex = 8;
            this.label_pos.Text = "position";
            this.label_pos.Visible = false;
            // 
            // label_locate
            // 
            this.label_locate.AutoSize = true;
            this.label_locate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_locate.Location = new System.Drawing.Point(399, 65);
            this.label_locate.Name = "label_locate";
            this.label_locate.Size = new System.Drawing.Size(52, 20);
            this.label_locate.TabIndex = 7;
            this.label_locate.Text = "locate";
            this.label_locate.Visible = false;
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(15, 24);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.Size = new System.Drawing.Size(106, 25);
            this.textBox_save.TabIndex = 6;
            // 
            // btn_memove
            // 
            this.btn_memove.Location = new System.Drawing.Point(291, 24);
            this.btn_memove.Name = "btn_memove";
            this.btn_memove.Size = new System.Drawing.Size(98, 23);
            this.btn_memove.TabIndex = 5;
            this.btn_memove.Text = "SingleMove";
            this.btn_memove.UseVisualStyleBackColor = true;
            this.btn_memove.Click += new System.EventHandler(this.btn_memove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(279, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(279, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Load location:";
            // 
            // comboBox_locate
            // 
            this.comboBox_locate.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_locate.FormattingEnabled = true;
            this.comboBox_locate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_locate.Location = new System.Drawing.Point(15, 62);
            this.comboBox_locate.Name = "comboBox_locate";
            this.comboBox_locate.Size = new System.Drawing.Size(106, 23);
            this.comboBox_locate.TabIndex = 2;
            this.comboBox_locate.SelectedIndexChanged += new System.EventHandler(this.comboBox_locate_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(127, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 26);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tslb_max,
            this.toolStripStatusLabel1,
            this.tslb_status,
            this.toolStripStatusLabel3,
            this.tslb_pos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 24);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(90, 19);
            this.toolStripStatusLabel2.Text = "MaxLength:";
            // 
            // tslb_max
            // 
            this.tslb_max.Name = "tslb_max";
            this.tslb_max.Size = new System.Drawing.Size(59, 19);
            this.tslb_max.Text = "maxlen";
            this.tslb_max.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 19);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // tslb_status
            // 
            this.tslb_status.Name = "tslb_status";
            this.tslb_status.Size = new System.Drawing.Size(50, 19);
            this.tslb_status.Text = "status";
            this.tslb_status.Visible = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabel3.Text = "Position:";
            // 
            // tslb_pos
            // 
            this.tslb_pos.Name = "tslb_pos";
            this.tslb_pos.Size = new System.Drawing.Size(65, 19);
            this.tslb_pos.Text = "position";
            this.tslb_pos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 283);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_auto);
            this.Controls.Add(this.groupBox_dst);
            this.Controls.Add(this.groupBox_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ChangePomeasMagnification";
            this.groupBox_select.ResumeLayout(false);
            this.groupBox_dst.ResumeLayout(false);
            this.groupBox_dst.PerformLayout();
            this.groupBox_auto.ResumeLayout(false);
            this.groupBox_auto.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_select;
        private System.Windows.Forms.ComboBox select_com_box;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.GroupBox groupBox_dst;
        private System.Windows.Forms.TextBox TBox_dst;
        private System.Windows.Forms.Button btn_moveto;
        private System.Windows.Forms.GroupBox groupBox_auto;
        private System.Windows.Forms.Button btn_memove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_locate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Label label_locate;
        private System.Windows.Forms.Button btn_meautomove;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_loadxml;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_savexml;
        private System.Windows.Forms.SaveFileDialog file;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslb_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslb_pos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslb_max;
    }
}

