﻿namespace _11253006_DBProject
{
    partial class MainMenu
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
            this.btnYararli = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnIsci = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnTedarikci = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYararli
            // 
            this.btnYararli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnYararli.ForeColor = System.Drawing.Color.Firebrick;
            this.btnYararli.Location = new System.Drawing.Point(578, 241);
            this.btnYararli.Name = "btnYararli";
            this.btnYararli.Size = new System.Drawing.Size(250, 200);
            this.btnYararli.TabIndex = 1;
            this.btnYararli.Text = "YARARLI TABLOLAR";
            this.btnYararli.UseVisualStyleBackColor = true;
            this.btnYararli.Click += new System.EventHandler(this.btnYararli_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUrun.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUrun.Location = new System.Drawing.Point(578, 12);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(250, 200);
            this.btnUrun.TabIndex = 2;
            this.btnUrun.Text = "ÜRÜN İŞLEMLERİ";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnIsci
            // 
            this.btnIsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnIsci.ForeColor = System.Drawing.Color.Firebrick;
            this.btnIsci.Location = new System.Drawing.Point(294, 12);
            this.btnIsci.Name = "btnIsci";
            this.btnIsci.Size = new System.Drawing.Size(250, 200);
            this.btnIsci.TabIndex = 3;
            this.btnIsci.Text = "ÇALIŞAN İŞLEMLERİ";
            this.btnIsci.UseVisualStyleBackColor = true;
            this.btnIsci.Click += new System.EventHandler(this.btnIsci_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSatis.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSatis.Location = new System.Drawing.Point(294, 241);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(250, 200);
            this.btnSatis.TabIndex = 4;
            this.btnSatis.Text = "SATIŞ İŞLEMLERİ";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnTedarikci
            // 
            this.btnTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTedarikci.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTedarikci.Location = new System.Drawing.Point(12, 241);
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.Size = new System.Drawing.Size(250, 200);
            this.btnTedarikci.TabIndex = 5;
            this.btnTedarikci.Text = "TEDARİKÇİ İŞLEMLERİ";
            this.btnTedarikci.UseVisualStyleBackColor = true;
            this.btnTedarikci.Click += new System.EventHandler(this.btnTedarikci_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMusteri.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMusteri.Location = new System.Drawing.Point(12, 12);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(250, 200);
            this.btnMusteri.TabIndex = 6;
            this.btnMusteri.Text = "MÜŞTERİ İŞLEMLERİ";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 485);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnTedarikci);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnIsci);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnYararli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "MENÜ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYararli;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnIsci;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnTedarikci;
        private System.Windows.Forms.Button btnMusteri;
    }
}

