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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btkKullaniciPanel_Click(object sender, EventArgs e)
        {
            FormKullaniciPaneli kullaniciPaneli = new FormKullaniciPaneli();
            kullaniciPaneli.ShowDialog();

        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            FormBiletKes biletkes = new FormBiletKes();
            biletkes.ShowDialog();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            FormKontrol kontrol = new FormKontrol();
            kontrol.ShowDialog();
        }

        private void btnAracTakip_Click(object sender, EventArgs e)
        {
            FormAracTakip aracTakip = new FormAracTakip();
            aracTakip.ShowDialog();
        }
    }
}
