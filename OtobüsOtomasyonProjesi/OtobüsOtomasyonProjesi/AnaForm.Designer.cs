namespace OtobüsOtomasyonProjesi
{
    partial class AnaForm
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
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnBiletKes = new System.Windows.Forms.Button();
            this.btnAracTakip = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btkKullaniciPanel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.LightGray;
            this.btnKontrol.Location = new System.Drawing.Point(127, 18);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(115, 145);
            this.btnKontrol.TabIndex = 0;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnBiletKes
            // 
            this.btnBiletKes.BackColor = System.Drawing.Color.LightGray;
            this.btnBiletKes.ForeColor = System.Drawing.Color.Black;
            this.btnBiletKes.Location = new System.Drawing.Point(6, 18);
            this.btnBiletKes.Name = "btnBiletKes";
            this.btnBiletKes.Size = new System.Drawing.Size(115, 145);
            this.btnBiletKes.TabIndex = 0;
            this.btnBiletKes.Text = "Bilet Kes";
            this.btnBiletKes.UseVisualStyleBackColor = false;
            this.btnBiletKes.Click += new System.EventHandler(this.btnBiletKes_Click);
            // 
            // btnAracTakip
            // 
            this.btnAracTakip.BackColor = System.Drawing.Color.LightGray;
            this.btnAracTakip.Location = new System.Drawing.Point(248, 18);
            this.btnAracTakip.Name = "btnAracTakip";
            this.btnAracTakip.Size = new System.Drawing.Size(115, 145);
            this.btnAracTakip.TabIndex = 0;
            this.btnAracTakip.Text = "Araç Takip";
            this.btnAracTakip.UseVisualStyleBackColor = false;
            this.btnAracTakip.Click += new System.EventHandler(this.btnAracTakip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btkKullaniciPanel);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // btkKullaniciPanel
            // 
            this.btkKullaniciPanel.BackColor = System.Drawing.Color.LightGray;
            this.btkKullaniciPanel.ForeColor = System.Drawing.Color.Black;
            this.btkKullaniciPanel.Location = new System.Drawing.Point(26, 19);
            this.btkKullaniciPanel.Name = "btkKullaniciPanel";
            this.btkKullaniciPanel.Size = new System.Drawing.Size(115, 145);
            this.btkKullaniciPanel.TabIndex = 0;
            this.btkKullaniciPanel.Text = "Kullanıcı Paneli";
            this.btkKullaniciPanel.UseVisualStyleBackColor = false;
            this.btkKullaniciPanel.Click += new System.EventHandler(this.btkKullaniciPanel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBiletKes);
            this.groupBox2.Controls.Add(this.btnKontrol);
            this.groupBox2.Controls.Add(this.btnAracTakip);
            this.groupBox2.Location = new System.Drawing.Point(188, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Girişi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(571, 198);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Button btnBiletKes;
        private System.Windows.Forms.Button btnAracTakip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btkKullaniciPanel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

