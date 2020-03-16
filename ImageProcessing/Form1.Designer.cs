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
            this.pictureBox_originR = new System.Windows.Forms.PictureBox();
            this.pictureBox_originG = new System.Windows.Forms.PictureBox();
            this.pictureBox_originB = new System.Windows.Forms.PictureBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_origin_size = new System.Windows.Forms.Label();
            this.pictureBox_originRBand = new System.Windows.Forms.PictureBox();
            this.pictureBox_originGBand = new System.Windows.Forms.PictureBox();
            this.pictureBox_originBBand = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBBand)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_origin
            // 
            this.pictureBox_origin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_origin.Location = new System.Drawing.Point(41, 93);
            this.pictureBox_origin.Name = "pictureBox_origin";
            this.pictureBox_origin.Size = new System.Drawing.Size(320, 320);
            this.pictureBox_origin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_origin.TabIndex = 0;
            this.pictureBox_origin.TabStop = false;
            // 
            // pictureBox_originR
            // 
            this.pictureBox_originR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originR.Location = new System.Drawing.Point(41, 430);
            this.pictureBox_originR.Name = "pictureBox_originR";
            this.pictureBox_originR.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_originR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originR.TabIndex = 1;
            this.pictureBox_originR.TabStop = false;
            // 
            // pictureBox_originG
            // 
            this.pictureBox_originG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originG.Location = new System.Drawing.Point(151, 430);
            this.pictureBox_originG.Name = "pictureBox_originG";
            this.pictureBox_originG.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_originG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originG.TabIndex = 2;
            this.pictureBox_originG.TabStop = false;
            // 
            // pictureBox_originB
            // 
            this.pictureBox_originB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originB.Location = new System.Drawing.Point(261, 430);
            this.pictureBox_originB.Name = "pictureBox_originB";
            this.pictureBox_originB.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_originB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originB.TabIndex = 3;
            this.pictureBox_originB.TabStop = false;
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_open.Location = new System.Drawing.Point(41, 22);
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
            this.button_save.Location = new System.Drawing.Point(261, 22);
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
            this.label_origin_size.Location = new System.Drawing.Point(261, 64);
            this.label_origin_size.Name = "label_origin_size";
            this.label_origin_size.Size = new System.Drawing.Size(100, 23);
            this.label_origin_size.TabIndex = 6;
            this.label_origin_size.Text = "0 X 0";
            this.label_origin_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_originRBand
            // 
            this.pictureBox_originRBand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originRBand.Location = new System.Drawing.Point(41, 551);
            this.pictureBox_originRBand.Name = "pictureBox_originRBand";
            this.pictureBox_originRBand.Size = new System.Drawing.Size(190, 100);
            this.pictureBox_originRBand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originRBand.TabIndex = 7;
            this.pictureBox_originRBand.TabStop = false;
            // 
            // pictureBox_originGBand
            // 
            this.pictureBox_originGBand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originGBand.Location = new System.Drawing.Point(41, 657);
            this.pictureBox_originGBand.Name = "pictureBox_originGBand";
            this.pictureBox_originGBand.Size = new System.Drawing.Size(190, 100);
            this.pictureBox_originGBand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originGBand.TabIndex = 8;
            this.pictureBox_originGBand.TabStop = false;
            // 
            // pictureBox_originBBand
            // 
            this.pictureBox_originBBand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originBBand.Location = new System.Drawing.Point(41, 763);
            this.pictureBox_originBBand.Name = "pictureBox_originBBand";
            this.pictureBox_originBBand.Size = new System.Drawing.Size(190, 100);
            this.pictureBox_originBBand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originBBand.TabIndex = 9;
            this.pictureBox_originBBand.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 875);
            this.Controls.Add(this.pictureBox_originBBand);
            this.Controls.Add(this.pictureBox_originGBand);
            this.Controls.Add(this.pictureBox_originRBand);
            this.Controls.Add(this.label_origin_size);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.pictureBox_originB);
            this.Controls.Add(this.pictureBox_originG);
            this.Controls.Add(this.pictureBox_originR);
            this.Controls.Add(this.pictureBox_origin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBBand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_origin;
        private System.Windows.Forms.PictureBox pictureBox_originR;
        private System.Windows.Forms.PictureBox pictureBox_originG;
        private System.Windows.Forms.PictureBox pictureBox_originB;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_origin_size;
        private System.Windows.Forms.PictureBox pictureBox_originRBand;
        private System.Windows.Forms.PictureBox pictureBox_originGBand;
        private System.Windows.Forms.PictureBox pictureBox_originBBand;
    }
}

