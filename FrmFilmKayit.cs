using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmPortali1
{
    public partial class FrmFilmKayit : Form
    {
        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";

        public FrmFilmKayit()
        {

            InitializeComponent();
            label2.Click += label2_Click;
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            connection.Open();  // burada x işaretine basıldığında tablodaki veriler silinir.
            SqlCommand komut = new SqlCommand("DELETE FROM F_Secilenler", connection);
            komut.ExecuteNonQuery();
            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karakterSyisi = textBox2.Text.Length;
            int silinen = 300 - karakterSyisi;
            lbKarakter.Text = silinen.ToString();

            if (silinen <= 20)
            {
                lbKarakter.ForeColor = Color.Orange;
            }

            if (silinen <= 10)
            {
                lbKarakter.ForeColor = Color.Red;
            }
        }

        void ylisteGetir()
        {

            fYonetmenAra.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Yonetmenler ORDER BY Y_AdSoyad ASC ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                yListesi arac = new yListesi();
                arac.lAdi.Text = oku["Y_AdSoyad"].ToString();
                fYonetmenAra.Controls.Add(arac);
            }

            connection.Close();
        }

        void olisteGetir()
        {

            fOyuncuAra.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Oyuncular ORDER BY O_AdSoyad ASC ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                oListesi arac = new oListesi();
                arac.lAdi.Text = oku["O_AdSoyad"].ToString();
                fOyuncuAra.Controls.Add(arac);
            }

            connection.Close();
        }

        private void FrmFilmKayit_Load(object sender, EventArgs e)
        {
            bugunTarih();
            ylisteGetir();
            olisteGetir();
            
            
        }

        void bugunTarih()
        {
            nVGun.Value = DateTime.Today.Day;
            nVAy.Value = DateTime.Today.Month;
            nVYil.Value = DateTime.Today.Year;
        }
        public string resimYolu = "";
        private void btnRYukle_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM KAYDETME EKRANI";
            ofd.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|All Files (*.*)|*.*";
            ofd.FilterIndex = 0; //all file default hale getirdik.

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbResim.Image = new Bitmap(ofd.FileName);
                    resimYolu = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e) //müzikal
        {
            if (label2.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                label2.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                label2.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void lDrama_Click(object sender, EventArgs e)
        {

            if (lDrama.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lDrama.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lDrama.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lAksiyon_Click(object sender, EventArgs e)
        {

            if (lAksiyon.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lAksiyon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lAksiyon.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lKorku_Click(object sender, EventArgs e)
        {

            if (lKorku.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lKorku.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lKorku.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lKomedi_Click(object sender, EventArgs e)
        {

            if (lKomedi.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lKomedi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lKomedi.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lGerilim_Click(object sender, EventArgs e)
        {

            if (lGerilim.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lGerilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lGerilim.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void label3_Click(object sender, EventArgs e) //bilim kurgu
        {

            if (label3.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                label3.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                label3.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void label4_Click(object sender, EventArgs e) //romantik
        {

            if (label4.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                label4.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                label4.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lMacera_Click(object sender, EventArgs e)
        {

            if (lMacera.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lMacera.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lMacera.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lDublaj_Click(object sender, EventArgs e)
        {

            if (lDublaj.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lDublaj.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lDublaj.ForeColor = Color.FromArgb(70, 130, 180);
            }

        }

        private void lAltyazı_Click(object sender, EventArgs e)
        {

            if (lAltyazı.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lAltyazı.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lAltyazı.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void lOlumsuz_Click(object sender, EventArgs e)
        {
            if (lOlumsuz.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lOlumsuz.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else // seçiliyse geri al
            {
                lOlumsuz.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void lŞiddet_Click(object sender, EventArgs e)
        {
            if (lŞiddet.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lŞiddet.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else // seçiliyse geri al
            {
                lŞiddet.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void lGenel_Click(object sender, EventArgs e)
        {
            if (lGenel.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                lGenel.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else // seçiliyse geri al
            {
                lGenel.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void l13_Click(object sender, EventArgs e)
        {
            if (l13.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                l13.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else // seçiliyse geri al
            {
                l13.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void l18_Click(object sender, EventArgs e)
        {
            if (l18.ForeColor == Color.FromArgb(70, 130, 180)) // seçilmemişse
            {
                l18.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else // seçiliyse geri al
            {
                l18.ForeColor = Color.FromArgb(70, 130, 180);
            }
        }

        private void TarihKaydet_Click(object sender, EventArgs e)
        {
            TarihHesapla();
        }

        string vTarih = "";
        string durum = "0";
        void TarihHesapla()
        {
            vTarih = nVGun.Value + "-" + nVAy.Value + "-" + nVYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;

            TimeSpan tSpan = dVTarih - bugunTarihi;

            if (tSpan.TotalDays <0 )
            {

                MessageBox.Show("Geçmiş tarihli bir film kaydedemezsiniz.");
                bugunTarih();
            }
            else if(tSpan.TotalDays == 0)
            {
                MessageBox.Show("Kaydettiğiniz film bugün vizyonda.");
                durum = "1";
            }
            else
            {
                MessageBox.Show(tSpan.TotalDays.ToString() + " Gün sonra vizyona girecek.");
                durum = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lTarih.Text = DateTime.Today.ToShortDateString();
        }

       public string oyuncu = "";
       public string yonetmen = "";

        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "SELECT * FROM F_Secilenler WHERE Tur=@p1";

            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", "YÖNETMEN");
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                yonetmen += " ," + oku["Kisi"].ToString();
            }
            connection.Close();

        }

        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "SELECT * FROM F_Secilenler WHERE Tur=@p2";

            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p2", "OYUNCU");
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                oyuncu += " ," + oku["Kisi"].ToString();
            }
            connection.Close();

        }

        void temizleme()
        {
            this.Controls.Clear();
            this.InitializeComponent(); //SAYFAYI SIFIRDAN BAŞLATTI

            textBox1.Focus();
            ylisteGetir(); //GİZLİ ÇAĞIRDIĞIMIZ İÇERİKLERİ DE ÇAĞIRDIK
            olisteGetir();
            bugunTarih();
        }
        private void button6_Click(object sender, EventArgs e) //kaydetme butonu
        {
            secilenYonetmen();
            secilenOyuncu();
            //string oyuncu = "oyuncu";
            //string yonetmen = "yönetmen";
            string secilenDeger = comboBox1.SelectedItem?.ToString();
            tur();
            ozellik();
            bicim();

            if (textBox1.Text != "" && textBox2.Text != "" && yonetmen != "" && oyuncu != "" && resimYolu != "" && vTarih != "") //alanlar dolu veya boş ise yapılacaklar denetlenecek
            {

                string sorgu = "INSERT INTO Filmler (F_Adi, F_Turu, F_Ozellikleri, F_Bicimi, F_Yonetmeni, F_Oyunculari, F_Detay, F_Puan, F_Afis, F_VTarihi, F_Durum) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11) ";
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@p1", textBox1.Text.ToUpper());

                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                //
                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);
                }
                //
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }
                //
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }
                //
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }

                komut.Parameters.AddWithValue("@p7", textBox2.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", secilenDeger);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Film Kaydı Başarılı");
                temizleme();

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }

        }

        private void gFilmTürü_Enter(object sender, EventArgs e)
        {

        }

       // string secilenTur = "";
        void tur()
        {

            foreach (Control arac in gFilmTürü.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(249, 164, 26))
                    {

                    }

                }
                else
                {
                    secilenTur += " ," + arac.Text.ToString();
                }
            }

        }

        private void bTurKaydet_Click(object sender, EventArgs e)
        {
            string secilenTur = "";

            foreach (Control arac in gFilmTürü.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(249, 164, 26))
                    {

                    }

                }
                else
                {
                    secilenTur += " ," +arac.Text.ToString();
                }
            }
            if (secilenTur.Length > 2 )
            {
                MessageBox.Show("Seçilenler: ", secilenTur.Substring(2));
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }

        //string secilenOzellik = "";
        void ozellik()
        {

            foreach (Control arac in gFilmÖzellikleri.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(249, 164, 26))
                    {

                    }

                }
                else
                {
                    secilenOzellik += " ," + arac.Text.ToString();
                }
            }

        }

        private void bOzellik_Click(object sender, EventArgs e)
        {

            string secilenOzellik = "";

            foreach (Control arac in gFilmÖzellikleri.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(249, 164, 26))
                    {

                    }

                }
                else
                {
                    secilenOzellik += " ," + arac.Text.ToString();
                }
            }
            if (secilenOzellik.Length > 2)
            {
                MessageBox.Show("Seçilenler: ", secilenOzellik.Substring(2));
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }

        //string secilenBicim = "";
        void bicim()
        {

            foreach (Control arac in gFilmBiçimi.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(249, 164, 26))
                    {

                    }

                }
                else
                {
                    secilenBicim += " ," + arac.Text.ToString();
                }
            }

        }

        private void bBicim_Click(object sender, EventArgs e)
        {

            string secilenBicim = "";

            foreach (Control arac in gFilmBiçimi.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(249, 164, 26))
                    {

                    }

                }
                else
                {
                    secilenBicim += " ," + arac.Text.ToString();
                }
            }
            if (secilenBicim.Length > 2)
            {
                MessageBox.Show("Seçilenler: ", secilenBicim.Substring(2));
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }

        }

        public void gPuan_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
