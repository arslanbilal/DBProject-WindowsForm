namespace _11253006_DBProject
{
    partial class SatisForm
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
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIsciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridViewSatis = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxUrunAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxIsciAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMusteriAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(300, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Arama";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(369, 28);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(117, 27);
            this.textBoxUrunAdi.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Adı:";
            // 
            // textBoxIsciAdi
            // 
            this.textBoxIsciAdi.Location = new System.Drawing.Point(128, 67);
            this.textBoxIsciAdi.Name = "textBoxIsciAdi";
            this.textBoxIsciAdi.Size = new System.Drawing.Size(104, 27);
            this.textBoxIsciAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşçi Adı:";
            // 
            // textBoxMusteriAdi
            // 
            this.textBoxMusteriAdi.Location = new System.Drawing.Point(128, 27);
            this.textBoxMusteriAdi.Name = "textBoxMusteriAdi";
            this.textBoxMusteriAdi.Size = new System.Drawing.Size(104, 27);
            this.textBoxMusteriAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGuncelle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSatisGuncelle.Location = new System.Drawing.Point(101, 68);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(182, 49);
            this.btnSatisGuncelle.TabIndex = 11;
            this.btnSatisGuncelle.Text = "Satış Güncelle";
            this.btnSatisGuncelle.UseVisualStyleBackColor = true;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.btnSatisGuncelle_Click);
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisEkle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSatisEkle.Location = new System.Drawing.Point(101, 12);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(182, 49);
            this.btnSatisEkle.TabIndex = 10;
            this.btnSatisEkle.Text = "Satış Ekle";
            this.btnSatisEkle.UseVisualStyleBackColor = true;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.Firebrick;
            this.btnYenile.Location = new System.Drawing.Point(12, 92);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 25);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dataGridViewSatis
            // 
            this.dataGridViewSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatis.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewSatis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatis.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewSatis.Name = "dataGridViewSatis";
            this.dataGridViewSatis.RowTemplate.Height = 24;
            this.dataGridViewSatis.Size = new System.Drawing.Size(1058, 502);
            this.dataGridViewSatis.TabIndex = 8;
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
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSatisGuncelle);
            this.Controls.Add(this.btnSatisEkle);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridViewSatis);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SatisForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ŞATIŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIsciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMusteriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatisGuncelle;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridViewSatis;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.Label label5;
    }
}