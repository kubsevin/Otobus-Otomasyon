using OtobüsOtomasyonProjesi.Entities;
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
    public partial class FormBiletKes : Form
    {

        OtobusContext _otobusContext = new OtobusContext();
        int _secilenOtobusID;
        public static string _KisiAdiSoyadi = "";
        public static Cinsiyet _KisiCinsiyet;

        public FormBiletKes()
        {

            InitializeComponent();

        }
        private void OtobusResmiGetir()
        {
            _secilenOtobusID = (int)cbOtobus.SelectedValue;
            Otobus O = _otobusContext.Otobusler.Find(_secilenOtobusID);
            pbOtobusResim.Image = (Image)((new ImageConverter()).ConvertFrom(O.OtobusResim));
            lblOtobusModeli.Text = O.OtobusModel;

        }
        private void ComboOtobus()
        {
            var list = _otobusContext.Otobusler.Select(x => new
            {
                x.OtobusID,
                x.Plaka,
            }).OrderBy(x => x.Plaka).ToList();
            cbOtobus.DisplayMember = "Plaka";
            cbOtobus.ValueMember = "OtobusID";
            cbOtobus.DataSource = list;
        }
        private void ComboSehirKalkis()
        {
            var kalkisSehir = _otobusContext.Sehirler.Select(x => new
            {
                x.SehirID,
                x.SehirAdi
            }).OrderBy(x => x.SehirAdi).ToList();
            cbNereden.DisplayMember = "SehirAdi";
            cbNereden.ValueMember = "SehirID";
            cbNereden.DataSource = kalkisSehir;

        }
        private void ComboSehirVaris()
        {
            var varisSehir = _otobusContext.Sehirler.Select(x => new
            {
                x.SehirID,
                x.SehirAdi
            }).Where(x => x.SehirID != (int)cbNereden.SelectedValue).OrderBy(x => x.SehirAdi).ToList();
            cbNereye.DisplayMember = "SehirAdi";
            cbNereye.ValueMember = "SehirID";
            cbNereye.DataSource = varisSehir;
        }
        private void KoltukDoldur()
        {
            Button btnKoltuk;
            var doluKoltuk = _otobusContext.BiletleriAl.Select(x => new { x.OtobusID, x.KoltukNo, x.Cinsiyet }).Where(x => x.OtobusID == _secilenOtobusID);
            bool Kontrol = false;
            foreach (var item in gbBiletKes.Controls)
            {
                

                if (item is Button)
                {
                    btnKoltuk = (Button)item;
                    
                    Kontrol = false;
                    foreach (var koltukSec in doluKoltuk)
                    {
                        if (btnKoltuk.Text == koltukSec.KoltukNo.ToString())
                        {
                            Kontrol = true;
                            if (koltukSec.Cinsiyet == Cinsiyet.Kadin)
                                btnKoltuk.BackColor = Color.Pink;
                            else
                                btnKoltuk.BackColor = Color.LightBlue;
                            btnKoltuk.Enabled = false;
                            break;
                        }
                    }
                    if (Kontrol == false)
                    {
                        btnKoltuk.BackColor = DefaultBackColor;
                        btnKoltuk.Enabled = true;
                    }
                }
                
            }
        }
        private void FormBiletKes_Load(object sender, EventArgs e)
        {
            ComboOtobus();
            ComboSehirKalkis();
            ComboSehirVaris();
            OtobusResmiGetir();
            KoltukDoldur();
        }


        private void KoltukAl_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnKoltuk = (Button)sender;
                FormKisiBilgisi KisiBilgisi = new FormKisiBilgisi();
                KisiBilgisi.ShowDialog();
                if (_KisiAdiSoyadi != "")
                {
                    string metin = btnKoltuk.Text + " numaralı koltuk " + _KisiAdiSoyadi + " kişisine ayrılacaktır, Kabul ediyor musunuz? ";
                    DialogResult BiletAl = MessageBox.Show(metin, "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (BiletAl == DialogResult.Yes)
                    {
                        MessageBox.Show("Biletiniz kesilmiştir. İyi Yolculuklar!");
                        btnKoltuk.Enabled = false;
                        if (_KisiCinsiyet == Cinsiyet.Kadin)
                            btnKoltuk.BackColor = Color.Pink;
                        else
                            btnKoltuk.BackColor = Color.LightBlue;
                        BiletAl biletAl = new BiletAl
                        {

                            OtobusID = (int)cbOtobus.SelectedValue,
                            KalkisSehriID = (int)cbNereden.SelectedValue,
                            VarisSehriID = (int)cbNereye.SelectedValue,
                            KoltukNo = Convert.ToInt32(btnKoltuk.Text),
                            YolcuAdiSoyadi = _KisiAdiSoyadi,
                            Cinsiyet = _KisiCinsiyet,
                            BiletUcreti = 100


                    };
                    _otobusContext.BiletleriAl.Add(biletAl);
                    _otobusContext.SaveChanges();
                }
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OtobusResmiGetir();
            KoltukDoldur();
        }

        private void cbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboSehirVaris();
        }


    }
}
