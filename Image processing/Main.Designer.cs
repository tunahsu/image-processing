namespace Image_processing
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_origin = new System.Windows.Forms.Button();
            this.label_origin = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.button_resize = new System.Windows.Forms.Button();
            this.button_undo = new System.Windows.Forms.Button();
            this.button_grayscale = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button_negative = new System.Windows.Forms.Button();
            this.button_retro = new System.Windows.Forms.Button();
            this.button_median = new System.Windows.Forms.Button();
            this.button_mean = new System.Windows.Forms.Button();
            this.button_sobel = new System.Windows.Forms.Button();
            this.comboBox_laplacian = new System.Windows.Forms.ComboBox();
            this.button_laplacian = new System.Windows.Forms.Button();
            this.button_sharpen = new System.Windows.Forms.Button();
            this.button_histogramEqualization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(13, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(446, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 491);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(13, 11);
            this.button_open.Margin = new System.Windows.Forms.Padding(2);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(70, 36);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "Open File";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(179, 11);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(70, 36);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save File";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_origin
            // 
            this.button_origin.Location = new System.Drawing.Point(345, 11);
            this.button_origin.Margin = new System.Windows.Forms.Padding(2);
            this.button_origin.Name = "button_origin";
            this.button_origin.Size = new System.Drawing.Size(70, 36);
            this.button_origin.TabIndex = 4;
            this.button_origin.Text = "Origin";
            this.button_origin.UseVisualStyleBackColor = true;
            this.button_origin.Click += new System.EventHandler(this.button_origin_Click);
            // 
            // label_origin
            // 
            this.label_origin.Location = new System.Drawing.Point(329, 56);
            this.label_origin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_origin.Name = "label_origin";
            this.label_origin.Size = new System.Drawing.Size(86, 24);
            this.label_origin.TabIndex = 5;
            this.label_origin.Text = "0 X 0";
            this.label_origin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_result
            // 
            this.label_result.Location = new System.Drawing.Point(762, 56);
            this.label_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(86, 24);
            this.label_result.TabIndex = 6;
            this.label_result.Text = "0 X 0";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(494, 11);
            this.textBox_width.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(60, 22);
            this.textBox_width.TabIndex = 7;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(494, 47);
            this.textBox_height.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(60, 22);
            this.textBox_height.TabIndex = 8;
            // 
            // label_width
            // 
            this.label_width.Location = new System.Drawing.Point(444, 11);
            this.label_width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(46, 22);
            this.label_width.TabIndex = 9;
            this.label_width.Text = "Width";
            this.label_width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_height
            // 
            this.label_height.Location = new System.Drawing.Point(444, 47);
            this.label_height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(46, 22);
            this.label_height.TabIndex = 10;
            this.label_height.Text = "Height";
            this.label_height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_resize
            // 
            this.button_resize.Location = new System.Drawing.Point(641, 11);
            this.button_resize.Margin = new System.Windows.Forms.Padding(2);
            this.button_resize.Name = "button_resize";
            this.button_resize.Size = new System.Drawing.Size(70, 36);
            this.button_resize.TabIndex = 11;
            this.button_resize.Text = "Resize";
            this.button_resize.UseVisualStyleBackColor = true;
            this.button_resize.Click += new System.EventHandler(this.button_resize_Click);
            // 
            // button_undo
            // 
            this.button_undo.Location = new System.Drawing.Point(778, 11);
            this.button_undo.Margin = new System.Windows.Forms.Padding(2);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(70, 36);
            this.button_undo.TabIndex = 12;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // button_grayscale
            // 
            this.button_grayscale.Location = new System.Drawing.Point(881, 90);
            this.button_grayscale.Margin = new System.Windows.Forms.Padding(2);
            this.button_grayscale.Name = "button_grayscale";
            this.button_grayscale.Size = new System.Drawing.Size(62, 52);
            this.button_grayscale.TabIndex = 13;
            this.button_grayscale.Text = "Grayscale";
            this.button_grayscale.UseVisualStyleBackColor = true;
            this.button_grayscale.Click += new System.EventHandler(this.button_grayscale_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(13, 594);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Location = new System.Drawing.Point(150, 594);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Location = new System.Drawing.Point(287, 595);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox6.Location = new System.Drawing.Point(446, 595);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 128);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox7.Location = new System.Drawing.Point(583, 594);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 128);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox8.Location = new System.Drawing.Point(720, 595);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 128);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // button_negative
            // 
            this.button_negative.Location = new System.Drawing.Point(995, 90);
            this.button_negative.Margin = new System.Windows.Forms.Padding(2);
            this.button_negative.Name = "button_negative";
            this.button_negative.Size = new System.Drawing.Size(62, 52);
            this.button_negative.TabIndex = 21;
            this.button_negative.Text = "Negative";
            this.button_negative.UseVisualStyleBackColor = true;
            this.button_negative.Click += new System.EventHandler(this.button_negative_Click);
            // 
            // button_retro
            // 
            this.button_retro.Location = new System.Drawing.Point(1109, 90);
            this.button_retro.Margin = new System.Windows.Forms.Padding(2);
            this.button_retro.Name = "button_retro";
            this.button_retro.Size = new System.Drawing.Size(62, 52);
            this.button_retro.TabIndex = 23;
            this.button_retro.Text = "Retro";
            this.button_retro.UseVisualStyleBackColor = true;
            this.button_retro.Click += new System.EventHandler(this.button_retro_Click);
            // 
            // button_median
            // 
            this.button_median.Location = new System.Drawing.Point(881, 201);
            this.button_median.Margin = new System.Windows.Forms.Padding(2);
            this.button_median.Name = "button_median";
            this.button_median.Size = new System.Drawing.Size(62, 52);
            this.button_median.TabIndex = 24;
            this.button_median.Text = "Median";
            this.button_median.UseVisualStyleBackColor = true;
            this.button_median.Click += new System.EventHandler(this.button_median_Click);
            // 
            // button_mean
            // 
            this.button_mean.Location = new System.Drawing.Point(995, 201);
            this.button_mean.Margin = new System.Windows.Forms.Padding(2);
            this.button_mean.Name = "button_mean";
            this.button_mean.Size = new System.Drawing.Size(62, 52);
            this.button_mean.TabIndex = 25;
            this.button_mean.Text = "Mean";
            this.button_mean.UseVisualStyleBackColor = true;
            this.button_mean.Click += new System.EventHandler(this.button_mean_Click);
            // 
            // button_sobel
            // 
            this.button_sobel.Location = new System.Drawing.Point(1109, 201);
            this.button_sobel.Margin = new System.Windows.Forms.Padding(2);
            this.button_sobel.Name = "button_sobel";
            this.button_sobel.Size = new System.Drawing.Size(62, 52);
            this.button_sobel.TabIndex = 27;
            this.button_sobel.Text = "Sobel";
            this.button_sobel.UseVisualStyleBackColor = true;
            this.button_sobel.Click += new System.EventHandler(this.button_sobel_Click);
            // 
            // comboBox_laplacian
            // 
            this.comboBox_laplacian.FormattingEnabled = true;
            this.comboBox_laplacian.Items.AddRange(new object[] {
            "Laplacian 1",
            "Laplacian 2",
            "Laplacian 3"});
            this.comboBox_laplacian.Location = new System.Drawing.Point(981, 341);
            this.comboBox_laplacian.Name = "comboBox_laplacian";
            this.comboBox_laplacian.Size = new System.Drawing.Size(108, 20);
            this.comboBox_laplacian.TabIndex = 28;
            this.comboBox_laplacian.Text = "Laplacian 1";
            // 
            // button_laplacian
            // 
            this.button_laplacian.Location = new System.Drawing.Point(881, 324);
            this.button_laplacian.Margin = new System.Windows.Forms.Padding(2);
            this.button_laplacian.Name = "button_laplacian";
            this.button_laplacian.Size = new System.Drawing.Size(62, 52);
            this.button_laplacian.TabIndex = 29;
            this.button_laplacian.Text = "Laplacian";
            this.button_laplacian.UseVisualStyleBackColor = true;
            this.button_laplacian.Click += new System.EventHandler(this.button_laplacian_Click);
            // 
            // button_sharpen
            // 
            this.button_sharpen.Location = new System.Drawing.Point(881, 437);
            this.button_sharpen.Margin = new System.Windows.Forms.Padding(2);
            this.button_sharpen.Name = "button_sharpen";
            this.button_sharpen.Size = new System.Drawing.Size(62, 52);
            this.button_sharpen.TabIndex = 30;
            this.button_sharpen.Text = "Sharpen";
            this.button_sharpen.UseVisualStyleBackColor = true;
            this.button_sharpen.Click += new System.EventHandler(this.button_sharpen_Click);
            // 
            // button_histogramEqualization
            // 
            this.button_histogramEqualization.Location = new System.Drawing.Point(995, 437);
            this.button_histogramEqualization.Margin = new System.Windows.Forms.Padding(2);
            this.button_histogramEqualization.Name = "button_histogramEqualization";
            this.button_histogramEqualization.Size = new System.Drawing.Size(62, 52);
            this.button_histogramEqualization.TabIndex = 31;
            this.button_histogramEqualization.Text = "H_E";
            this.button_histogramEqualization.UseVisualStyleBackColor = true;
            this.button_histogramEqualization.Click += new System.EventHandler(this.button_histogramEqualization_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 734);
            this.Controls.Add(this.button_histogramEqualization);
            this.Controls.Add(this.button_sharpen);
            this.Controls.Add(this.button_laplacian);
            this.Controls.Add(this.comboBox_laplacian);
            this.Controls.Add(this.button_sobel);
            this.Controls.Add(this.button_mean);
            this.Controls.Add(this.button_median);
            this.Controls.Add(this.button_retro);
            this.Controls.Add(this.button_negative);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button_grayscale);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.button_resize);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_origin);
            this.Controls.Add(this.button_origin);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_origin;
        private System.Windows.Forms.Label label_origin;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Button button_resize;
        private System.Windows.Forms.Button button_undo;
        private System.Windows.Forms.Button button_grayscale;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button_negative;
        private System.Windows.Forms.Button button_retro;
        private System.Windows.Forms.Button button_median;
        private System.Windows.Forms.Button button_mean;
        private System.Windows.Forms.Button button_sobel;
        private System.Windows.Forms.ComboBox comboBox_laplacian;
        private System.Windows.Forms.Button button_laplacian;
        private System.Windows.Forms.Button button_sharpen;
        private System.Windows.Forms.Button button_histogramEqualization;
    }
}

