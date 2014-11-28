namespace _11253006_DBProject
{
    partial class TedarikciForm
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
            this.buttonAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTedarikciSehir = new System.Windows.Forms.TextBox();
            this.textBoxTedarikciİletisimİsmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTedarikciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciGuncelle = new System.Windows.Forms.Button();
            this.btnTedarikciSil = new System.Windows.Forms.Button();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridViewTedarikci = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTedarikciSehir);
            this.groupBox1.Controls.Add(this.textBoxTedarikciİletisimİsmi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTedarikciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(494, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 105);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Arama";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(338, 67);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(120, 30);
            this.buttonAra.TabIndex = 10;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir:";
            // 
            // textBoxTedarikciSehir
            // 
            this.textBoxTedarikciSehir.Location = new System.Drawing.Point(338, 24);
            this.textBoxTedarikciSehir.Name = "textBoxTedarikciSehir";
            this.textBoxTedarikciSehir.Size = new System.Drawing.Size(120, 27);
            this.textBoxTedarikciSehir.TabIndex = 5;
            // 
            // textBoxTedarikciİletisimİsmi
            // 
            this.textBoxTedarikciİletisimİsmi.Location = new System.Drawing.Point(145, 67);
            this.textBoxTedarikciİletisimİsmi.Name = "textBoxTedarikciİletisimİsmi";
            this.textBoxTedarikciİletisimİsmi.Size = new System.Drawing.Size(104, 27);
            this.textBoxTedarikciİletisimİsmi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İletişim İsmi:";
            // 
            // textBoxTedarikciAdi
            // 
            this.textBoxTedarikciAdi.Location = new System.Drawing.Point(145, 27);
            this.textBoxTedarikciAdi.Name = "textBoxTedarikciAdi";
            this.textBoxTedarikciAdi.Size = new System.Drawing.Size(104, 27);
            this.textBoxTedarikciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi Adı:";
            // 
            // btnTedarikciGuncelle
            // 
            this.btnTedarikciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciGuncelle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTedarikciGuncelle.Location = new System.Drawing.Point(298, 12);
            this.btnTedarikciGuncelle.Name = "btnTedarikciGuncelle";
            this.btnTedarikciGuncelle.Size = new System.Drawing.Size(182, 105);
            this.btnTedarikciGuncelle.TabIndex = 20;
            this.btnTedarikciGuncelle.Text = "Tedarikçi Güncelle";
            this.btnTedarikciGuncelle.UseVisualStyleBackColor = true;
            this.btnTedarikciGuncelle.Click += new System.EventHandler(this.btnTedarikciGuncelle_Click);
            // 
            // btnTedarikciSil
            // 
            this.btnTedarikciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTedarikciSil.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTedarikciSil.Location = new System.Drawing.Point(101, 68);
            this.btnTedarikciSil.Name = "btnTedarikciSil";
            this.btnTedarikciSil.Size = new System.Drawing.Size(182, 49);
            this.btnTedarikciSil.TabIndex = 19;
            this.btnTedarikciSil.Text = "Tedarikçi Ekle";
            this.btnTedarikciSil.UseVisualStyleBackColor = true;
            this.btnTedarikciSil.Click += new System.EventHandler(this.btnTedarikciSil_Click);
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciEkle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTedarikciEkle.Location = new System.Drawing.Point(101, 12);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(182, 49);
            this.btnTedarikciEkle.TabIndex = 18;
            this.btnTedarikciEkle.Text = "Tedarikçi Ekle";
            this.btnTedarikciEkle.UseVisualStyleBackColor = true;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.Firebrick;
            this.btnYenile.Location = new System.Drawing.Point(12, 92);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 25);
            this.btnYenile.TabIndex = 17;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dataGridViewTedarikci
            // 
            this.dataGridViewTedarikci.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewTedarikci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTedarikci.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewTedarikci.Name = "dataGridViewTedarikci";
            this.dataGridViewTedarikci.RowTemplate.Height = 24;
            this.dataGridViewTedarikci.Size = new System.Drawing.Size(1058, 502);
            this.dataGridViewTedarikci.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::_11253006_DBProject.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 66);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TedarikciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTedarikciGuncelle);
            this.Controls.Add(this.btnTedarikciSil);
            this.Controls.Add(this.btnTedarikciEkle);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridViewTedarikci);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TedarikciForm";
            this.Text = "TEDARİKÇİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.TedarikciForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTedarikciSehir;
        private System.Windows.Forms.TextBox textBoxTedarikciİletisimİsmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTedarikciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTedarikciGuncelle;
        private System.Windows.Forms.Button btnTedarikciSil;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridViewTedarikci;
        private System.Windows.Forms.Button btnBack;
    }
}