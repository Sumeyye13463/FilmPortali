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
    public partial class FrmFilmListesi : Form
    {
        public FrmFilmListesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");

        private void FrmFilmListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            string sorgu = "SELECT * FROM Filmler ORDER BY F_Adi ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                fListesi  arac = new fListesi();
                arac.lFilmAdi.Text = oku["F_Adi"].ToString();
                arac.pbResim.ImageLocation = oku["F_Afis"].ToString();
                arac.lid.Text = oku["id"].ToString();

                ListePaneli.Controls.Add(arac);
            }
            connection.Close();

        }

        private void tY_Arama_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();

            connection.Open();

            SqlCommand ara = new SqlCommand("select * from Filmler WHERE F_Adi LIKE '%" + tY_Arama.Text + "%' ORDER BY F_Adi ASC", connection);
            SqlDataReader oku = ara.ExecuteReader();

            while (oku.Read())
            {

                fListesi arac = new fListesi();
                arac.lFilmAdi.Text = oku["F_Adi"].ToString();
                arac.pbResim.ImageLocation = oku["F_Afis"].ToString();
                arac.lid.Text = oku["id"].ToString();

                ListePaneli.Controls.Add(arac);

            }
            connection.Close();
        }
    }
}
