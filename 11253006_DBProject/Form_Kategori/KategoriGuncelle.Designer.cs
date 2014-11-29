namespace _11253006_DBProject
{
    partial class KategoriGuncelle
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
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(182, 52);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(188, 44);
            this.textBoxAciklama.TabIndex = 12;
            this.textBoxAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressLetter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Açıklama:";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Firebrick;
            this.btnIptal.Location = new System.Drawing.Point(235, 106);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(135, 30);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(182, 16);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(188, 22);
            this.textBoxAdi.TabIndex = 9;
            this.textBoxAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPressLetter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori Adi:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGuncelle.Location = new System.Drawing.Point(16, 106);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 30);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // KategoriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_11253006_DBProject.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KategoriGuncelle";
            this.Text = "KATEGORİ GÜNCELLE";
            this.Load += new System.EventHandler(this.KategoriGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
    }
}