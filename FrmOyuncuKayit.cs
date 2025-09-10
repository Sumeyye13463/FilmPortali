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
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOyuncuKayit_Load(object sender, EventArgs e)
        {

        }

        public string resimYolu;

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
        public string cinsiyet = " 0 ";
        private void rKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = " 1 ";
        }

        private void rErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = " 0 ";
        }

        private void tBiyografi_TextChanged(object sender, EventArgs e)
        {
            int karakterSyisi = tBiyografi.Text.Length;
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

        public string bYas = "00";

        void yasHesapla()
        {

            string dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString();
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - dogumTarihi.Year;
            //MessageBox.Show(yas.ToString());

            if (yas < 0)
            {

                MessageBox.Show(" Kaydetmeye çalıştığınız kişinin yaş parametresinde bir sorun var. ");
            }
            bYas = yas.ToString();
        }

        private void yKaydet_Click(object sender, EventArgs e)
        {
            yasHesapla();

            if (tOyuncu_A.Text != "" && tBiyografi.Text != "" && resimYolu != "" && cinsiyet != "")
            {
                MessageBox.Show("Kayıt işlemlerinizi gerçekleştirebilirsiniz.");

                connection.Open();

                string adSoyad = tOyuncu_A.Text.ToString().ToUpper();
                //insert into tabloAdi (alanlar) values (alanlara gelecek değerler)
                SqlCommand kayit = new SqlCommand("insert into Oyuncular (O_AdSoyad, O_Cinsiyet, O_Yas, O_Biyografi, O_Resim) values (@p1, @p2, @p3, @p4, @p5)", connection);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", tBiyografi.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.ExecuteNonQuery();
                connection.Close();
                aracTemizle();
                //MessageBox.Show("İşlem başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt alanları boş, lütfen doldurun.");
            }

            void aracTemizle()
            {
                tBiyografi.Text = "";
                tOyuncu_A.Text = "";
                nGun.Value = 1;
                nAy.Value = 1;
                nYil.Value = 2025;
                rErkek.Checked = false;
                rKadın.Checked = true;
                lbKarakter.Text = "300";
                cinsiyet = "0";
                bYas = "00";
                tOyuncu_A.Focus();
                pbResim.ImageLocation = @"C:\\Users\\s7m36\\OneDrive\\Masaüstü\no-image-icon-4.png";
            }

            //MessageBox.Show(bYas);
        }
    }
}
