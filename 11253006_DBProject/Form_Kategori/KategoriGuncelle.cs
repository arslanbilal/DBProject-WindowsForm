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
    public partial class KategoriGuncelle : Form
    {
        DBOperation db;
        DataTable dt;
        int id;

        public KategoriGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //! Form yüklenirken yapılan işler.
        private void KategoriGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();
            string query = "SELECT * FROM tblCategories WHERE categoryID=" + id;

            dt = db.SelectTable(query);

            textBoxAdi.Text = dt.Rows[0][1].ToString();
            textBoxAciklama.Text = dt.Rows[0][2].ToString();
        }

        //! Güncelleme İşlemini yapar.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.Text != "" && textBoxAciklama.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "UPDATE tblCategories  SET categoryName='" +
                        textBoxAdi.Text.ToUpper().Trim() + "'," +
                        "description='" + textBoxAciklama.Text.ToUpper().Trim() + "' WHERE categoryID=" + id;

                    //MessageBox.Show(query);

                    if (db.RunCommand(query) > 0)
                    {
                        MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme İşleminde Hata Oluştu!");
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!!!");
            }
        }

        //! Güncelleme İşlemini iptal eder.
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
