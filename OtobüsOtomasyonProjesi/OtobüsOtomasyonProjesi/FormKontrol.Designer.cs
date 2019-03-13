namespace OtobüsOtomasyonProjesi
{
    partial class FormKontrol
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
            this.lstPlaka = new System.Windows.Forms.ListBox();
            this.gbKontrolPanel = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSeferKalkis = new System.Windows.Forms.Label();
            this.lblHasilatt = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblHasilat = new System.Windows.Forms.Label();
            this.lblOtobus = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.cbOtobus = new System.Windows.Forms.ComboBox();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstKalkisVaris = new System.Windows.Forms.ListBox();
            this.lstTutar = new System.Windows.Forms.ListBox();
            this.lstKoltukNo = new System.Windows.Forms.ListBox();
            this.gbKontrolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPlaka
            // 
            this.lstPlaka.FormattingEnabled = true;
            this.lstPlaka.Location = new System.Drawing.Point(6, 80);
            this.lstPlaka.Name = "lstPlaka";
            this.lstPlaka.Size = new System.Drawing.Size(98, 173);
            this.lstPlaka.TabIndex = 0;
            this.lstPlaka.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // gbKontrolPanel
            // 
            this.gbKontrolPanel.Controls.Add(this.lblAdSoyad);
            this.gbKontrolPanel.Controls.Add(this.lblOtobus);
            this.gbKontrolPanel.Controls.Add(this.lblHasilatt);
            this.gbKontrolPanel.Controls.Add(this.lblSeferKalkis);
            this.gbKontrolPanel.Controls.Add(this.cbOtobus);
            this.gbKontrolPanel.Controls.Add(this.lblTutar);
            this.gbKontrolPanel.Controls.Add(this.lblTL);
            this.gbKontrolPanel.Controls.Add(this.lblKoltukNo);
            this.gbKontrolPanel.Controls.Add(this.lblHasilat);
            this.gbKontrolPanel.Controls.Add(this.lblPlaka);
            this.gbKontrolPanel.Controls.Add(this.lstAdSoyad);
            this.gbKontrolPanel.Controls.Add(this.lstKalkisVaris);
            this.gbKontrolPanel.Controls.Add(this.lstTutar);
            this.gbKontrolPanel.Controls.Add(this.lstKoltukNo);
            this.gbKontrolPanel.Controls.Add(this.lstPlaka);
            this.gbKontrolPanel.Location = new System.Drawing.Point(12, 12);
            this.gbKontrolPanel.Name = "gbKontrolPanel";
            this.gbKontrolPanel.Size = new System.Drawing.Size(536, 262);
            this.gbKontrolPanel.TabIndex = 1;
            this.gbKontrolPanel.TabStop = false;
            this.gbKontrolPanel.Text = "Kontrol Paneli";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(309, 64);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblSeferKalkis
            // 
            this.lblSeferKalkis.AutoSize = true;
            this.lblSeferKalkis.Location = new System.Drawing.Point(169, 64);
            this.lblSeferKalkis.Name = "lblSeferKalkis";
            this.lblSeferKalkis.Size = new System.Drawing.Size(101, 13);
            this.lblSeferKalkis.TabIndex = 2;
            this.lblSeferKalkis.Text = "Sefer Kalkış--->Varış";
            // 
            // lblHasilatt
            // 
            this.lblHasilatt.AutoSize = true;
            this.lblHasilatt.Location = new System.Drawing.Point(466, 31);
            this.lblHasilatt.Name = "lblHasilatt";
            this.lblHasilatt.Size = new System.Drawing.Size(13, 13);
            this.lblHasilatt.TabIndex = 2;
            this.lblHasilatt.Text = "0";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Location = new System.Drawing.Point(507, 31);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(20, 13);
            this.lblTL.TabIndex = 2;
            this.lblTL.Text = "TL";
            // 
            // lblHasilat
            // 
            this.lblHasilat.AutoSize = true;
            this.lblHasilat.Location = new System.Drawing.Point(400, 31);
            this.lblHasilat.Name = "lblHasilat";
            this.lblHasilat.Size = new System.Drawing.Size(42, 13);
            this.lblHasilat.TabIndex = 2;
            this.lblHasilat.Text = "Hasılat:";
            // 
            // lblOtobus
            // 
            this.lblOtobus.AutoSize = true;
            this.lblOtobus.Location = new System.Drawing.Point(6, 31);
            this.lblOtobus.Name = "lblOtobus";
            this.lblOtobus.Size = new System.Drawing.Size(41, 13);
            this.lblOtobus.TabIndex = 2;
            this.lblOtobus.Text = "Otobüs";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(451, 64);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(54, 13);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Tutar : TL";
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(106, 64);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(54, 13);
            this.lblKoltukNo.TabIndex = 2;
            this.lblKoltukNo.Text = "Koltuk No";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(6, 64);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 2;
            this.lblPlaka.Text = "Plaka";
            // 
            // cbOtobus
            // 
            this.cbOtobus.FormattingEnabled = true;
            this.cbOtobus.Location = new System.Drawing.Point(73, 23);
            this.cbOtobus.Name = "cbOtobus";
            this.cbOtobus.Size = new System.Drawing.Size(121, 21);
            this.cbOtobus.TabIndex = 1;
            this.cbOtobus.SelectedIndexChanged += new System.EventHandler(this.cbOtobus_SelectedIndexChanged);
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.Location = new System.Drawing.Point(313, 80);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(136, 173);
            this.lstAdSoyad.TabIndex = 0;
            this.lstAdSoyad.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lstKalkisVaris
            // 
            this.lstKalkisVaris.FormattingEnabled = true;
            this.lstKalkisVaris.Location = new System.Drawing.Point(171, 80);
            this.lstKalkisVaris.Name = "lstKalkisVaris";
            this.lstKalkisVaris.Size = new System.Drawing.Size(136, 173);
            this.lstKalkisVaris.TabIndex = 0;
            this.lstKalkisVaris.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lstTutar
            // 
            this.lstTutar.FormattingEnabled = true;
            this.lstTutar.Location = new System.Drawing.Point(455, 80);
            this.lstTutar.Name = "lstTutar";
            this.lstTutar.Size = new System.Drawing.Size(72, 173);
            this.lstTutar.TabIndex = 0;
            this.lstTutar.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lstKoltukNo
            // 
            this.lstKoltukNo.FormattingEnabled = true;
            this.lstKoltukNo.Location = new System.Drawing.Point(110, 80);
            this.lstKoltukNo.Name = "lstKoltukNo";
            this.lstKoltukNo.Size = new System.Drawing.Size(54, 173);
            this.lstKoltukNo.TabIndex = 0;
            this.lstKoltukNo.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // FormKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(561, 280);
            this.Controls.Add(this.gbKontrolPanel);
            this.Name = "FormKontrol";
            this.Text = "FormKontrol";
            this.gbKontrolPanel.ResumeLayout(false);
            this.gbKontrolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlaka;
        private System.Windows.Forms.GroupBox gbKontrolPanel;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSeferKalkis;
        private System.Windows.Forms.Label lblHasilatt;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblHasilat;
        private System.Windows.Forms.Label lblOtobus;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.ComboBox cbOtobus;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.ListBox lstKalkisVaris;
        private System.Windows.Forms.ListBox lstTutar;
        private System.Windows.Forms.ListBox lstKoltukNo;
    }
}