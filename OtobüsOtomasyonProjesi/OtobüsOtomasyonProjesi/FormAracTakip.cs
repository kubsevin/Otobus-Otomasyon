using OtobüsOtomasyonProjesi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsOtomasyonProjesi
{
    public partial class FormAracTakip : Form
    {
        OtobusContext _otobusContext = new OtobusContext();
        int _secilenOtobusID;
        public FormAracTakip()
        {
            InitializeComponent();
            OtobusGetir();
        }
        private void OtobusGetir()
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

        private void cbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {

            _secilenOtobusID = (int)cbOtobus.SelectedValue;
            var KisiAdetGetir = (from x in _otobusContext.BiletleriAl
                                 where x.OtobusID == _secilenOtobusID
                                 select x).Count();
            txtKisiSayisi.Text = KisiAdetGetir.ToString();

            List<string> KalkisSehirAdi = new List<string>();
            foreach (var item in _otobusContext.BiletleriAl.Select(x => new { x.KalkisSehriID, x.VarisSehriID }))
            {
                Sehir kalkisSehri = _otobusContext.Sehirler.FirstOrDefault(x => x.SehirID == item.KalkisSehriID);
                Sehir varisSehri = _otobusContext.Sehirler.FirstOrDefault(x => x.SehirID == item.VarisSehriID);
                KalkisSehirAdi.Add(kalkisSehri.SehirAdi + "-->" + varisSehri.SehirAdi);
            }
            for (int i = 0; i < KalkisSehirAdi.Count; i++)
            {
                txtSefer.Text = KalkisSehirAdi[i];
            }
        }

        private void btnAracHareketlendir_Click(object sender, EventArgs e)
        {
            if (txtKisiSayisi.Text !="" && txtKisiSayisi.Text!="0")
            {
                AracTakip aracTakip = new AracTakip
                {
                    AracPlaka = cbOtobus.Text,
                    AracToplamTutar = Convert.ToInt32(txtKisiSayisi.Text) * 100,
                    AracHareketTarihi = DateTime.Now
                };

                var SilinecekBiletlerim = (from x in _otobusContext.BiletleriAl
                                           where x.OtobusID == _secilenOtobusID
                                           select x);
                foreach (var item in SilinecekBiletlerim)
                {
                    BiletAl bAl = _otobusContext.BiletleriAl.Find(item.BiletAlID);
                    _otobusContext.BiletleriAl.Remove(bAl);
                }

                _otobusContext.AraclariTakip.Add(aracTakip);
                _otobusContext.SaveChanges();
                lstPlaka.Items.Add(cbOtobus.Text);
                lstHasilat.Items.Add((Convert.ToInt32(txtKisiSayisi.Text) * 100));
                lstTarih.Items.Add(DateTime.Now);
                txtKisiSayisi.Text = "0";
                txtSefer.Text = "";
            }
        }

        private void btnAracDurumKaydet_Click(object sender, EventArgs e)
        {
            lstHasilat.Items.Clear();
            lstPlaka.Items.Clear();
            lstTarih.Items.Clear();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            StreamWriter VerileriYaz = new StreamWriter(path+@"\AracArsiv.txt");
            for (int i = 0; i < lstPlaka.Items.Count; i++)
            {
                VerileriYaz.WriteLine(lstPlaka.Items[i] + " - " + lstTarih.Items[i] + " - " + lstHasilat.Items[i]);
            }
            VerileriYaz.Close();
            MessageBox.Show("Verileriniz Masaüstüne AracArsiv.txt Dosyası Olarak Kaydedilmiştir.");
        }

        private void btnGunlukArsiv_Click(object sender, EventArgs e)
        {
            lstGunlukKayitArsivi.Items.Clear();
            var GunlukArsiv =(from x in _otobusContext.AraclariTakip
                              where x.AracHareketTarihi.Day == DateTime.Now.Day
                              select x);
            foreach (var item in GunlukArsiv)
            {
                lstGunlukKayitArsivi.Items.Add(item.AracPlaka + " - " + item.AracHareketTarihi + " - " + item.AracToplamTutar);
            }
        }
    }
}
