using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsOtomasyonProjesi
{
    public partial class FormKullaniciPaneli : Form
    {
        public FormKullaniciPaneli()
        {
            InitializeComponent();
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            FormSehir sehir = new FormSehir();
            sehir.ShowDialog();
        }

        private void btnOtobusEkle_Click(object sender, EventArgs e)
        {
            FormOtobus otobus = new FormOtobus();
            otobus.ShowDialog();
        }


    }
}
