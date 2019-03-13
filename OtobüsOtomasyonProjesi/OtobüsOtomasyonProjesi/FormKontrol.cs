using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtobüsOtomasyonProjesi.Entities;

namespace OtobüsOtomasyonProjesi
{
    public partial class FormKontrol : Form
    {
        OtobusContext _otobusContext = new OtobusContext();
        int _secilenOtobusID;
        public FormKontrol()
        {
            InitializeComponent();
            VeriGetir();
            OtobusGetir();
        }
        public void VeriGetir()
        {
            List<string> KalkisSehirAdi = new List<string>();
            foreach (var item in _otobusContext.BiletleriAl.Select(x => new { x.KalkisSehriID, x.VarisSehriID }))
            {
                Sehir kalkisSehri = _otobusContext.Sehirler.FirstOrDefault(x=>x.SehirID == item.KalkisSehriID);
                Sehir varisSehri = _otobusContext.Sehirler.FirstOrDefault(x => x.SehirID == item.VarisSehriID);
                KalkisSehirAdi.Add(kalkisSehri.SehirAdi+ "-->"+ varisSehri.SehirAdi);
            }
        

            lstAdSoyad.Items.AddRange(_otobusContext.BiletleriAl.Select(x => x.YolcuAdiSoyadi).ToArray());
            lstPlaka.Items.AddRange(_otobusContext.BiletleriAl.Select(x => x.Otobus.Plaka).ToArray());
            lstKoltukNo.Items.AddRange(_otobusContext.BiletleriAl.Select(x => x.KoltukNo.ToString()).ToArray());
            lstTutar.Items.AddRange(_otobusContext.BiletleriAl.Select(x =>  (x.BiletUcreti).ToString()).ToArray());
            lstKalkisVaris.Items.AddRange(KalkisSehirAdi.ToArray());
        

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
            var HasilatGetir = from x in _otobusContext.BiletleriAl
                                  where x.OtobusID == _secilenOtobusID
                                  select x.BiletUcreti;
            int topla=0;
            foreach (var item in HasilatGetir)
            {
                topla += item;
            }
            lblHasilatt.Text = topla.ToString();

        }
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in gbKontrolPanel.Controls)
            {
                if (item is ListBox)
                {
                    var secilenDeger = (ListBox)sender;
                    ((ListBox)item).SelectedIndex = secilenDeger.SelectedIndex;

                }
            }
        }
    }
}
