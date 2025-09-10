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
    public partial class yListesi : UserControl
    {
        public yListesi()
        {
            InitializeComponent();
            lAdi.Click += lAdi_Click;
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");

        private void lAdi_Click(object sender, EventArgs e)
        {
            if (lAdi.ForeColor == Color.FromArgb(17, 28, 43)) // seçilmemişse
            {
                lAdi.ForeColor = Color.FromArgb(249, 164, 26);
                connection.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO F_Secilenler (Kisi, Tur) VALUES (@kisi, @tur)", connection);
                komut.Parameters.AddWithValue("@kisi", lAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else // seçiliyse geri al
            {
                lAdi.ForeColor = Color.FromArgb(17, 28, 43);
                connection.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM F_Secilenler WHERE Kisi = @kisi AND Tur = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void yListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
