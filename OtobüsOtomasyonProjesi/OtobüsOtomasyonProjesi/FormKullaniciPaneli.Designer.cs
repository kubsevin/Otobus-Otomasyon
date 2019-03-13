namespace OtobüsOtomasyonProjesi
{
    partial class FormKullaniciPaneli
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
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.btnOtobusEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSehirEkle);
            this.groupBox1.Controls.Add(this.btnOtobusEkle);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçiminizi Yapınız";
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Location = new System.Drawing.Point(6, 30);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(103, 141);
            this.btnSehirEkle.TabIndex = 0;
            this.btnSehirEkle.Text = "Şehir Ekle";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // btnOtobusEkle
            // 
            this.btnOtobusEkle.Location = new System.Drawing.Point(128, 30);
            this.btnOtobusEkle.Name = "btnOtobusEkle";
            this.btnOtobusEkle.Size = new System.Drawing.Size(103, 141);
            this.btnOtobusEkle.TabIndex = 0;
            this.btnOtobusEkle.Text = "Otobüs Ekle";
            this.btnOtobusEkle.UseVisualStyleBackColor = true;
            this.btnOtobusEkle.Click += new System.EventHandler(this.btnOtobusEkle_Click);
            // 
            // FormKullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(256, 207);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKullaniciPaneli";
            this.Text = "FormKullaniciPaneli";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.Button btnOtobusEkle;
    }
}