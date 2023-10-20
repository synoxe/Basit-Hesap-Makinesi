namespace hesapmakinesi0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1Button = new System.Windows.Forms.Button();
            this.rakam2Button = new System.Windows.Forms.Button();
            this.rakam3Button = new System.Windows.Forms.Button();
            this.boluButton = new System.Windows.Forms.Button();
            this.carpButton = new System.Windows.Forms.Button();
            this.eksiButton = new System.Windows.Forms.Button();
            this.artıButton = new System.Windows.Forms.Button();
            this.rakam6Button = new System.Windows.Forms.Button();
            this.rakam5Button = new System.Windows.Forms.Button();
            this.rakam4Button = new System.Windows.Forms.Button();
            this.rakam9Button = new System.Windows.Forms.Button();
            this.rakam8Button = new System.Windows.Forms.Button();
            this.rakam7Button = new System.Windows.Forms.Button();
            this.esButton = new System.Windows.Forms.Button();
            this.rakam0Button = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(12, 23);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(423, 72);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakam1Button
            // 
            this.rakam1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1Button.Location = new System.Drawing.Point(12, 109);
            this.rakam1Button.Name = "rakam1Button";
            this.rakam1Button.Size = new System.Drawing.Size(80, 80);
            this.rakam1Button.TabIndex = 1;
            this.rakam1Button.Text = "1";
            this.rakam1Button.UseVisualStyleBackColor = true;
            this.rakam1Button.Click += new System.EventHandler(this.rakam1Button_Click);
            // 
            // rakam2Button
            // 
            this.rakam2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2Button.Location = new System.Drawing.Point(98, 109);
            this.rakam2Button.Name = "rakam2Button";
            this.rakam2Button.Size = new System.Drawing.Size(80, 80);
            this.rakam2Button.TabIndex = 2;
            this.rakam2Button.Text = "2";
            this.rakam2Button.UseVisualStyleBackColor = true;
            this.rakam2Button.Click += new System.EventHandler(this.rakam2Button_Click);
            // 
            // rakam3Button
            // 
            this.rakam3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3Button.Location = new System.Drawing.Point(184, 109);
            this.rakam3Button.Name = "rakam3Button";
            this.rakam3Button.Size = new System.Drawing.Size(80, 80);
            this.rakam3Button.TabIndex = 3;
            this.rakam3Button.Text = "3";
            this.rakam3Button.UseVisualStyleBackColor = true;
            this.rakam3Button.Click += new System.EventHandler(this.rakam3Button_Click);
            // 
            // boluButton
            // 
            this.boluButton.BackColor = System.Drawing.Color.MistyRose;
            this.boluButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boluButton.Location = new System.Drawing.Point(270, 109);
            this.boluButton.Name = "boluButton";
            this.boluButton.Size = new System.Drawing.Size(165, 80);
            this.boluButton.TabIndex = 4;
            this.boluButton.Text = "/";
            this.boluButton.UseVisualStyleBackColor = false;
            this.boluButton.Click += new System.EventHandler(this.boluButton_Click);
            // 
            // carpButton
            // 
            this.carpButton.BackColor = System.Drawing.Color.MistyRose;
            this.carpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpButton.Location = new System.Drawing.Point(270, 204);
            this.carpButton.Name = "carpButton";
            this.carpButton.Size = new System.Drawing.Size(165, 80);
            this.carpButton.TabIndex = 5;
            this.carpButton.Text = "X";
            this.carpButton.UseVisualStyleBackColor = false;
            this.carpButton.Click += new System.EventHandler(this.carpButton_Click);
            // 
            // eksiButton
            // 
            this.eksiButton.BackColor = System.Drawing.Color.MistyRose;
            this.eksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksiButton.Location = new System.Drawing.Point(270, 302);
            this.eksiButton.Name = "eksiButton";
            this.eksiButton.Size = new System.Drawing.Size(165, 80);
            this.eksiButton.TabIndex = 6;
            this.eksiButton.Text = "-";
            this.eksiButton.UseVisualStyleBackColor = false;
            this.eksiButton.Click += new System.EventHandler(this.eksiButton_Click);
            // 
            // artıButton
            // 
            this.artıButton.BackColor = System.Drawing.Color.MistyRose;
            this.artıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artıButton.Location = new System.Drawing.Point(270, 399);
            this.artıButton.Name = "artıButton";
            this.artıButton.Size = new System.Drawing.Size(165, 80);
            this.artıButton.TabIndex = 7;
            this.artıButton.Text = "+";
            this.artıButton.UseVisualStyleBackColor = false;
            this.artıButton.Click += new System.EventHandler(this.artıButton_Click);
            // 
            // rakam6Button
            // 
            this.rakam6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6Button.Location = new System.Drawing.Point(184, 204);
            this.rakam6Button.Name = "rakam6Button";
            this.rakam6Button.Size = new System.Drawing.Size(80, 80);
            this.rakam6Button.TabIndex = 10;
            this.rakam6Button.Text = "6";
            this.rakam6Button.UseVisualStyleBackColor = true;
            this.rakam6Button.Click += new System.EventHandler(this.rakam6Button_Click);
            // 
            // rakam5Button
            // 
            this.rakam5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5Button.Location = new System.Drawing.Point(98, 204);
            this.rakam5Button.Name = "rakam5Button";
            this.rakam5Button.Size = new System.Drawing.Size(80, 80);
            this.rakam5Button.TabIndex = 9;
            this.rakam5Button.Text = "5";
            this.rakam5Button.UseVisualStyleBackColor = true;
            this.rakam5Button.Click += new System.EventHandler(this.rakam5Button_Click);
            // 
            // rakam4Button
            // 
            this.rakam4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4Button.Location = new System.Drawing.Point(12, 204);
            this.rakam4Button.Name = "rakam4Button";
            this.rakam4Button.Size = new System.Drawing.Size(80, 80);
            this.rakam4Button.TabIndex = 8;
            this.rakam4Button.Text = "4";
            this.rakam4Button.UseVisualStyleBackColor = true;
            this.rakam4Button.Click += new System.EventHandler(this.rakam4Button_Click);
            // 
            // rakam9Button
            // 
            this.rakam9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9Button.Location = new System.Drawing.Point(184, 302);
            this.rakam9Button.Name = "rakam9Button";
            this.rakam9Button.Size = new System.Drawing.Size(80, 80);
            this.rakam9Button.TabIndex = 13;
            this.rakam9Button.Text = "9";
            this.rakam9Button.UseVisualStyleBackColor = true;
            this.rakam9Button.Click += new System.EventHandler(this.rakam9Button_Click);
            // 
            // rakam8Button
            // 
            this.rakam8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8Button.Location = new System.Drawing.Point(98, 302);
            this.rakam8Button.Name = "rakam8Button";
            this.rakam8Button.Size = new System.Drawing.Size(80, 80);
            this.rakam8Button.TabIndex = 12;
            this.rakam8Button.Text = "8";
            this.rakam8Button.UseVisualStyleBackColor = true;
            this.rakam8Button.Click += new System.EventHandler(this.rakam8Button_Click);
            // 
            // rakam7Button
            // 
            this.rakam7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7Button.Location = new System.Drawing.Point(12, 302);
            this.rakam7Button.Name = "rakam7Button";
            this.rakam7Button.Size = new System.Drawing.Size(80, 80);
            this.rakam7Button.TabIndex = 11;
            this.rakam7Button.Text = "7";
            this.rakam7Button.UseVisualStyleBackColor = true;
            this.rakam7Button.Click += new System.EventHandler(this.rakam7Button_Click);
            // 
            // esButton
            // 
            this.esButton.BackColor = System.Drawing.SystemColors.Info;
            this.esButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esButton.ForeColor = System.Drawing.Color.Black;
            this.esButton.Location = new System.Drawing.Point(184, 399);
            this.esButton.Name = "esButton";
            this.esButton.Size = new System.Drawing.Size(80, 80);
            this.esButton.TabIndex = 16;
            this.esButton.Text = "=";
            this.esButton.UseVisualStyleBackColor = false;
            this.esButton.Click += new System.EventHandler(this.esButton_Click);
            // 
            // rakam0Button
            // 
            this.rakam0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0Button.Location = new System.Drawing.Point(98, 399);
            this.rakam0Button.Name = "rakam0Button";
            this.rakam0Button.Size = new System.Drawing.Size(80, 80);
            this.rakam0Button.TabIndex = 15;
            this.rakam0Button.Text = "0";
            this.rakam0Button.UseVisualStyleBackColor = true;
            this.rakam0Button.Click += new System.EventHandler(this.rakam0Button_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.Red;
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CButton.ForeColor = System.Drawing.Color.White;
            this.CButton.Location = new System.Drawing.Point(12, 399);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(80, 80);
            this.CButton.TabIndex = 14;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 487);
            this.Controls.Add(this.esButton);
            this.Controls.Add(this.rakam0Button);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.rakam9Button);
            this.Controls.Add(this.rakam8Button);
            this.Controls.Add(this.rakam7Button);
            this.Controls.Add(this.rakam6Button);
            this.Controls.Add(this.rakam5Button);
            this.Controls.Add(this.rakam4Button);
            this.Controls.Add(this.artıButton);
            this.Controls.Add(this.eksiButton);
            this.Controls.Add(this.carpButton);
            this.Controls.Add(this.boluButton);
            this.Controls.Add(this.rakam3Button);
            this.Controls.Add(this.rakam2Button);
            this.Controls.Add(this.rakam1Button);
            this.Controls.Add(this.ekranLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1Button;
        private System.Windows.Forms.Button rakam2Button;
        private System.Windows.Forms.Button rakam3Button;
        private System.Windows.Forms.Button boluButton;
        private System.Windows.Forms.Button carpButton;
        private System.Windows.Forms.Button eksiButton;
        private System.Windows.Forms.Button artıButton;
        private System.Windows.Forms.Button rakam6Button;
        private System.Windows.Forms.Button rakam5Button;
        private System.Windows.Forms.Button rakam4Button;
        private System.Windows.Forms.Button rakam9Button;
        private System.Windows.Forms.Button rakam8Button;
        private System.Windows.Forms.Button rakam7Button;
        private System.Windows.Forms.Button esButton;
        private System.Windows.Forms.Button rakam0Button;
        private System.Windows.Forms.Button CButton;
    }
}

