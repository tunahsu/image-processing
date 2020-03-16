namespace ImageProcessing
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
            this.pictureBox_origin = new System.Windows.Forms.PictureBox();
            this.pictureBox_originRB = new System.Windows.Forms.PictureBox();
            this.pictureBox_originGB = new System.Windows.Forms.PictureBox();
            this.pictureBox_originBB = new System.Windows.Forms.PictureBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_origin_size = new System.Windows.Forms.Label();
            this.pictureBox_originRH = new System.Windows.Forms.PictureBox();
            this.pictureBox_originGH = new System.Windows.Forms.PictureBox();
            this.pictureBox_originBH = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_origin
            // 
            this.pictureBox_origin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_origin.Location = new System.Drawing.Point(23, 92);
            this.pictureBox_origin.Name = "pictureBox_origin";
            this.pictureBox_origin.Size = new System.Drawing.Size(380, 320);
            this.pictureBox_origin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_origin.TabIndex = 0;
            this.pictureBox_origin.TabStop = false;
            // 
            // pictureBox_originRB
            // 
            this.pictureBox_originRB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originRB.Location = new System.Drawing.Point(23, 422);
            this.pictureBox_originRB.Name = "pictureBox_originRB";
            this.pictureBox_originRB.Size = new System.Drawing.Size(120, 100);
            this.pictureBox_originRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originRB.TabIndex = 1;
            this.pictureBox_originRB.TabStop = false;
            // 
            // pictureBox_originGB
            // 
            this.pictureBox_originGB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originGB.Location = new System.Drawing.Point(153, 422);
            this.pictureBox_originGB.Name = "pictureBox_originGB";
            this.pictureBox_originGB.Size = new System.Drawing.Size(120, 100);
            this.pictureBox_originGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originGB.TabIndex = 2;
            this.pictureBox_originGB.TabStop = false;
            // 
            // pictureBox_originBB
            // 
            this.pictureBox_originBB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originBB.Location = new System.Drawing.Point(283, 422);
            this.pictureBox_originBB.Name = "pictureBox_originBB";
            this.pictureBox_originBB.Size = new System.Drawing.Size(120, 100);
            this.pictureBox_originBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originBB.TabIndex = 3;
            this.pictureBox_originBB.TabStop = false;
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_open.Location = new System.Drawing.Point(23, 24);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(100, 30);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_save.Location = new System.Drawing.Point(153, 24);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 30);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_origin_size
            // 
            this.label_origin_size.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_origin_size.Location = new System.Drawing.Point(303, 66);
            this.label_origin_size.Name = "label_origin_size";
            this.label_origin_size.Size = new System.Drawing.Size(100, 23);
            this.label_origin_size.TabIndex = 6;
            this.label_origin_size.Text = "0 X 0";
            this.label_origin_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_originRH
            // 
            this.pictureBox_originRH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originRH.Location = new System.Drawing.Point(23, 532);
            this.pictureBox_originRH.Name = "pictureBox_originRH";
            this.pictureBox_originRH.Size = new System.Drawing.Size(120, 100);
            this.pictureBox_originRH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originRH.TabIndex = 7;
            this.pictureBox_originRH.TabStop = false;
            // 
            // pictureBox_originGH
            // 
            this.pictureBox_originGH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originGH.Location = new System.Drawing.Point(153, 532);
            this.pictureBox_originGH.Name = "pictureBox_originGH";
            this.pictureBox_originGH.Size = new System.Drawing.Size(120, 100);
            this.pictureBox_originGH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originGH.TabIndex = 8;
            this.pictureBox_originGH.TabStop = false;
            // 
            // pictureBox_originBH
            // 
            this.pictureBox_originBH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originBH.Location = new System.Drawing.Point(283, 532);
            this.pictureBox_originBH.Name = "pictureBox_originBH";
            this.pictureBox_originBH.Size = new System.Drawing.Size(120, 100);
            this.pictureBox_originBH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originBH.TabIndex = 9;
            this.pictureBox_originBH.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_originBH);
            this.Controls.Add(this.pictureBox_originGH);
            this.Controls.Add(this.pictureBox_originRH);
            this.Controls.Add(this.label_origin_size);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.pictureBox_originBB);
            this.Controls.Add(this.pictureBox_originGB);
            this.Controls.Add(this.pictureBox_originRB);
            this.Controls.Add(this.pictureBox_origin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_origin;
        private System.Windows.Forms.PictureBox pictureBox_originRB;
        private System.Windows.Forms.PictureBox pictureBox_originGB;
        private System.Windows.Forms.PictureBox pictureBox_originBB;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_origin_size;
        private System.Windows.Forms.PictureBox pictureBox_originRH;
        private System.Windows.Forms.PictureBox pictureBox_originGH;
        private System.Windows.Forms.PictureBox pictureBox_originBH;
        private System.Windows.Forms.Label label1;
    }
}

