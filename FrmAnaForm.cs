using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmPortali1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        public string kisiAdiSoyadi = " ";
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void Y_Kayit_Click(object sender, EventArgs e)
        {
            FrmYönetmenKayit frm = new FrmYönetmenKayit();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYönetmenListesi frm = new FrmYönetmenListesi();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi frm = new FrmOyuncuListesi();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmFilmKayit frm = new FrmFilmKayit();
            frm.ShowDialog();

        }

        private void filmListesi_Click(object sender, EventArgs e)
        {
            FrmFilmListesi frm = new FrmFilmListesi();
            frm.ShowDialog();
        }
    }
}
