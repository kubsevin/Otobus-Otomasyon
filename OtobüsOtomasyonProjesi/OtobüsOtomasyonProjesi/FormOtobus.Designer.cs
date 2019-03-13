namespace OtobüsOtomasyonProjesi
{
    partial class FormOtobus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOtobusResim = new System.Windows.Forms.Label();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pbOtobus = new System.Windows.Forms.PictureBox();
            this.dgvOtobusEkle = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblOtobusModeli = new System.Windows.Forms.Label();
            this.txtOtobusModeli = new System.Windows.Forms.TextBox();
            this.lblPlakaNo = new System.Windows.Forms.Label();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOtobus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOtobusResim);
            this.groupBox1.Controls.Add(this.btnResimSec);
            this.groupBox1.Controls.Add(this.pbOtobus);
            this.groupBox1.Controls.Add(this.dgvOtobusEkle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.lblOtobusModeli);
            this.groupBox1.Controls.Add(this.txtOtobusModeli);
            this.groupBox1.Controls.Add(this.lblPlakaNo);
            this.groupBox1.Controls.Add(this.txtPlakaNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otobüs Ekle";
            // 
            // lblOtobusResim
            // 
            this.lblOtobusResim.AutoSize = true;
            this.lblOtobusResim.Location = new System.Drawing.Point(6, 126);
            this.lblOtobusResim.Name = "lblOtobusResim";
            this.lblOtobusResim.Size = new System.Drawing.Size(73, 13);
            this.lblOtobusResim.TabIndex = 20;
            this.lblOtobusResim.Text = "Otobüs Resmi";
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(100, 116);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(75, 34);
            this.btnResimSec.TabIndex = 2;
            this.btnResimSec.Text = "Dosya Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pbOtobus
            // 
            this.pbOtobus.Location = new System.Drawing.Point(278, 19);
            this.pbOtobus.Name = "pbOtobus";
            this.pbOtobus.Size = new System.Drawing.Size(163, 190);
            this.pbOtobus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOtobus.TabIndex = 18;
            this.pbOtobus.TabStop = false;
            // 
            // dgvOtobusEkle
            // 
            this.dgvOtobusEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtobusEkle.Location = new System.Drawing.Point(6, 215);
            this.dgvOtobusEkle.Name = "dgvOtobusEkle";
            this.dgvOtobusEkle.Size = new System.Drawing.Size(435, 228);
            this.dgvOtobusEkle.TabIndex = 17;
            this.dgvOtobusEkle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOtobusEkle_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(197, 175);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 34);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(100, 175);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 34);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(9, 175);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 34);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // lblOtobusModeli
            // 
            this.lblOtobusModeli.AutoSize = true;
            this.lblOtobusModeli.Location = new System.Drawing.Point(6, 84);
            this.lblOtobusModeli.Name = "lblOtobusModeli";
            this.lblOtobusModeli.Size = new System.Drawing.Size(75, 13);
            this.lblOtobusModeli.TabIndex = 12;
            this.lblOtobusModeli.Text = "Otobüs Modeli";
            // 
            // txtOtobusModeli
            // 
            this.txtOtobusModeli.Location = new System.Drawing.Point(100, 81);
            this.txtOtobusModeli.Name = "txtOtobusModeli";
            this.txtOtobusModeli.Size = new System.Drawing.Size(172, 20);
            this.txtOtobusModeli.TabIndex = 1;
            // 
            // lblPlakaNo
            // 
            this.lblPlakaNo.AutoSize = true;
            this.lblPlakaNo.Location = new System.Drawing.Point(6, 41);
            this.lblPlakaNo.Name = "lblPlakaNo";
            this.lblPlakaNo.Size = new System.Drawing.Size(84, 13);
            this.lblPlakaNo.TabIndex = 12;
            this.lblPlakaNo.Text = "Plaka Numarası:";
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Location = new System.Drawing.Point(100, 38);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.Size = new System.Drawing.Size(172, 20);
            this.txtPlakaNo.TabIndex = 0;
            // 
            // FormOtobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(471, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOtobus";
            this.Text = "FormOtobus";
            this.Load += new System.EventHandler(this.FormOtobus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOtobus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblPlakaNo;
        private System.Windows.Forms.Label lblOtobusResim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pbOtobus;
        private System.Windows.Forms.DataGridView dgvOtobusEkle;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.Label lblOtobusModeli;
        private System.Windows.Forms.TextBox txtOtobusModeli;
    }
}