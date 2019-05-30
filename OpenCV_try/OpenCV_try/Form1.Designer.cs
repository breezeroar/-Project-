namespace OpenCV_try
{
    partial class OpenCV_Test
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
            this.button_loadimg = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_original = new System.Windows.Forms.Button();
            this.button_gray = new System.Windows.Forms.Button();
            this.button_threshold = new System.Windows.Forms.Button();
            this.button_erode = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_loadimg
            // 
            this.button_loadimg.Location = new System.Drawing.Point(13, 10);
            this.button_loadimg.Name = "button_loadimg";
            this.button_loadimg.Size = new System.Drawing.Size(85, 26);
            this.button_loadimg.TabIndex = 0;
            this.button_loadimg.Text = "Load Image";
            this.button_loadimg.UseVisualStyleBackColor = true;
            this.button_loadimg.Click += new System.EventHandler(this.button_loadimg_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Enabled = false;
            this.textBox_path.Location = new System.Drawing.Point(104, 10);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(384, 25);
            this.textBox_path.TabIndex = 1;
            this.textBox_path.Text = "Select a file..";
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // button_original
            // 
            this.button_original.Location = new System.Drawing.Point(13, 52);
            this.button_original.Name = "button_original";
            this.button_original.Size = new System.Drawing.Size(85, 23);
            this.button_original.TabIndex = 3;
            this.button_original.Text = "Original";
            this.button_original.UseVisualStyleBackColor = true;
            this.button_original.Click += new System.EventHandler(this.button_original_Click);
            // 
            // button_gray
            // 
            this.button_gray.Location = new System.Drawing.Point(195, 52);
            this.button_gray.Name = "button_gray";
            this.button_gray.Size = new System.Drawing.Size(85, 23);
            this.button_gray.TabIndex = 4;
            this.button_gray.Text = "Gray";
            this.button_gray.UseVisualStyleBackColor = true;
            this.button_gray.Click += new System.EventHandler(this.button_gray_Click);
            // 
            // button_threshold
            // 
            this.button_threshold.Location = new System.Drawing.Point(286, 52);
            this.button_threshold.Name = "button_threshold";
            this.button_threshold.Size = new System.Drawing.Size(85, 23);
            this.button_threshold.TabIndex = 5;
            this.button_threshold.Text = "Threshold";
            this.button_threshold.UseVisualStyleBackColor = true;
            this.button_threshold.Click += new System.EventHandler(this.button_threshold_Click);
            // 
            // button_erode
            // 
            this.button_erode.Location = new System.Drawing.Point(377, 52);
            this.button_erode.Name = "button_erode";
            this.button_erode.Size = new System.Drawing.Size(85, 23);
            this.button_erode.TabIndex = 6;
            this.button_erode.Text = "Erod";
            this.button_erode.UseVisualStyleBackColor = true;
            this.button_erode.Click += new System.EventHandler(this.button_erode_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(104, 52);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(85, 23);
            this.button_color.TabIndex = 7;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(508, 10);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(296, 56);
            this.trackBar1.TabIndex = 9;
            // 
            // OpenCV_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 581);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.button_erode);
            this.Controls.Add(this.button_threshold);
            this.Controls.Add(this.button_gray);
            this.Controls.Add(this.button_original);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_loadimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OpenCV_Test";
            this.Text = "OpenCVTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_loadimg;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_original;
        private System.Windows.Forms.Button button_gray;
        private System.Windows.Forms.Button button_threshold;
        private System.Windows.Forms.Button button_erode;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

