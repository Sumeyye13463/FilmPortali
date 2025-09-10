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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");
        private void btnRYukle_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sorgu = " select * from Yonetmenler WHERE ID = @p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read())
            {

                MessageBox.Show( "BİYOGRAFİ: "+ read["Y_Biyografi"].ToString(), read["Y_AdSoyad"].ToString());
            }
            connection.Close();
        }

        private void Y_Silme_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand sil = new SqlCommand("delete from Yonetmenler WHERE ID = @p1", connection);
            sil.Parameters.AddWithValue("@p1", lblID.Text);
            sil.ExecuteNonQuery();
            connection.Close();
            this.Hide(); //kullanılan user control aracını gizler.
            MessageBox.Show(lblAdSoyad + " kişisinin kaydı silindi, lütfen sayfayı kapatıp yeniden açın.");
        }

        private void YonetmenListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
