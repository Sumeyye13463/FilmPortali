namespace FilmPortali1
{
    partial class FrmYönetmenKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYönetmenKayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rErkek = new System.Windows.Forms.RadioButton();
            this.rKadın = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nYil = new System.Windows.Forms.NumericUpDown();
            this.nAy = new System.Windows.Forms.NumericUpDown();
            this.nGun = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tYonetmen_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRYukle = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBiyografi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbKarakter = new System.Windows.Forms.Label();
            this.yKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(671, 60);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(600, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetmen Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rErkek);
            this.groupBox1.Controls.Add(this.rKadın);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nYil);
            this.groupBox1.Controls.Add(this.nAy);
            this.groupBox1.Controls.Add(this.nGun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tYonetmen_A);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rErkek
            // 
            this.rErkek.AutoSize = true;
            this.rErkek.Location = new System.Drawing.Point(152, 229);
            this.rErkek.Name = "rErkek";
            this.rErkek.Size = new System.Drawing.Size(73, 24);
            this.rErkek.TabIndex = 13;
            this.rErkek.TabStop = true;
            this.rErkek.Text = "Erken";
            this.rErkek.UseVisualStyleBackColor = true;
            this.rErkek.CheckedChanged += new System.EventHandler(this.rErkek_CheckedChanged);
            // 
            // rKadın
            // 
            this.rKadın.AutoSize = true;
            this.rKadın.Location = new System.Drawing.Point(21, 229);
            this.rKadın.Name = "rKadın";
            this.rKadın.Size = new System.Drawing.Size(72, 24);
            this.rKadın.TabIndex = 12;
            this.rKadın.TabStop = true;
            this.rKadın.Text = "Kadın";
            this.rKadın.UseVisualStyleBackColor = true;
            this.rKadın.CheckedChanged += new System.EventHandler(this.rKadın_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(17, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CİNSİYET";
            // 
            // nYil
            // 
            this.nYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nYil.Location = new System.Drawing.Point(179, 139);
            this.nYil.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nYil.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nYil.Name = "nYil";
            this.nYil.Size = new System.Drawing.Size(77, 28);
            this.nYil.TabIndex = 10;
            this.nYil.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // nAy
            // 
            this.nAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nAy.Location = new System.Drawing.Point(99, 139);
            this.nAy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nAy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAy.Name = "nAy";
            this.nAy.Size = new System.Drawing.Size(63, 28);
            this.nAy.TabIndex = 9;
            this.nAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nGun
            // 
            this.nGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nGun.Location = new System.Drawing.Point(21, 139);
            this.nGun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nGun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nGun.Name = "nGun";
            this.nGun.Size = new System.Drawing.Size(54, 28);
            this.nGun.TabIndex = 8;
            this.nGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "DOĞUM TARİHİ";
            // 
            // tYonetmen_A
            // 
            this.tYonetmen_A.Location = new System.Drawing.Point(21, 55);
            this.tYonetmen_A.Name = "tYonetmen_A";
            this.tYonetmen_A.Size = new System.Drawing.Size(256, 27);
            this.tYonetmen_A.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD VE SOYAD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRYukle);
            this.groupBox2.Controls.Add(this.pbResim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(361, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 272);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnRYukle
            // 
            this.btnRYukle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRYukle.FlatAppearance.BorderSize = 0;
            this.btnRYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRYukle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRYukle.Location = new System.Drawing.Point(6, 211);
            this.btnRYukle.Name = "btnRYukle";
            this.btnRYukle.Size = new System.Drawing.Size(254, 55);
            this.btnRYukle.TabIndex = 8;
            this.btnRYukle.Text = "YÜKLE";
            this.btnRYukle.UseVisualStyleBackColor = false;
            this.btnRYukle.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbResim
            // 
            this.pbResim.Image = ((System.Drawing.Image)(resources.GetObject("pbResim.Image")));
            this.pbResim.Location = new System.Drawing.Point(10, 36);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(250, 171);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 7;
            this.pbResim.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "RESİM YÜKLEME (zorunlu)";
            // 
            // tBiyografi
            // 
            this.tBiyografi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBiyografi.Location = new System.Drawing.Point(12, 382);
            this.tBiyografi.MaxLength = 300;
            this.tBiyografi.Multiline = true;
            this.tBiyografi.Name = "tBiyografi";
            this.tBiyografi.Size = new System.Drawing.Size(647, 251);
            this.tBiyografi.TabIndex = 8;
            this.tBiyografi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(13, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "BİYOGRAFİ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbKarakter
            // 
            this.lbKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKarakter.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbKarakter.Location = new System.Drawing.Point(543, 602);
            this.lbKarakter.Name = "lbKarakter";
            this.lbKarakter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbKarakter.Size = new System.Drawing.Size(82, 19);
            this.lbKarakter.TabIndex = 9;
            this.lbKarakter.Text = "300";
            // 
            // yKaydet
            // 
            this.yKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.yKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yKaydet.FlatAppearance.BorderSize = 0;
            this.yKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yKaydet.ForeColor = System.Drawing.SystemColors.Info;
            this.yKaydet.Location = new System.Drawing.Point(191, 650);
            this.yKaydet.Name = "yKaydet";
            this.yKaydet.Size = new System.Drawing.Size(254, 55);
            this.yKaydet.TabIndex = 10;
            this.yKaydet.Text = "KAYDET";
            this.yKaydet.UseVisualStyleBackColor = false;
            this.yKaydet.Click += new System.EventHandler(this.yKaydet_Click);
            // 
            // FrmYönetmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 717);
            this.Controls.Add(this.yKaydet);
            this.Controls.Add(this.lbKarakter);
            this.Controls.Add(this.tBiyografi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 110);
            this.Name = "FrmYönetmenKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmYönetmenKayit";
            this.Load += new System.EventHandler(this.FrmYönetmenKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tYonetmen_A;
        private System.Windows.Forms.NumericUpDown nAy;
        private System.Windows.Forms.NumericUpDown nGun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nYil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rErkek;
        private System.Windows.Forms.RadioButton rKadın;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRYukle;
        private System.Windows.Forms.TextBox tBiyografi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbKarakter;
        private System.Windows.Forms.Button yKaydet;
    }
}