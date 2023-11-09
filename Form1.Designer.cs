namespace QR_code_oluşturma
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
            this.buttonQR = new System.Windows.Forms.Button();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.pictureQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQR
            // 
            this.buttonQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonQR.Location = new System.Drawing.Point(12, 48);
            this.buttonQR.Name = "buttonQR";
            this.buttonQR.Size = new System.Drawing.Size(374, 45);
            this.buttonQR.TabIndex = 0;
            this.buttonQR.Text = "QR Code Üret";
            this.buttonQR.UseVisualStyleBackColor = true;
            this.buttonQR.Click += new System.EventHandler(this.buttonQR_Click);
            // 
            // textAdres
            // 
            this.textAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdres.Location = new System.Drawing.Point(12, 12);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(374, 30);
            this.textAdres.TabIndex = 1;
            // 
            // pictureQR
            // 
            this.pictureQR.Location = new System.Drawing.Point(12, 111);
            this.pictureQR.Name = "pictureQR";
            this.pictureQR.Size = new System.Drawing.Size(374, 327);
            this.pictureQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureQR.TabIndex = 2;
            this.pictureQR.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.pictureQR);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.buttonQR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQR;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.PictureBox pictureQR;
    }
}

