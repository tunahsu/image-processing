namespace Image_processing
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(422, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 376);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(45, 23);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(93, 45);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "Open File";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(194, 23);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(93, 45);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save File";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_origin
            // 
            this.button_origin.Location = new System.Drawing.Point(815, 23);
            this.button_origin.Name = "button_origin";
            this.button_origin.Size = new System.Drawing.Size(80, 25);
            this.button_origin.TabIndex = 4;
            this.button_origin.Text = "Origin";
            this.button_origin.UseVisualStyleBackColor = true;
            this.button_origin.Click += new System.EventHandler(this.button_origin_Click);
            // 
            // label_origin
            // 
            this.label_origin.Location = new System.Drawing.Point(239, 85);
            this.label_origin.Name = "label_origin";
            this.label_origin.Size = new System.Drawing.Size(114, 30);
            this.label_origin.TabIndex = 5;
            // 
            // label_result
            // 
            this.label_result.Location = new System.Drawing.Point(616, 85);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(114, 30);
            this.label_result.TabIndex = 6;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(988, 23);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(65, 25);
            this.textBox_width.TabIndex = 7;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(988, 63);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(65, 25);
            this.textBox_height.TabIndex = 8;
            // 
            // label_width
            // 
            this.label_width.Location = new System.Drawing.Point(920, 23);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(62, 25);
            this.label_width.TabIndex = 9;
            this.label_width.Text = "Width";
            this.label_width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_height
            // 
            this.label_height.Location = new System.Drawing.Point(920, 61);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(62, 25);
            this.label_height.TabIndex = 10;
            this.label_height.Text = "Height";
            this.label_height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_resize
            // 
            this.button_resize.Location = new System.Drawing.Point(1090, 23);
            this.button_resize.Name = "button_resize";
            this.button_resize.Size = new System.Drawing.Size(83, 65);
            this.button_resize.TabIndex = 11;
            this.button_resize.Text = "Resize";
            this.button_resize.UseVisualStyleBackColor = true;
            this.button_resize.Click += new System.EventHandler(this.button_resize_Click);
            // 
            // button_undo
            // 
            this.button_undo.Location = new System.Drawing.Point(343, 23);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(93, 45);
            this.button_undo.TabIndex = 12;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 718);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

