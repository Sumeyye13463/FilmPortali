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
    public partial class fListesi : UserControl
    {
        public fListesi()
        {
            InitializeComponent();
        }

        private void btnFYukle_Click(object sender, EventArgs e)
        {
            FrmFilmDetay frm = new FrmFilmDetay();
            frm.idNo = lid.Text;
            frm.ShowDialog();

        }
    }
}
