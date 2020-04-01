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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_resultBH = new System.Windows.Forms.PictureBox();
            this.pictureBox_resultGH = new System.Windows.Forms.PictureBox();
            this.pictureBox_resultRH = new System.Windows.Forms.PictureBox();
            this.label_result_size = new System.Windows.Forms.Label();
            this.pictureBox_resultBB = new System.Windows.Forms.PictureBox();
            this.pictureBox_resultGB = new System.Windows.Forms.PictureBox();
            this.pictureBox_resultRB = new System.Windows.Forms.PictureBox();
            this.pictureBox_result = new System.Windows.Forms.PictureBox();
            this.button_grayscale = new System.Windows.Forms.Button();
            this.comboBox_grayscale = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button_undo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_enhancement = new System.Windows.Forms.ComboBox();
            this.button_enhancement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_origin
            // 
            this.pictureBox_origin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_origin.Location = new System.Drawing.Point(31, 115);
            this.pictureBox_origin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_origin.Name = "pictureBox_origin";
            this.pictureBox_origin.Size = new System.Drawing.Size(507, 400);
            this.pictureBox_origin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_origin.TabIndex = 0;
            this.pictureBox_origin.TabStop = false;
            // 
            // pictureBox_originRB
            // 
            this.pictureBox_originRB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originRB.Location = new System.Drawing.Point(31, 528);
            this.pictureBox_originRB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_originRB.Name = "pictureBox_originRB";
            this.pictureBox_originRB.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_originRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originRB.TabIndex = 1;
            this.pictureBox_originRB.TabStop = false;
            // 
            // pictureBox_originGB
            // 
            this.pictureBox_originGB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originGB.Location = new System.Drawing.Point(204, 528);
            this.pictureBox_originGB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_originGB.Name = "pictureBox_originGB";
            this.pictureBox_originGB.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_originGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originGB.TabIndex = 2;
            this.pictureBox_originGB.TabStop = false;
            // 
            // pictureBox_originBB
            // 
            this.pictureBox_originBB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originBB.Location = new System.Drawing.Point(377, 528);
            this.pictureBox_originBB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_originBB.Name = "pictureBox_originBB";
            this.pictureBox_originBB.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_originBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originBB.TabIndex = 3;
            this.pictureBox_originBB.TabStop = false;
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_open.Location = new System.Drawing.Point(31, 30);
            this.button_open.Margin = new System.Windows.Forms.Padding(4);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(133, 38);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_save.Location = new System.Drawing.Point(204, 30);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(133, 38);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_origin_size
            // 
            this.label_origin_size.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_origin_size.Location = new System.Drawing.Point(404, 82);
            this.label_origin_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_origin_size.Name = "label_origin_size";
            this.label_origin_size.Size = new System.Drawing.Size(133, 29);
            this.label_origin_size.TabIndex = 6;
            this.label_origin_size.Text = "0 X 0";
            this.label_origin_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_originRH
            // 
            this.pictureBox_originRH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originRH.Location = new System.Drawing.Point(31, 665);
            this.pictureBox_originRH.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_originRH.Name = "pictureBox_originRH";
            this.pictureBox_originRH.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_originRH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originRH.TabIndex = 7;
            this.pictureBox_originRH.TabStop = false;
            // 
            // pictureBox_originGH
            // 
            this.pictureBox_originGH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originGH.Location = new System.Drawing.Point(204, 665);
            this.pictureBox_originGH.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_originGH.Name = "pictureBox_originGH";
            this.pictureBox_originGH.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_originGH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originGH.TabIndex = 8;
            this.pictureBox_originGH.TabStop = false;
            // 
            // pictureBox_originBH
            // 
            this.pictureBox_originBH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_originBH.Location = new System.Drawing.Point(377, 665);
            this.pictureBox_originBH.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_originBH.Name = "pictureBox_originBH";
            this.pictureBox_originBH.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_originBH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_originBH.TabIndex = 9;
            this.pictureBox_originBH.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(568, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_resultBH
            // 
            this.pictureBox_resultBH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_resultBH.Location = new System.Drawing.Point(919, 665);
            this.pictureBox_resultBH.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_resultBH.Name = "pictureBox_resultBH";
            this.pictureBox_resultBH.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_resultBH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resultBH.TabIndex = 18;
            this.pictureBox_resultBH.TabStop = false;
            // 
            // pictureBox_resultGH
            // 
            this.pictureBox_resultGH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_resultGH.Location = new System.Drawing.Point(745, 665);
            this.pictureBox_resultGH.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_resultGH.Name = "pictureBox_resultGH";
            this.pictureBox_resultGH.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_resultGH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resultGH.TabIndex = 17;
            this.pictureBox_resultGH.TabStop = false;
            // 
            // pictureBox_resultRH
            // 
            this.pictureBox_resultRH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_resultRH.Location = new System.Drawing.Point(572, 665);
            this.pictureBox_resultRH.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_resultRH.Name = "pictureBox_resultRH";
            this.pictureBox_resultRH.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_resultRH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resultRH.TabIndex = 16;
            this.pictureBox_resultRH.TabStop = false;
            // 
            // label_result_size
            // 
            this.label_result_size.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result_size.Location = new System.Drawing.Point(945, 82);
            this.label_result_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result_size.Name = "label_result_size";
            this.label_result_size.Size = new System.Drawing.Size(133, 29);
            this.label_result_size.TabIndex = 15;
            this.label_result_size.Text = "0 X 0";
            this.label_result_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_resultBB
            // 
            this.pictureBox_resultBB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_resultBB.Location = new System.Drawing.Point(919, 528);
            this.pictureBox_resultBB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_resultBB.Name = "pictureBox_resultBB";
            this.pictureBox_resultBB.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_resultBB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resultBB.TabIndex = 14;
            this.pictureBox_resultBB.TabStop = false;
            // 
            // pictureBox_resultGB
            // 
            this.pictureBox_resultGB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_resultGB.Location = new System.Drawing.Point(745, 528);
            this.pictureBox_resultGB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_resultGB.Name = "pictureBox_resultGB";
            this.pictureBox_resultGB.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_resultGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resultGB.TabIndex = 13;
            this.pictureBox_resultGB.TabStop = false;
            // 
            // pictureBox_resultRB
            // 
            this.pictureBox_resultRB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_resultRB.Location = new System.Drawing.Point(572, 528);
            this.pictureBox_resultRB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_resultRB.Name = "pictureBox_resultRB";
            this.pictureBox_resultRB.Size = new System.Drawing.Size(160, 125);
            this.pictureBox_resultRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resultRB.TabIndex = 12;
            this.pictureBox_resultRB.TabStop = false;
            // 
            // pictureBox_result
            // 
            this.pictureBox_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_result.Location = new System.Drawing.Point(572, 115);
            this.pictureBox_result.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_result.Name = "pictureBox_result";
            this.pictureBox_result.Size = new System.Drawing.Size(507, 400);
            this.pictureBox_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_result.TabIndex = 11;
            this.pictureBox_result.TabStop = false;
            // 
            // button_grayscale
            // 
            this.button_grayscale.Enabled = false;
            this.button_grayscale.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_grayscale.Location = new System.Drawing.Point(1355, 142);
            this.button_grayscale.Margin = new System.Windows.Forms.Padding(4);
            this.button_grayscale.Name = "button_grayscale";
            this.button_grayscale.Size = new System.Drawing.Size(133, 38);
            this.button_grayscale.TabIndex = 26;
            this.button_grayscale.Text = "Go";
            this.button_grayscale.UseVisualStyleBackColor = true;
            this.button_grayscale.Click += new System.EventHandler(this.button_grayscale_Click);
            // 
            // comboBox_grayscale
            // 
            this.comboBox_grayscale.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_grayscale.FormattingEnabled = true;
            this.comboBox_grayscale.Items.AddRange(new object[] {
            "Mean-Value",
            "Mean-Weight",
            "Maximum"});
            this.comboBox_grayscale.Location = new System.Drawing.Point(1143, 145);
            this.comboBox_grayscale.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_grayscale.Name = "comboBox_grayscale";
            this.comboBox_grayscale.Size = new System.Drawing.Size(189, 33);
            this.comboBox_grayscale.TabIndex = 27;
            // 
            // button_undo
            // 
            this.button_undo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_undo.Location = new System.Drawing.Point(945, 30);
            this.button_undo.Margin = new System.Windows.Forms.Padding(4);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(133, 38);
            this.button_undo.TabIndex = 30;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1123, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 85);
            this.label3.TabIndex = 32;
            this.label3.Text = "Grayscale";
            // 
            // comboBox_enhancement
            // 
            this.comboBox_enhancement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_enhancement.FormattingEnabled = true;
            this.comboBox_enhancement.Items.AddRange(new object[] {
            "Negative",
            "Log-Transform"});
            this.comboBox_enhancement.Location = new System.Drawing.Point(1143, 256);
            this.comboBox_enhancement.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_enhancement.Name = "comboBox_enhancement";
            this.comboBox_enhancement.Size = new System.Drawing.Size(189, 33);
            this.comboBox_enhancement.TabIndex = 35;
            // 
            // button_enhancement
            // 
            this.button_enhancement.Enabled = false;
            this.button_enhancement.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_enhancement.Location = new System.Drawing.Point(1355, 253);
            this.button_enhancement.Margin = new System.Windows.Forms.Padding(4);
            this.button_enhancement.Name = "button_enhancement";
            this.button_enhancement.Size = new System.Drawing.Size(133, 38);
            this.button_enhancement.TabIndex = 34;
            this.button_enhancement.Text = "Go";
            this.button_enhancement.UseVisualStyleBackColor = true;
            this.button_enhancement.Click += new System.EventHandler(this.button_enhancement_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1123, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 85);
            this.label4.TabIndex = 36;
            this.label4.Text = "Enhancement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 850);
            this.Controls.Add(this.comboBox_enhancement);
            this.Controls.Add(this.button_enhancement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.comboBox_grayscale);
            this.Controls.Add(this.button_grayscale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_resultBH);
            this.Controls.Add(this.pictureBox_resultGH);
            this.Controls.Add(this.pictureBox_resultRH);
            this.Controls.Add(this.label_result_size);
            this.Controls.Add(this.pictureBox_resultBB);
            this.Controls.Add(this.pictureBox_resultGB);
            this.Controls.Add(this.pictureBox_resultRB);
            this.Controls.Add(this.pictureBox_result);
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
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_originBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_result)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_resultBH;
        private System.Windows.Forms.PictureBox pictureBox_resultGH;
        private System.Windows.Forms.PictureBox pictureBox_resultRH;
        private System.Windows.Forms.Label label_result_size;
        private System.Windows.Forms.PictureBox pictureBox_resultBB;
        private System.Windows.Forms.PictureBox pictureBox_resultGB;
        private System.Windows.Forms.PictureBox pictureBox_resultRB;
        private System.Windows.Forms.PictureBox pictureBox_result;
        private System.Windows.Forms.Button button_grayscale;
        private System.Windows.Forms.ComboBox comboBox_grayscale;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button_undo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_enhancement;
        private System.Windows.Forms.Button button_enhancement;
        private System.Windows.Forms.Label label4;
    }
}

