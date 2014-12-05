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
    public partial class CalisanEkle : Form
    {
        DBOperation db;
        DataTable dt;
        string query = "SELECT * FROM tblDepartmans";

        public CalisanEkle()
        {
            InitializeComponent();
        }

        //! Bu Form yüklenirken yapılan işlemler.
        private void IsciEkle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = db.SelectTable(query);
            comboBoxDepartman.DisplayMember = "departmanName";
            comboBoxDepartman.ValueMember = "departmanID";
            comboBoxDepartman.DataSource = dt;
        }

        //! Ekleme İşlemini iptal eder.
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! Eklemenin yapıldığı Fonksiyon.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //INSERT INTO table_name (column1,column2,column3,...) VALUES (value1,value2,value3,...);

            if (textBoxIsciAdi.Text != "" && textBoxSehir.Text != "" && textBoxMaas.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string birtDate = String.Format("{0:yyyy-MM-dd}", dateTimePickerDogumTarihi.Value);
                    string joinDate = String.Format("{0:yyyy-MM-dd}", dateTimePickerGirisTarihi.Value);

                    string query = "INSERT INTO tblEmployees (employeeName,birthDate,salary,departmanID,joinDate,city) VALUES ('" +
                        textBoxIsciAdi.Text.ToUpper().Trim() + "','" +
                        birtDate + "'," +
                        textBoxMaas.Text.ToUpper().Trim() + "," +
                        comboBoxDepartman.SelectedValue.ToString() + ",'" +
                        joinDate + "','" +
                        textBoxSehir.Text.ToUpper().Trim() + "')";

                    //MessageBox.Show(query);

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
                else
                { }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!!!");
            }
        }

        //! TextBox'a sadece rakam kabul eden Fonksiyon.
        private void textBoxKeyPressNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
