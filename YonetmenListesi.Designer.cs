namespace FilmPortali1
{
    partial class YonetmenListesi
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pbResimDetay = new System.Windows.Forms.PictureBox();
            this.btnRYukle = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.Y_Silme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(174, 29);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(64, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "label1";
            // 
            // pbResimDetay
            // 
            this.pbResimDetay.Image = ((System.Drawing.Image)(resources.GetObject("pbResimDetay.Image")));
            this.pbResimDetay.Location = new System.Drawing.Point(3, 0);
            this.pbResimDetay.Name = "pbResimDetay";
            this.pbResimDetay.Size = new System.Drawing.Size(118, 82);
            this.pbResimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResimDetay.TabIndex = 2;
            this.pbResimDetay.TabStop = false;
            // 
            // btnRYukle
            // 
            this.btnRYukle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRYukle.FlatAppearance.BorderSize = 0;
            this.btnRYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRYukle.Font = new System.Drawing.Font("Italic Outline Art", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRYukle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRYukle.Location = new System.Drawing.Point(353, 41);
            this.btnRYukle.Name = "btnRYukle";
            this.btnRYukle.Size = new System.Drawing.Size(140, 38);
            this.btnRYukle.TabIndex = 9;
            this.btnRYukle.Text = "DETAY";
            this.btnRYukle.UseVisualStyleBackColor = false;
            this.btnRYukle.Click += new System.EventHandler(this.btnRYukle_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(234, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 25);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // Y_Silme
            // 
            this.Y_Silme.BackColor = System.Drawing.Color.Firebrick;
            this.Y_Silme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Y_Silme.FlatAppearance.BorderSize = 0;
            this.Y_Silme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_Silme.Font = new System.Drawing.Font("Italic Outline Art", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Y_Silme.ForeColor = System.Drawing.SystemColors.Info;
            this.Y_Silme.Location = new System.Drawing.Point(499, 41);
            this.Y_Silme.Name = "Y_Silme";
            this.Y_Silme.Size = new System.Drawing.Size(65, 38);
            this.Y_Silme.TabIndex = 11;
            this.Y_Silme.Text = "SİL";
            this.Y_Silme.UseVisualStyleBackColor = false;
            this.Y_Silme.Click += new System.EventHandler(this.Y_Silme_Click);
            // 
            // YonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Y_Silme);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRYukle);
            this.Controls.Add(this.pbResimDetay);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YonetmenListesi";
            this.Size = new System.Drawing.Size(567, 82);
            this.Load += new System.EventHandler(this.YonetmenListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.PictureBox pbResimDetay;
        private System.Windows.Forms.Button btnRYukle;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button Y_Silme;
    }
}
