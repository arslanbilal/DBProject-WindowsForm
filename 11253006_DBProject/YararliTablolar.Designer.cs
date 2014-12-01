namespace _11253006_DBProject
{
    partial class YararliTablolar
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
            this.lblTabloAdi = new System.Windows.Forms.Label();
            this.btnView200 = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewTablo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabloAdi
            // 
            this.lblTabloAdi.AutoSize = true;
            this.lblTabloAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTabloAdi.Location = new System.Drawing.Point(7, 82);
            this.lblTabloAdi.Name = "lblTabloAdi";
            this.lblTabloAdi.Size = new System.Drawing.Size(527, 25);
            this.lblTabloAdi.TabIndex = 0;
            this.lblTabloAdi.Text = "Şimdilik boş olduğuna bakma neler gelecek neleeer :)";
            // 
            // btnView200
            // 
            this.btnView200.Location = new System.Drawing.Point(12, 12);
            this.btnView200.Name = "btnView200";
            this.btnView200.Size = new System.Drawing.Size(220, 52);
            this.btnView200.TabIndex = 1;
            this.btnView200.Text = "200\'den Az Bulunan Ürünler";
            this.btnView200.UseVisualStyleBackColor = true;
            this.btnView200.Click += new System.EventHandler(this.btnView200_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.Location = new System.Drawing.Point(260, 12);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(220, 52);
            this.btnDepartman.TabIndex = 2;
            this.btnDepartman.Text = "Departmanlarda Bulunan Çalışan Sayısı";
            this.btnDepartman.UseVisualStyleBackColor = true;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(750, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // dataGridViewTablo
            // 
            this.dataGridViewTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTablo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablo.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewTablo.Name = "dataGridViewTablo";
            this.dataGridViewTablo.RowTemplate.Height = 24;
            this.dataGridViewTablo.Size = new System.Drawing.Size(958, 531);
            this.dataGridViewTablo.TabIndex = 5;
            // 
            // YararliTablolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.dataGridViewTablo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.btnView200);
            this.Controls.Add(this.lblTabloAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YararliTablolar";
            this.Text = "YARARLI TABLOLAR";
            this.Load += new System.EventHandler(this.YararliTablolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabloAdi;
        private System.Windows.Forms.Button btnView200;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewTablo;
    }
}