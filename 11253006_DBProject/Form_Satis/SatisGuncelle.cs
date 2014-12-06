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
    public partial class SatisGuncelle : Form
    {
        int adet;
        DBOperation db;
        DataTable dt;
        DataTable dtComboBoxCalisan;
        DataTable dtComboBoxMusteri;
        DataTable dtComboBoxUrun;
        int id;

        //! Bu Class'ın constructor'ı
        public SatisGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //! Bu Form'un yüklenirken yapılacak Görevler.
        private void SatisGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();
            dtComboBoxCalisan = new DataTable();
            dtComboBoxMusteri = new DataTable();
            dtComboBoxUrun = new DataTable();


            string query = "SELECT * FROM tblOrders WHERE orderID=" + id;
            dt = db.SelectTable(query);

            query = "SELECT * FROM tblEmployees";
            dtComboBoxCalisan = db.SelectTable(query);
            comboBoxCalisanAdi.DisplayMember = "employeeName";
            comboBoxCalisanAdi.ValueMember = "employeeID";
            comboBoxCalisanAdi.DataSource = dtComboBoxCalisan;

            query = "SELECT * FROM tblCustomers";
            dtComboBoxMusteri = db.SelectTable(query);
            comboBoxMusteriAdi.DisplayMember = "customerName";
            comboBoxMusteriAdi.ValueMember = "customerID";
            comboBoxMusteriAdi.DataSource = dtComboBoxMusteri;

            query = "SELECT * FROM tblProducts";
            dtComboBoxUrun = db.SelectTable(query);
            comboBoxUrunAdi.DisplayMember = "productName";
            comboBoxUrunAdi.ValueMember = "productID";
            comboBoxUrunAdi.DataSource = dtComboBoxUrun;


            comboBoxMusteriAdi.SelectedValue = dt.Rows[0][1].ToString();
            comboBoxCalisanAdi.SelectedValue = dt.Rows[0][2].ToString();
            comboBoxUrunAdi.SelectedValue = dt.Rows[0][3].ToString();
            //dateTimePickerTarih.Value = new DateTime("");
            textBoxUrunMiktar.Text = dt.Rows[0][5].ToString();
            this.adet = Convert.ToInt32(dt.Rows[0][5].ToString());
        }

        //! Güncelleme işlemini yapar.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // UPDATE table_name SET column1=value1,column2=value2,... WHERE some_column=some_value;
            int sonMiktar = Convert.ToInt32(textBoxUrunMiktar.Text.ToString());

            if (textBoxUrunMiktar.Text != "" &&
                comboBoxCalisanAdi.SelectedIndex >= 0 &&
                comboBoxMusteriAdi.SelectedIndex >= 0 &&
                comboBoxUrunAdi.SelectedIndex >= 0)
            {
                if (urunKontrolEt(Convert.ToInt32(dt.Rows[0][3].ToString()), this.adet-sonMiktar))
                {
                    if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string orderDate = String.Format("{0:yyyy-MM-dd}", dateTimePickerTarih.Value);
                        string query = "UPDATE tblOrders SET " +
                            "customerID =" + comboBoxMusteriAdi.SelectedValue.ToString() +
                            ",employeeID=" + comboBoxCalisanAdi.SelectedValue.ToString() +
                            ",productID=" + comboBoxUrunAdi.SelectedValue.ToString() +
                            ",orderDate='" + orderDate +
                            "',quantity=quantity+" + ((this.adet - sonMiktar) * -1).ToString() +
                            " WHERE orderID=" + id;

                        string query2 = "UPDATE tblProducts SET quantity=quantity+" + (this.adet - sonMiktar).ToString() + " WHERE productID=" + comboBoxUrunAdi.SelectedValue.ToString();

                        //MessageBox.Show(query);
                        //MessageBox.Show(query2);

                        string lastQueryWithTransaction = String.Format("BEGIN TRY\nBEGIN TRAN\n{0}\n{1}\nCOMMIT TRAN\nEND TRY\nBEGIN CATCH\nROLLBACK TRAN\nEND CATCH", query, query2);

                        MessageBox.Show("Kullanılan Transaction : \n\n\n" + lastQueryWithTransaction);

                        if (db.RunCommand(lastQueryWithTransaction) > 0)
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
                    MessageBox.Show("Stokta bulunandan fazla miktar girdiniz!");
                    string query = "SELECT * FROM tblOrders WHERE orderID=" + id;
                    dt = db.SelectTable(query);

                }
            }
            else
            {
                if (textBoxUrunMiktar.Text == "")
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!");
                else
                    MessageBox.Show("Lütfen Seçeneklerden Birini Seçiniz.\nSeçenek yoksa; önce seçenek ekleyiniz.");
            }
        }

        //! Urun stok durum kontrol
        bool urunKontrolEt(int id, int miktar)
        {
            string sorgucuk = "SELECT quantity FROM tblProducts WHERE productID=" + id;
            dt = db.SelectTable(sorgucuk);
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) >= -miktar)
            {
                return true;
            }
            return false;
        }

        //! Güncelleme işlemini iptal eder.
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
