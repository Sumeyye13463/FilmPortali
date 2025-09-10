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
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();

            connection.Open();

            string sorgu = " select * from Oyuncular ORDER BY O_AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                OyuncuListesi arac = new OyuncuListesi();
                arac.lblID.Text = read["id"].ToString();
                arac.lblAdSoyad.Text = read["O_AdSoyad"].ToString();
                arac.pbResimDetay.ImageLocation = read["O_Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tO_Arama_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();

            connection.Open();

            SqlCommand ara = new SqlCommand("select * from Oyuncular WHERE O_AdSoyad LIKE '%" + tO_Arama.Text + "%' ORDER BY O_AdSoyad ASC", connection);
            SqlDataReader read = ara.ExecuteReader();

            while (read.Read())
            {

                OyuncuListesi arac = new OyuncuListesi();
                arac.lblID.Text = read["id"].ToString();
                arac.lblAdSoyad.Text = read["O_AdSoyad"].ToString();
                arac.pbResimDetay.ImageLocation = read["O_Resim"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            connection.Close();
        }
    }
}
