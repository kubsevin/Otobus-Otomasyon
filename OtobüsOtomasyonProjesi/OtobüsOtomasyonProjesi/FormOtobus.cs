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
    public partial class FormOtobus : Form
    {
        private OtobusContext _otobuscontext;
        public int _SecilenID;
        public FormOtobus()
        {
            InitializeComponent();
            _otobuscontext = new OtobusContext();
            OtobusListesiDoldur();
        }
        private void OtobusListesiDoldur()
        {
            var list = _otobuscontext.Otobusler.Select(x => new
            {

                x.OtobusID,
                x.OtobusModel,
                x.Plaka,
                x.OtobusResim

            }).ToList();
            dgvOtobusEkle.DataSource = list;
            dgvOtobusEkle.Columns["OtobusID"].Visible = false;
            dgvOtobusEkle.Columns["OtobusResim"].Visible = false;

            txtOtobusModeli.Clear();
            txtPlakaNo.Clear();
            txtPlakaNo.Focus();

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOtobusModeli.Text) == false && string.IsNullOrWhiteSpace(txtPlakaNo.Text) == false)
            {
                var otobus = new Otobus
                {
                    OtobusModel = txtOtobusModeli.Text,
                    Plaka = txtPlakaNo.Text,
                    OtobusResim = ImageToByteArray(pbOtobus.Image)
                };
                _otobuscontext.Otobusler.Add(otobus);
                _otobuscontext.SaveChanges();
                OtobusListesiDoldur();
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Otobus O = _otobuscontext.Otobusler.Find(_SecilenID);
                O.Plaka = txtPlakaNo.Text;
                O.OtobusModel = txtOtobusModeli.Text;
                O.OtobusResim = pbOtobus.Image != null ? ImageToByteArray(pbOtobus.Image) : O.OtobusResim;
                _otobuscontext.SaveChanges();
                OtobusListesiDoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen hata oluştu.");
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                Otobus O = _otobuscontext.Otobusler.Find(_SecilenID);
                _otobuscontext.Otobusler.Remove(O);
                _otobuscontext.SaveChanges();
                OtobusListesiDoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen hata oluştu.");
            }

        }

        private void FormOtobus_Load(object sender, EventArgs e)
        {
            OtobusListesiDoldur();
        }
        private void dgvOtobusEkle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _SecilenID = Convert.ToInt32(dgvOtobusEkle.CurrentRow.Cells[0].Value);
            Otobus o = _otobuscontext.Otobusler.Find(_SecilenID);
            txtPlakaNo.Text = o.Plaka;
            txtOtobusModeli.Text = o.OtobusModel;
            pbOtobus.Image = (Image)((new ImageConverter()).ConvertFrom(o.OtobusResim));
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusImage = new OpenFileDialog();
            BusImage.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (BusImage.ShowDialog() == DialogResult.OK)
            {
                pbOtobus.Image = new Bitmap(BusImage.FileName);
            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


    } 
}
