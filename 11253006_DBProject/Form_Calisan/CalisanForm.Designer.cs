namespace _11253006_DBProject
{
    partial class CalisanForm
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
            this.textBoxSehir = new System.Windows.Forms.TextBox();
            this.textBoxDepartman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxİsciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnCalisanGuncelle = new System.Windows.Forms.Button();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridViewCalisan = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSehir);
            this.groupBox1.Controls.Add(this.textBoxDepartman);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxİsciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(494, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Arama";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(326, 67);
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
            this.label3.Location = new System.Drawing.Point(261, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir:";
            // 
            // textBoxSehir
            // 
            this.textBoxSehir.Location = new System.Drawing.Point(326, 24);
            this.textBoxSehir.Name = "textBoxSehir";
            this.textBoxSehir.Size = new System.Drawing.Size(120, 27);
            this.textBoxSehir.TabIndex = 5;
            // 
            // textBoxDepartman
            // 
            this.textBoxDepartman.Location = new System.Drawing.Point(128, 67);
            this.textBoxDepartman.Name = "textBoxDepartman";
            this.textBoxDepartman.Size = new System.Drawing.Size(104, 27);
            this.textBoxDepartman.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departman:";
            // 
            // textBoxİsciAdi
            // 
            this.textBoxİsciAdi.Location = new System.Drawing.Point(128, 27);
            this.textBoxİsciAdi.Name = "textBoxİsciAdi";
            this.textBoxİsciAdi.Size = new System.Drawing.Size(104, 27);
            this.textBoxİsciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan Adı:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 23);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(465, 79);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 247;
            this.lineShape1.X2 = 247;
            this.lineShape1.Y1 = -10;
            this.lineShape1.Y2 = 80;
            // 
            // btnCalisanGuncelle
            // 
            this.btnCalisanGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanGuncelle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCalisanGuncelle.Location = new System.Drawing.Point(298, 12);
            this.btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            this.btnCalisanGuncelle.Size = new System.Drawing.Size(182, 105);
            this.btnCalisanGuncelle.TabIndex = 12;
            this.btnCalisanGuncelle.Text = "Çalışan Güncelle";
            this.btnCalisanGuncelle.UseVisualStyleBackColor = true;
            this.btnCalisanGuncelle.Click += new System.EventHandler(this.btnCalisanGuncelle_Click);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanSil.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCalisanSil.Location = new System.Drawing.Point(101, 68);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(182, 49);
            this.btnCalisanSil.TabIndex = 11;
            this.btnCalisanSil.Text = "Çalışan Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = true;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanEkle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCalisanEkle.Location = new System.Drawing.Point(101, 12);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(182, 49);
            this.btnCalisanEkle.TabIndex = 10;
            this.btnCalisanEkle.Text = "Çalışan  Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
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
            // dataGridViewCalisan
            // 
            this.dataGridViewCalisan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCalisan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalisan.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewCalisan.Name = "dataGridViewCalisan";
            this.dataGridViewCalisan.RowTemplate.Height = 24;
            this.dataGridViewCalisan.Size = new System.Drawing.Size(1058, 502);
            this.dataGridViewCalisan.TabIndex = 8;
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
            // btnDepartman
            // 
            this.btnDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDepartman.Location = new System.Drawing.Point(971, 25);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(99, 92);
            this.btnDepartman.TabIndex = 14;
            this.btnDepartman.Text = "Departman İşlemleri";
            this.btnDepartman.UseVisualStyleBackColor = true;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // CalisanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalisanGuncelle);
            this.Controls.Add(this.btnCalisanSil);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridViewCalisan);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalisanForm";
            this.Text = "ÇALIŞAN İŞLEMLERİ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSehir;
        private System.Windows.Forms.TextBox textBoxDepartman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxİsciAdi;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnCalisanGuncelle;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridViewCalisan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDepartman;
    }
}