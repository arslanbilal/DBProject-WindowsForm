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
    public partial class UrunEkle : Form
    {
        DBOperation db;
        DataTable dt;
        string queryTedarikci = "SELECT * FROM tblSuppliers";
        string queryKategori = "SELECT * FROM tblCategories";

        public UrunEkle()
        {
            InitializeComponent();
        }

        //! Bu Form yüklenirken yapılan işlemler
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();

            dt = db.SelectTable(queryTedarikci);
            comboBoxTedarikci.DisplayMember = "supplierName";
            comboBoxTedarikci.ValueMember = "supplierID";
            comboBoxTedarikci.DataSource = dt;

            dt = db.SelectTable(queryKategori);
            comboBoxKategori.DisplayMember = "categoryName";
            comboBoxKategori.ValueMember = "categoryID";
            comboBoxKategori.DataSource = dt;
        }

        //! Ekleme İşlemini iptal eder.
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! Ekleme işlemini yapar.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //INSERT INTO table_name (column1,column2,column3,...) VALUES (value1,value2,value3,...);

            if (textBoxUrunAdi.Text != "" && textBoxUrunUcret.Text != "" && textBoxUrunAdet.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "INSERT INTO tblProducts (productName,categoryID,supplierID,quantity,price) VALUES ('" +
                        textBoxUrunAdi.Text.ToUpper().Trim() + "'," +
                        comboBoxKategori.SelectedValue.ToString() + "," +
                        comboBoxTedarikci.SelectedValue.ToString() + "," +
                        textBoxUrunAdet.Text.ToString() + "," +
                        textBoxUrunUcret.Text.ToString() + ")";

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
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!");
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
