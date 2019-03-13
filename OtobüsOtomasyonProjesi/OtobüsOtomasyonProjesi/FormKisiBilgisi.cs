using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OtobüsOtomasyonProjesi.FormBiletKes;

namespace OtobüsOtomasyonProjesi
{
    public partial class FormKisiBilgisi : Form
    {
        public FormKisiBilgisi()
        {
            InitializeComponent();
        }

        private void btnKisiBilgi_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbKadin.Checked == true)
                    _KisiCinsiyet = Cinsiyet.Kadin;
                else
                    _KisiCinsiyet = Cinsiyet.Erkek;
                _KisiAdiSoyadi = txtAdSoyad.Text;
                Hide();
            }
            catch
            {
                MessageBox.Show("Hata oluştu");
                _KisiAdiSoyadi = "";
            }
                  
        }

        private void FormKisiBilgisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            _KisiAdiSoyadi = "";
        }
    }
}
