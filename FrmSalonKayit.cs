using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FilmPortali1
{
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRYukle_Click(object sender, EventArgs e)
        {
            if (tSalon_A.Text!= "" && cKoltuk_Sayisi.Text!= "")
            {
             
                connection.Open();

                SqlCommand kaydet = new SqlCommand("insert into Salonlar (SalonAdi, KoltukSayisi) Values (@p1, @p2)  ", connection);
                kaydet.Parameters.AddWithValue("@p1", tSalon_A.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cKoltuk_Sayisi.Text);
                kaydet.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Salon kaydetme işlemi başarılı bir şekilde tamamlanmıştır.");

                tSalon_A.Text = "";
                cKoltuk_Sayisi.Text = "";
                tSalon_A.Focus();

                listeGetir();

            }
            else
            {
                MessageBox.Show("Lütfen bilgileri doldurunuz.");
            }
        }

        void listeGetir() {

            fSalon.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Salonlar ORDER BY SalonAdi ASC ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                SalonListesi arac = new SalonListesi();
                arac.salonAdi.Text = oku["SalonAdi"].ToString();
                arac.koltukSayisi.Text = oku["koltukSayisi"].ToString();
                fSalon.Controls.Add(arac);
            }

            connection.Close();
        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {

           listeGetir();

        }
    }
}
