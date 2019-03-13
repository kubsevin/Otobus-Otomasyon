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
    public partial class FormSehir : Form
    {
        public FormSehir()
        {
            InitializeComponent();
        }
        OtobusContext db = new OtobusContext();
        int secilenID;

        private void dgvSehirler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dgvSehirler.CurrentRow.Cells[0].Value);
            Sehir sehir = db.Sehirler.Find(secilenID);
            txtSehir.Text = sehir.SehirAdi;
        }

        private void FormSehir_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            var list = db.Sehirler.Select(x => new
            {
                x.SehirID,
                x.SehirNo,
                x.SehirAdi
                
            }).ToList();

            dgvSehirler.DataSource = list;
            dgvSehirler.Columns["SehirID"].Visible = false;
            txtSehir.Clear();
            txtSehirPlakaNo.Clear();
            txtSehir.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Sehir sehir = new Sehir
                {
                    SehirAdi = txtSehir.Text,
                    SehirNo = Convert.ToInt32(txtSehirPlakaNo.Text)
                };
                db.Sehirler.Add(sehir);
                db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Sehir sehir = db.Sehirler.Find(secilenID);
                sehir.SehirAdi = txtSehir.Text;
                sehir.SehirNo = Convert.ToInt32(txtSehirPlakaNo.Text);
                db.SaveChanges();
                Listele();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Sehir sehir = db.Sehirler.Find(secilenID);
                db.Sehirler.Remove(sehir);
                db.SaveChanges();
                Listele();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
