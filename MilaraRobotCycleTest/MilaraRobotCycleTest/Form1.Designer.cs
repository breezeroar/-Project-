namespace MilaraRobotCycleTest
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.comboBox_PortSelect = new System.Windows.Forms.ComboBox();
            this.bkWorker_action = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox_cmdInput = new System.Windows.Forms.RichTextBox();
            this.richTextBox_replayFromRobot = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_loadTxt = new System.Windows.Forms.Button();
            this.button_testAction = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(84, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(66, 23);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // comboBox_PortSelect
            // 
            this.comboBox_PortSelect.FormattingEnabled = true;
            this.comboBox_PortSelect.Location = new System.Drawing.Point(12, 12);
            this.comboBox_PortSelect.Name = "comboBox_PortSelect";
            this.comboBox_PortSelect.Size = new System.Drawing.Size(66, 20);
            this.comboBox_PortSelect.TabIndex = 2;
            // 
            // bkWorker_action
            // 
            this.bkWorker_action.WorkerReportsProgress = true;
            this.bkWorker_action.WorkerSupportsCancellation = true;
            this.bkWorker_action.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorker_action_DoWork);
            this.bkWorker_action.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkWorker_action_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_count});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(419, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Count:";
            // 
            // toolStripStatusLabel_count
            // 
            this.toolStripStatusLabel_count.Name = "toolStripStatusLabel_count";
            this.toolStripStatusLabel_count.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel_count.Text = "COUNTS";
            // 
            // richTextBox_cmdInput
            // 
            this.richTextBox_cmdInput.Location = new System.Drawing.Point(12, 61);
            this.richTextBox_cmdInput.Name = "richTextBox_cmdInput";
            this.richTextBox_cmdInput.Size = new System.Drawing.Size(196, 370);
            this.richTextBox_cmdInput.TabIndex = 5;
            this.richTextBox_cmdInput.Text = "";
            // 
            // richTextBox_replayFromRobot
            // 
            this.richTextBox_replayFromRobot.Location = new System.Drawing.Point(214, 61);
            this.richTextBox_replayFromRobot.Name = "richTextBox_replayFromRobot";
            this.richTextBox_replayFromRobot.Size = new System.Drawing.Size(196, 370);
            this.richTextBox_replayFromRobot.TabIndex = 6;
            this.richTextBox_replayFromRobot.Text = "";
            this.richTextBox_replayFromRobot.TextChanged += new System.EventHandler(this.richTextBox_replayFromRobot_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Action command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(211, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reply from robot:";
            // 
            // button_loadTxt
            // 
            this.button_loadTxt.Location = new System.Drawing.Point(12, 437);
            this.button_loadTxt.Name = "button_loadTxt";
            this.button_loadTxt.Size = new System.Drawing.Size(116, 23);
            this.button_loadTxt.TabIndex = 9;
            this.button_loadTxt.Text = "Load CMD from file";
            this.button_loadTxt.UseVisualStyleBackColor = true;
            this.button_loadTxt.Click += new System.EventHandler(this.button_loadTxt_Click);
            // 
            // button_testAction
            // 
            this.button_testAction.Location = new System.Drawing.Point(214, 437);
            this.button_testAction.Name = "button_testAction";
            this.button_testAction.Size = new System.Drawing.Size(58, 23);
            this.button_testAction.TabIndex = 10;
            this.button_testAction.Text = "Action!";
            this.button_testAction.UseVisualStyleBackColor = true;
            this.button_testAction.Click += new System.EventHandler(this.button_testAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 504);
            this.Controls.Add(this.button_testAction);
            this.Controls.Add(this.button_loadTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_replayFromRobot);
            this.Controls.Add(this.richTextBox_cmdInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.comboBox_PortSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox comboBox_PortSelect;
        private System.ComponentModel.BackgroundWorker bkWorker_action;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_count;
        private System.Windows.Forms.RichTextBox richTextBox_cmdInput;
        private System.Windows.Forms.RichTextBox richTextBox_replayFromRobot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_loadTxt;
        private System.Windows.Forms.Button button_testAction;
    }
}

