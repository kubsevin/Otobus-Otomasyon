namespace OtobüsOtomasyonProjesi
{
    partial class FormKisiBilgisi
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
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnKisiBilgi = new System.Windows.Forms.Button();
            this.lblCins = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.gbKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.gbKisiBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(31, 36);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // btnKisiBilgi
            // 
            this.btnKisiBilgi.Location = new System.Drawing.Point(82, 104);
            this.btnKisiBilgi.Name = "btnKisiBilgi";
            this.btnKisiBilgi.Size = new System.Drawing.Size(120, 36);
            this.btnKisiBilgi.TabIndex = 2;
            this.btnKisiBilgi.Text = "Kaydet";
            this.btnKisiBilgi.UseVisualStyleBackColor = true;
            this.btnKisiBilgi.Click += new System.EventHandler(this.btnKisiBilgi_Click);
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(31, 64);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(43, 13);
            this.lblCins.TabIndex = 0;
            this.lblCins.Text = "Cinsiyet";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(115, 33);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(118, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(115, 64);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 3;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(184, 64);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 3;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // gbKisiBilgileri
            // 
            this.gbKisiBilgileri.Controls.Add(this.lblAdSoyad);
            this.gbKisiBilgileri.Controls.Add(this.rbErkek);
            this.gbKisiBilgileri.Controls.Add(this.lblCins);
            this.gbKisiBilgileri.Controls.Add(this.rbKadin);
            this.gbKisiBilgileri.Controls.Add(this.txtAdSoyad);
            this.gbKisiBilgileri.Controls.Add(this.btnKisiBilgi);
            this.gbKisiBilgileri.Location = new System.Drawing.Point(12, 12);
            this.gbKisiBilgileri.Name = "gbKisiBilgileri";
            this.gbKisiBilgileri.Size = new System.Drawing.Size(264, 149);
            this.gbKisiBilgileri.TabIndex = 4;
            this.gbKisiBilgileri.TabStop = false;
            this.gbKisiBilgileri.Text = "Kişi Bilgileri";
            // 
            // FormKisiBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(288, 173);
            this.Controls.Add(this.gbKisiBilgileri);
            this.Name = "FormKisiBilgisi";
            this.Text = "FormKisiBilgisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKisiBilgisi_FormClosed);
            this.gbKisiBilgileri.ResumeLayout(false);
            this.gbKisiBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnKisiBilgi;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.GroupBox gbKisiBilgileri;
    }
}