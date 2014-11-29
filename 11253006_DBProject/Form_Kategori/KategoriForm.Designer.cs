namespace _11253006_DBProject
{
    partial class KategoriForm
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.arama = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridViewKategori = new System.Windows.Forms.DataGridView();
            this.arama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGuncelle.Location = new System.Drawing.Point(151, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 38);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSil.Location = new System.Drawing.Point(12, 56);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 38);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // arama
            // 
            this.arama.BackColor = System.Drawing.Color.Transparent;
            this.arama.Controls.Add(this.label1);
            this.arama.Controls.Add(this.textBoxAdi);
            this.arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.ForeColor = System.Drawing.Color.Firebrick;
            this.arama.Location = new System.Drawing.Point(290, 12);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(180, 82);
            this.arama.TabIndex = 7;
            this.arama.TabStop = false;
            this.arama.Text = "ARAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(72, 15);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(102, 23);
            this.textBoxAdi.TabIndex = 0;
            this.textBoxAdi.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEkle.Location = new System.Drawing.Point(12, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 38);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridViewKategori
            // 
            this.dataGridViewKategori.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategori.Location = new System.Drawing.Point(12, 114);
            this.dataGridViewKategori.Name = "dataGridViewKategori";
            this.dataGridViewKategori.RowTemplate.Height = 24;
            this.dataGridViewKategori.Size = new System.Drawing.Size(458, 327);
            this.dataGridViewKategori.TabIndex = 5;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewKategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KategoriForm";
            this.Text = "KATEGORİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            this.arama.ResumeLayout(false);
            this.arama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox arama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridViewKategori;
    }
}