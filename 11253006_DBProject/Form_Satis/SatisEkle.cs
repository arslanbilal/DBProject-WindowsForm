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
    public partial class SatisEkle : Form
    {
        DBOperation db;
        DataTable dt;
        string queryUrun = "SELECT * FROM tblProducts";
        string queryMusteri = "SELECT * FROM tblCustomers";
        string queryCalisan = "SELECT * FROM tblEmployees";

        public SatisEkle()
        {
            InitializeComponent();
        }

        //! Bu Form yüklenirken yapılan işlemler
        private void SatisEkle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();

            dt = db.SelectTable(queryUrun);
            comboBoxUrunAdi.DisplayMember = "productName";
            comboBoxUrunAdi.ValueMember = "productID";
            comboBoxUrunAdi.DataSource = dt;

            dt = db.SelectTable(queryMusteri);
            comboBoxMusteriAdi.DisplayMember = "customerName";
            comboBoxMusteriAdi.ValueMember = "customerID";
            comboBoxMusteriAdi.DataSource = dt;

            dt = db.SelectTable(queryCalisan);
            comboBoxCalisanAdi.DisplayMember = "employeeName";
            comboBoxCalisanAdi.ValueMember = "employeeID";
            comboBoxCalisanAdi.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //INSERT INTO table_name (column1,column2,column3,...) VALUES (value1,value2,value3,...);

            if (textBoxUrunMiktar.Text != "")
            {
                if (urunKontrolEt(Convert.ToInt32(comboBoxUrunAdi.SelectedValue.ToString())))
                {
                    if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string orderDate = String.Format("{0:yyyy-MM-dd}", dateTimePickerTarih.Value);

                        string query = "INSERT INTO tblOrders (customerId,employeeID,productID,orderDate,quantity) VALUES (" +
                            comboBoxMusteriAdi.SelectedValue.ToString() + "," +
                            comboBoxCalisanAdi.SelectedValue.ToString() + "," +
                            comboBoxUrunAdi.SelectedValue.ToString() + ",'" +
                            orderDate + "'," +
                            textBoxUrunMiktar.Text.ToString() + ")";
                        string sorgucuk = "UPDATE tblProducts SET quantity=quantity-" + 
                            Convert.ToInt32(textBoxUrunMiktar.Text.ToString()) + 
                            " WHERE productID=" + Convert.ToInt32(comboBoxUrunAdi.SelectedValue.ToString());

                        MessageBox.Show(query);
                        MessageBox.Show(sorgucuk);

                        if (db.RunCommand(sorgucuk) > 0 && db.RunCommand(query) > 0)
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
                        MessageBox.Show("Stokta Bulunan Üründen Fazla Girdiniz!");
                }
            }
        }

        //! Urun stok durum kontrol
        bool urunKontrolEt(int id)
        {
            string sorgucuk = "SELECT quantity FROM tblProducts WHERE productID=" + id;
            dt = db.SelectTable(sorgucuk);
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) >= Convert.ToInt32(textBoxUrunMiktar.Text.ToString()))
            {
                return true;
            }
            return false;
        }

        //! Ekleme işini iptal eder.
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
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }
    }
}
