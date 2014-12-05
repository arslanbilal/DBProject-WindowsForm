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
    public partial class UrunGuncelle : Form
    {
        DBOperation db;
        DataTable dt;
        DataTable dtComboBoxTedarikci;
        DataTable dtComboBoxKategori;
        int id;

        //! Bu Class'ın constructor'ı
        public UrunGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //! Bu Form'un yüklenirken yapılacak Görevler.
        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();
            dtComboBoxTedarikci = new DataTable();
            dtComboBoxKategori = new DataTable();

            string query = "SELECT * FROM tblProducts WHERE productID=" + id;
            dt = db.SelectTable(query);

            query = "SELECT * FROM tblCategories";
            dtComboBoxKategori = db.SelectTable(query);
            comboBoxKategori.DisplayMember = "categoryName";
            comboBoxKategori.ValueMember = "categoryID";
            comboBoxKategori.DataSource = dtComboBoxKategori;

            query = "SELECT * FROM tblSuppliers";
            dtComboBoxTedarikci = db.SelectTable(query);
            comboBoxTedarikci.DisplayMember = "supplierName";
            comboBoxTedarikci.ValueMember = "supplierID";
            comboBoxTedarikci.DataSource = dtComboBoxTedarikci;


            textBoxUrunAdi.Text = dt.Rows[0][1].ToString();
            comboBoxKategori.SelectedValue = dt.Rows[0][2].ToString();
            comboBoxTedarikci.SelectedValue = dt.Rows[0][3].ToString();
            textBoxUrunAdet.Text = dt.Rows[0][4].ToString();
            textBoxUrunUcret.Text = dt.Rows[0][5].ToString();

        }

        //! Güncelleme İşlemini Yapar.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // UPDATE table_name SET column1=value1,column2=value2,... WHERE some_column=some_value;

            if (textBoxUrunAdi.Text != "" && textBoxUrunAdet.Text != "" && textBoxUrunUcret.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string query = "UPDATE tblProducts SET " +
                        "productName ='" + textBoxUrunAdi.Text.ToUpper().Trim() +
                        "',categoryID=" + comboBoxKategori.SelectedValue.ToString() +
                        ",supplierID=" + comboBoxTedarikci.SelectedValue.ToString() +
                        ",quantity=" + textBoxUrunAdet.Text.ToString() +
                        ",price=" + textBoxUrunUcret.Text.ToString() +
                        " WHERE productID=" + id;

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
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!");
            }
        }

        //! Güncelleme İşlemini İptal eder.
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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
