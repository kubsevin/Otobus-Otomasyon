namespace OtobüsOtomasyonProjesi
{
    partial class FormAracTakip
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
            this.gbAracTakip = new System.Windows.Forms.GroupBox();
            this.btnAracDurumKaydet = new System.Windows.Forms.Button();
            this.btnGunlukArsiv = new System.Windows.Forms.Button();
            this.lstGunlukKayitArsivi = new System.Windows.Forms.ListBox();
            this.lstTarih = new System.Windows.Forms.ListBox();
            this.lstHasilat = new System.Windows.Forms.ListBox();
            this.lstPlaka = new System.Windows.Forms.ListBox();
            this.txtSefer = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.cbOtobus = new System.Windows.Forms.ComboBox();
            this.btnAracHareketlendir = new System.Windows.Forms.Button();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblSefer = new System.Windows.Forms.Label();
            this.lblHasilat = new System.Windows.Forms.Label();
            this.lblGunlukKayit = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblOtobus = new System.Windows.Forms.Label();
            this.gbGunlukArsiv = new System.Windows.Forms.GroupBox();
            this.gbAracDurumKaydet = new System.Windows.Forms.GroupBox();
            this.gbAracTakip.SuspendLayout();
            this.gbGunlukArsiv.SuspendLayout();
            this.gbAracDurumKaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAracTakip
            // 
            this.gbAracTakip.Controls.Add(this.txtSefer);
            this.gbAracTakip.Controls.Add(this.txtKisiSayisi);
            this.gbAracTakip.Controls.Add(this.cbOtobus);
            this.gbAracTakip.Controls.Add(this.btnAracHareketlendir);
            this.gbAracTakip.Controls.Add(this.lblKisiSayisi);
            this.gbAracTakip.Controls.Add(this.lblSefer);
            this.gbAracTakip.Controls.Add(this.lblOtobus);
            this.gbAracTakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAracTakip.Location = new System.Drawing.Point(12, 3);
            this.gbAracTakip.Name = "gbAracTakip";
            this.gbAracTakip.Size = new System.Drawing.Size(317, 144);
            this.gbAracTakip.TabIndex = 0;
            this.gbAracTakip.TabStop = false;
            this.gbAracTakip.Text = "Araç Takip";
            // 
            // btnAracDurumKaydet
            // 
            this.btnAracDurumKaydet.Location = new System.Drawing.Point(545, 96);
            this.btnAracDurumKaydet.Name = "btnAracDurumKaydet";
            this.btnAracDurumKaydet.Size = new System.Drawing.Size(120, 39);
            this.btnAracDurumKaydet.TabIndex = 5;
            this.btnAracDurumKaydet.Text = "Araç Durum Kaydet";
            this.btnAracDurumKaydet.UseVisualStyleBackColor = true;
            this.btnAracDurumKaydet.Click += new System.EventHandler(this.btnAracDurumKaydet_Click);
            // 
            // btnGunlukArsiv
            // 
            this.btnGunlukArsiv.Location = new System.Drawing.Point(223, 92);
            this.btnGunlukArsiv.Name = "btnGunlukArsiv";
            this.btnGunlukArsiv.Size = new System.Drawing.Size(119, 39);
            this.btnGunlukArsiv.TabIndex = 5;
            this.btnGunlukArsiv.Text = "Günlük Arşiv";
            this.btnGunlukArsiv.UseVisualStyleBackColor = true;
            this.btnGunlukArsiv.Click += new System.EventHandler(this.btnGunlukArsiv_Click);
            // 
            // lstGunlukKayitArsivi
            // 
            this.lstGunlukKayitArsivi.FormattingEnabled = true;
            this.lstGunlukKayitArsivi.Location = new System.Drawing.Point(6, 43);
            this.lstGunlukKayitArsivi.Name = "lstGunlukKayitArsivi";
            this.lstGunlukKayitArsivi.Size = new System.Drawing.Size(204, 95);
            this.lstGunlukKayitArsivi.TabIndex = 4;
            // 
            // lstTarih
            // 
            this.lstTarih.FormattingEnabled = true;
            this.lstTarih.Location = new System.Drawing.Point(166, 40);
            this.lstTarih.Name = "lstTarih";
            this.lstTarih.Size = new System.Drawing.Size(216, 95);
            this.lstTarih.TabIndex = 4;
            // 
            // lstHasilat
            // 
            this.lstHasilat.FormattingEnabled = true;
            this.lstHasilat.Location = new System.Drawing.Point(405, 40);
            this.lstHasilat.Name = "lstHasilat";
            this.lstHasilat.Size = new System.Drawing.Size(120, 95);
            this.lstHasilat.TabIndex = 4;
            // 
            // lstPlaka
            // 
            this.lstPlaka.FormattingEnabled = true;
            this.lstPlaka.Location = new System.Drawing.Point(25, 40);
            this.lstPlaka.Name = "lstPlaka";
            this.lstPlaka.Size = new System.Drawing.Size(120, 95);
            this.lstPlaka.TabIndex = 4;
            // 
            // txtSefer
            // 
            this.txtSefer.Enabled = false;
            this.txtSefer.Location = new System.Drawing.Point(166, 40);
            this.txtSefer.Name = "txtSefer";
            this.txtSefer.Size = new System.Drawing.Size(132, 20);
            this.txtSefer.TabIndex = 3;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Enabled = false;
            this.txtKisiSayisi.Location = new System.Drawing.Point(10, 92);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(135, 20);
            this.txtKisiSayisi.TabIndex = 3;
            // 
            // cbOtobus
            // 
            this.cbOtobus.FormattingEnabled = true;
            this.cbOtobus.Location = new System.Drawing.Point(13, 40);
            this.cbOtobus.Name = "cbOtobus";
            this.cbOtobus.Size = new System.Drawing.Size(132, 21);
            this.cbOtobus.TabIndex = 2;
            this.cbOtobus.SelectedIndexChanged += new System.EventHandler(this.cbOtobus_SelectedIndexChanged);
            // 
            // btnAracHareketlendir
            // 
            this.btnAracHareketlendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracHareketlendir.Location = new System.Drawing.Point(166, 73);
            this.btnAracHareketlendir.Name = "btnAracHareketlendir";
            this.btnAracHareketlendir.Size = new System.Drawing.Size(112, 39);
            this.btnAracHareketlendir.TabIndex = 1;
            this.btnAracHareketlendir.Text = "Araç Hareketlendir";
            this.btnAracHareketlendir.UseVisualStyleBackColor = true;
            this.btnAracHareketlendir.Click += new System.EventHandler(this.btnAracHareketlendir_Click);
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(10, 73);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(53, 13);
            this.lblKisiSayisi.TabIndex = 0;
            this.lblKisiSayisi.Text = "Kişi Sayısı";
            // 
            // lblSefer
            // 
            this.lblSefer.AutoSize = true;
            this.lblSefer.Location = new System.Drawing.Point(163, 24);
            this.lblSefer.Name = "lblSefer";
            this.lblSefer.Size = new System.Drawing.Size(32, 13);
            this.lblSefer.TabIndex = 0;
            this.lblSefer.Text = "Sefer";
            // 
            // lblHasilat
            // 
            this.lblHasilat.AutoSize = true;
            this.lblHasilat.Location = new System.Drawing.Point(402, 22);
            this.lblHasilat.Name = "lblHasilat";
            this.lblHasilat.Size = new System.Drawing.Size(77, 13);
            this.lblHasilat.TabIndex = 0;
            this.lblHasilat.Text = "Toplam Hasılat";
            // 
            // lblGunlukKayit
            // 
            this.lblGunlukKayit.AutoSize = true;
            this.lblGunlukKayit.Location = new System.Drawing.Point(6, 27);
            this.lblGunlukKayit.Name = "lblGunlukKayit";
            this.lblGunlukKayit.Size = new System.Drawing.Size(95, 13);
            this.lblGunlukKayit.TabIndex = 0;
            this.lblGunlukKayit.Text = "Günlük Kayıt Arşivi";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(164, 22);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(22, 22);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblOtobus
            // 
            this.lblOtobus.AutoSize = true;
            this.lblOtobus.Location = new System.Drawing.Point(10, 22);
            this.lblOtobus.Name = "lblOtobus";
            this.lblOtobus.Size = new System.Drawing.Size(41, 13);
            this.lblOtobus.TabIndex = 0;
            this.lblOtobus.Text = "Otobüs";
            // 
            // gbGunlukArsiv
            // 
            this.gbGunlukArsiv.Controls.Add(this.lstGunlukKayitArsivi);
            this.gbGunlukArsiv.Controls.Add(this.btnGunlukArsiv);
            this.gbGunlukArsiv.Controls.Add(this.lblGunlukKayit);
            this.gbGunlukArsiv.Location = new System.Drawing.Point(335, 3);
            this.gbGunlukArsiv.Name = "gbGunlukArsiv";
            this.gbGunlukArsiv.Size = new System.Drawing.Size(348, 144);
            this.gbGunlukArsiv.TabIndex = 1;
            this.gbGunlukArsiv.TabStop = false;
            this.gbGunlukArsiv.Text = "Günlük Arşiv";
            // 
            // gbAracDurumKaydet
            // 
            this.gbAracDurumKaydet.Controls.Add(this.lstPlaka);
            this.gbAracDurumKaydet.Controls.Add(this.btnAracDurumKaydet);
            this.gbAracDurumKaydet.Controls.Add(this.lblHasilat);
            this.gbAracDurumKaydet.Controls.Add(this.lblTarih);
            this.gbAracDurumKaydet.Controls.Add(this.lstTarih);
            this.gbAracDurumKaydet.Controls.Add(this.lblPlaka);
            this.gbAracDurumKaydet.Controls.Add(this.lstHasilat);
            this.gbAracDurumKaydet.Location = new System.Drawing.Point(12, 150);
            this.gbAracDurumKaydet.Name = "gbAracDurumKaydet";
            this.gbAracDurumKaydet.Size = new System.Drawing.Size(671, 141);
            this.gbAracDurumKaydet.TabIndex = 6;
            this.gbAracDurumKaydet.TabStop = false;
            this.gbAracDurumKaydet.Text = "Araç Durum Kaydet";
            // 
            // FormAracTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(688, 300);
            this.Controls.Add(this.gbAracDurumKaydet);
            this.Controls.Add(this.gbGunlukArsiv);
            this.Controls.Add(this.gbAracTakip);
            this.Name = "FormAracTakip";
            this.Text = "FormAracTakip";
            this.gbAracTakip.ResumeLayout(false);
            this.gbAracTakip.PerformLayout();
            this.gbGunlukArsiv.ResumeLayout(false);
            this.gbGunlukArsiv.PerformLayout();
            this.gbAracDurumKaydet.ResumeLayout(false);
            this.gbAracDurumKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracTakip;
        private System.Windows.Forms.Button btnAracDurumKaydet;
        private System.Windows.Forms.Button btnGunlukArsiv;
        private System.Windows.Forms.ListBox lstGunlukKayitArsivi;
        private System.Windows.Forms.ListBox lstTarih;
        private System.Windows.Forms.ListBox lstHasilat;
        private System.Windows.Forms.ListBox lstPlaka;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.ComboBox cbOtobus;
        private System.Windows.Forms.Button btnAracHareketlendir;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label lblSefer;
        private System.Windows.Forms.Label lblHasilat;
        private System.Windows.Forms.Label lblGunlukKayit;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblOtobus;
        private System.Windows.Forms.TextBox txtSefer;
        private System.Windows.Forms.GroupBox gbGunlukArsiv;
        private System.Windows.Forms.GroupBox gbAracDurumKaydet;
    }
}