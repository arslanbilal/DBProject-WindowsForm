using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11253006_DBProject
{
    public partial class KategoriEkle : Form
    {
        DBOperation db;

        public KategoriEkle()
        {
            InitializeComponent();
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
        }

        //! Kategori Ekler.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //INSERT INTO tblCategories(categoryName,description) values('asda')
            if (textBoxAdi.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "INSERT INTO tblCategories(categoryName,description) VALUES ('" +
                        textBoxAdi.Text.ToUpper().Trim() + "','" +
                        textBoxAciklama.Text.ToUpper().Trim() + "')";

                    MessageBox.Show(query);

                    if (db.RunCommand(query) > 0)
                    {
                        MessageBox.Show("Ekleme İşlemi Gerçekleşti");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme İşleminde Hata Oluştu!");
                    }
                }
            }
        }

        //! Kategori Ekleme işlemini iptal eder.
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! TextBox'a sadece harf kabul eden Fonksiyon.
        private void textBoxKeyPressLetter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ' ') && ((sender as TextBox).Text.IndexOf(' ') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
