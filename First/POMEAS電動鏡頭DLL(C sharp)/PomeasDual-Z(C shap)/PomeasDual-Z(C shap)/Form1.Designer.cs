namespace PomeasDual_Z_C_shap_
{
    partial class Pomeas
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mComSelectcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mComSelectcomboBox
            // 
            this.mComSelectcomboBox.FormattingEnabled = true;
            this.mComSelectcomboBox.Items.AddRange(new object[] {
            "Com 1",
            "Com 2",
            "Com 3",
            "Com 4",
            "Com 5"});
            this.mComSelectcomboBox.Location = new System.Drawing.Point(14, 22);
            this.mComSelectcomboBox.Name = "mComSelectcomboBox";
            this.mComSelectcomboBox.Size = new System.Drawing.Size(121, 20);
            this.mComSelectcomboBox.TabIndex = 0;
            this.mComSelectcomboBox.SelectedIndexChanged += new System.EventHandler(this.mComSelectcomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mComSelectcomboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口号";
            // 
            // Pomeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 341);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pomeas";
            this.Text = "Pomeas";
            this.Load += new System.EventHandler(this.Pomeas_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pomeas_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mComSelectcomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

