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
    public partial class DepartmanGuncelle : Form
    {
        DBOperation db;
        DataTable dt;
        int id;

        public DepartmanGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //! Form'un yüklenirken görevleri.
        private void DepartmanGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();
            string query = "SELECT * FROM tblDepartmans WHERE departmanID=" + id;

            dt = db.SelectTable(query);

            textBoxAdi.Text = dt.Rows[0][1].ToString();
        }

        //! Güncelleme İşlemini Yapar.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "UPDATE tblDepartmans SET departmanName='" +
                        textBoxAdi.Text.ToUpper().Trim() + "' WHERE departmanID=" + id;
                    
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
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanı Doldurunuz!!!");
            }
        }

        //! Departman Ekleme İşlemini iptal eder.
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
