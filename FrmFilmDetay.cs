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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }

        public string idNo = "";
        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");

        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Filmler WHERE id=@p1";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pbResim.ImageLocation = oku["F_Afis"].ToString();
                lFilmAdi.Text = oku["F_Adi"].ToString();
                lBicim.Text = oku["F_Bicimi"].ToString();
                lOzellik.Text = oku["F_Ozellikleri"].ToString();
                lOyuncu.Text = oku["F_Oyunculari"].ToString();
                lYonetmen.Text = oku["F_Yonetmeni"].ToString();
                lPuan.Text = oku["F_Puan"].ToString();
                lTarih.Text = oku["F_VTarihi"].ToString();
                lDurum.Text = oku["F_Durum"].ToString();
                lDetay.Text = oku["F_Detay"].ToString();


            }
            connection.Close();
            if (lDurum.Text == "0")
            {
                lDurum.Text = "Vizyonda!";
            }
            else
            {
                lDurum.Text = "Vizyona girecek!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lTarih_Click(object sender, EventArgs e)
        {

        }

        private void lFilmAdi_Click(object sender, EventArgs e)
        {

        }

        private void lTur_Click(object sender, EventArgs e)
        {

        }

        private void lBicim_Click(object sender, EventArgs e)
        {

        }

        private void lYonetmen_Click(object sender, EventArgs e)
        {

        }

        private void lOyuncu_Click(object sender, EventArgs e)
        {

        }

        private void lOzellik_Click(object sender, EventArgs e)
        {

        }

        private void lPuan_Click(object sender, EventArgs e)
        {

        }

        private void lDurum_Click(object sender, EventArgs e)
        {

        }

        private void lDetay_Click(object sender, EventArgs e)
        {

        }
    }
}
