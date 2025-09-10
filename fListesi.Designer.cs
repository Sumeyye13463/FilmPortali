namespace FilmPortali1
{
    partial class fListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListesi));
            this.gAfis = new System.Windows.Forms.GroupBox();
            this.lid = new System.Windows.Forms.Label();
            this.lFilmAdi = new System.Windows.Forms.Label();
            this.btnFYukle = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.gAfis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // gAfis
            // 
            this.gAfis.Controls.Add(this.lid);
            this.gAfis.Controls.Add(this.lFilmAdi);
            this.gAfis.Controls.Add(this.btnFYukle);
            this.gAfis.Controls.Add(this.pbResim);
            this.gAfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gAfis.ForeColor = System.Drawing.Color.SteelBlue;
            this.gAfis.Location = new System.Drawing.Point(3, 3);
            this.gAfis.Name = "gAfis";
            this.gAfis.Size = new System.Drawing.Size(193, 291);
            this.gAfis.TabIndex = 12;
            this.gAfis.TabStop = false;
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Enabled = false;
            this.lid.Location = new System.Drawing.Point(117, 0);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(70, 25);
            this.lid.TabIndex = 12;
            this.lid.Text = "label1";
            this.lid.Visible = false;
            // 
            // lFilmAdi
            // 
            this.lFilmAdi.AutoSize = true;
            this.lFilmAdi.Location = new System.Drawing.Point(6, 0);
            this.lFilmAdi.Name = "lFilmAdi";
            this.lFilmAdi.Size = new System.Drawing.Size(70, 25);
            this.lFilmAdi.TabIndex = 11;
            this.lFilmAdi.Text = "label1";
            // 
            // btnFYukle
            // 
            this.btnFYukle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFYukle.FlatAppearance.BorderSize = 0;
            this.btnFYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFYukle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFYukle.Location = new System.Drawing.Point(32, 246);
            this.btnFYukle.Name = "btnFYukle";
            this.btnFYukle.Size = new System.Drawing.Size(137, 39);
            this.btnFYukle.TabIndex = 10;
            this.btnFYukle.Text = "DETAY";
            this.btnFYukle.UseVisualStyleBackColor = false;
            this.btnFYukle.Click += new System.EventHandler(this.btnFYukle_Click);
            // 
            // pbResim
            // 
            this.pbResim.Image = ((System.Drawing.Image)(resources.GetObject("pbResim.Image")));
            this.pbResim.Location = new System.Drawing.Point(6, 38);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(181, 202);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 9;
            this.pbResim.TabStop = false;
            // 
            // fListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gAfis);
            this.Name = "fListesi";
            this.Size = new System.Drawing.Size(199, 300);
            this.gAfis.ResumeLayout(false);
            this.gAfis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gAfis;
        private System.Windows.Forms.Button btnFYukle;
        public System.Windows.Forms.PictureBox pbResim;
        public System.Windows.Forms.Label lFilmAdi;
        public System.Windows.Forms.Label lid;
    }
}
