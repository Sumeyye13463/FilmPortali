using System;

namespace FilmPortali1
{
    partial class FrmGiris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Yetk_Adi = new System.Windows.Forms.Label();
            this.tYetk_Adi = new System.Windows.Forms.TextBox();
            this.Yetk_Sifre = new System.Windows.Forms.Label();
            this.tYetk_Sifre = new System.Windows.Forms.TextBox();
            this.Giris_Yap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 60);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(640, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Giris_Yap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "FilmPortali";
            // 
            // Yetk_Adi
            // 
            this.Yetk_Adi.AutoSize = true;
            this.Yetk_Adi.BackColor = System.Drawing.Color.White;
            this.Yetk_Adi.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yetk_Adi.ForeColor = System.Drawing.Color.SteelBlue;
            this.Yetk_Adi.Location = new System.Drawing.Point(60, 227);
            this.Yetk_Adi.Name = "Yetk_Adi";
            this.Yetk_Adi.Size = new System.Drawing.Size(154, 31);
            this.Yetk_Adi.TabIndex = 1;
            this.Yetk_Adi.Text = "YETKİLİ KİŞİ";
            // 
            // tYetk_Adi
            // 
            this.tYetk_Adi.Location = new System.Drawing.Point(238, 230);
            this.tYetk_Adi.Name = "tYetk_Adi";
            this.tYetk_Adi.Size = new System.Drawing.Size(235, 30);
            this.tYetk_Adi.TabIndex = 2;
            // 
            // Yetk_Sifre
            // 
            this.Yetk_Sifre.AutoSize = true;
            this.Yetk_Sifre.BackColor = System.Drawing.Color.White;
            this.Yetk_Sifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yetk_Sifre.ForeColor = System.Drawing.Color.SteelBlue;
            this.Yetk_Sifre.Location = new System.Drawing.Point(121, 271);
            this.Yetk_Sifre.Name = "Yetk_Sifre";
            this.Yetk_Sifre.Size = new System.Drawing.Size(78, 31);
            this.Yetk_Sifre.TabIndex = 3;
            this.Yetk_Sifre.Text = "ŞİFRE";
            // 
            // tYetk_Sifre
            // 
            this.tYetk_Sifre.Location = new System.Drawing.Point(238, 274);
            this.tYetk_Sifre.Name = "tYetk_Sifre";
            this.tYetk_Sifre.Size = new System.Drawing.Size(235, 30);
            this.tYetk_Sifre.TabIndex = 4;
            // 
            // Giris_Yap
            // 
            this.Giris_Yap.BackColor = System.Drawing.Color.SteelBlue;
            this.Giris_Yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Giris_Yap.FlatAppearance.BorderSize = 0;
            this.Giris_Yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Giris_Yap.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_Yap.ForeColor = System.Drawing.SystemColors.Info;
            this.Giris_Yap.Location = new System.Drawing.Point(269, 325);
            this.Giris_Yap.Name = "Giris_Yap";
            this.Giris_Yap.Size = new System.Drawing.Size(171, 55);
            this.Giris_Yap.TabIndex = 5;
            this.Giris_Yap.Text = "GİRİŞ YAP";
            this.Giris_Yap.UseVisualStyleBackColor = true;
            this.Giris_Yap.Click += new System.EventHandler(this.Giris_Yap_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 488);
            this.Controls.Add(this.Giris_Yap);
            this.Controls.Add(this.tYetk_Sifre);
            this.Controls.Add(this.Yetk_Sifre);
            this.Controls.Add(this.tYetk_Adi);
            this.Controls.Add(this.Yetk_Adi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Yetk_Adi;
        private System.Windows.Forms.TextBox tYetk_Adi;
        private System.Windows.Forms.Label Yetk_Sifre;
        private System.Windows.Forms.TextBox tYetk_Sifre;
        private System.Windows.Forms.Button Giris_Yap;
    }
}

