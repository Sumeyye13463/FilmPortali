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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=LittleSky\\SQLEXPRESS;Database=FilmPortali;Trusted_Connection=True;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Yap_Click(object sender, EventArgs e)
        {
            connection.Open();
            
            SqlCommand sorgula = new SqlCommand("select * from Kullanicilar WHERE K_Adi= @username AND K_Sifre=@userpass ", connection);
            sorgula.Parameters.AddWithValue("@username", tYetk_Adi.Text);
            sorgula.Parameters.AddWithValue("@userpass", tYetk_Sifre.Text);

            SqlDataReader oku = sorgula.ExecuteReader();

            if (oku.Read())
            {
                //MessageBox.Show("Giriş başarılı.");
                FrmAnaForm frm = new FrmAnaForm();
                frm.kisiAdiSoyadi = oku["K_AdSoyad"].ToString();
                frm.Show();
                this.Hide();
                //MessageBox.Show("Kayıtlı");
            }
            else
            {
                MessageBox.Show("Kayıtlı kullanıcı yok veya bilgiler eksik.");
            }
            oku.Close();

            tYetk_Adi.Text = " ";
            tYetk_Sifre.Text = "";
            tYetk_Adi.Focus();

            connection.Close();
            //connection.Open();
            //if (connection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Bağlantı başarılı");
            //}
            //connection.Close();
        }
    }
}
