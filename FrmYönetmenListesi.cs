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
    public partial class FrmYönetmenListesi : Form
    {
        public FrmYönetmenListesi()
        {
            InitializeComponent();

            this.Visible = true;
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;"); 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYönetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();

            connection.Open();

            string sorgu = " select * from Yonetmenler ORDER BY Y_AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) { 
            
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblID.Text = read["ID"].ToString();
                arac.lblAdSoyad.Text = read["Y_AdSoyad"].ToString();
                arac.pbResimDetay.ImageLocation = read["Y_Resmi"].ToString() ;
                ListePaneli.Controls.Add(arac);
            }

            connection.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tY_Arama_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();

            connection.Open();

            SqlCommand ara = new SqlCommand("select * from Yonetmenler WHERE Y_AdSoyad LIKE '%"+ tY_Arama.Text+ "%' ORDER BY Y_AdSoyad ASC", connection);
            SqlDataReader read = ara.ExecuteReader();

            while (read.Read())
            {

                YonetmenListesi arac = new YonetmenListesi();
                arac.lblID.Text = read["ID"].ToString();
                arac.lblAdSoyad.Text = read["Y_AdSoyad"].ToString();
                arac.pbResimDetay.ImageLocation = read["Y_Resmi"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            connection.Close();
        }
    }
}
