namespace _11253006_DBProject
{
    partial class TedarikciGuncelle
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
            this.textBoxTedarikciIletisimİsmi = new System.Windows.Forms.TextBox();
            this.textBoxTedarikciAdres = new System.Windows.Forms.TextBox();
            this.textBoxTedarikciTelefon = new System.Windows.Forms.TextBox();
            this.textBoxTedarikciUlke = new System.Windows.Forms.TextBox();
            this.textBoxTedarikciSehir = new System.Windows.Forms.TextBox();
            this.textBoxTedarikciAdi = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTedarikciIletisimİsmi
            // 
            this.textBoxTedarikciIletisimİsmi.Location = new System.Drawing.Point(256, 115);
            this.textBoxTedarikciIletisimİsmi.Name = "textBoxTedarikciIletisimİsmi";
            this.textBoxTedarikciIletisimİsmi.Size = new System.Drawing.Size(194, 22);
            this.textBoxTedarikciIletisimİsmi.TabIndex = 57;
            this.textBoxTedarikciIletisimİsmi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressLetter);
            // 
            // textBoxTedarikciAdres
            // 
            this.textBoxTedarikciAdres.Location = new System.Drawing.Point(256, 195);
            this.textBoxTedarikciAdres.Name = "textBoxTedarikciAdres";
            this.textBoxTedarikciAdres.Size = new System.Drawing.Size(194, 22);
            this.textBoxTedarikciAdres.TabIndex = 56;
            // 
            // textBoxTedarikciTelefon
            // 
            this.textBoxTedarikciTelefon.Location = new System.Drawing.Point(256, 445);
            this.textBoxTedarikciTelefon.Name = "textBoxTedarikciTelefon";
            this.textBoxTedarikciTelefon.Size = new System.Drawing.Size(194, 22);
            this.textBoxTedarikciTelefon.TabIndex = 55;
            this.textBoxTedarikciTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressNumber);
            // 
            // textBoxTedarikciUlke
            // 
            this.textBoxTedarikciUlke.Location = new System.Drawing.Point(256, 365);
            this.textBoxTedarikciUlke.Name = "textBoxTedarikciUlke";
            this.textBoxTedarikciUlke.Size = new System.Drawing.Size(194, 22);
            this.textBoxTedarikciUlke.TabIndex = 54;
            this.textBoxTedarikciUlke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressLetter);
            // 
            // textBoxTedarikciSehir
            // 
            this.textBoxTedarikciSehir.Location = new System.Drawing.Point(256, 275);
            this.textBoxTedarikciSehir.Name = "textBoxTedarikciSehir";
            this.textBoxTedarikciSehir.Size = new System.Drawing.Size(194, 22);
            this.textBoxTedarikciSehir.TabIndex = 53;
            this.textBoxTedarikciSehir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressLetter);
            // 
            // textBoxTedarikciAdi
            // 
            this.textBoxTedarikciAdi.Location = new System.Drawing.Point(256, 35);
            this.textBoxTedarikciAdi.Name = "textBoxTedarikciAdi";
            this.textBoxTedarikciAdi.Size = new System.Drawing.Size(194, 22);
            this.textBoxTedarikciAdi.TabIndex = 52;
            this.textBoxTedarikciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressLetter);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Firebrick;
            this.btnIptal.Location = new System.Drawing.Point(279, 542);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(150, 75);
            this.btnIptal.TabIndex = 51;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGuncelle.Location = new System.Drawing.Point(62, 542);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 75);
            this.btnGuncelle.TabIndex = 50;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(29, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "TELEFON:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(29, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "ÜLKE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "İLETİŞİM İSMİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "ADRESİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(29, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "ŞEHİR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "TEDARİKÇİ ADI:";
            // 
            // TedarikciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::_11253006_DBProject.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 649);
            this.Controls.Add(this.textBoxTedarikciIletisimİsmi);
            this.Controls.Add(this.textBoxTedarikciAdres);
            this.Controls.Add(this.textBoxTedarikciTelefon);
            this.Controls.Add(this.textBoxTedarikciUlke);
            this.Controls.Add(this.textBoxTedarikciSehir);
            this.Controls.Add(this.textBoxTedarikciAdi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TedarikciGuncelle";
            this.Text = "TEDARİKÇİ GÜNCELLE";
            this.Load += new System.EventHandler(this.TedarikciGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTedarikciIletisimİsmi;
        private System.Windows.Forms.TextBox textBoxTedarikciAdres;
        private System.Windows.Forms.TextBox textBoxTedarikciTelefon;
        private System.Windows.Forms.TextBox textBoxTedarikciUlke;
        private System.Windows.Forms.TextBox textBoxTedarikciSehir;
        private System.Windows.Forms.TextBox textBoxTedarikciAdi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}