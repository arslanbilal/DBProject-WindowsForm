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
    public partial class UrunTedarikEt : Form
    {
        DBOperation db;
        DataTable dt;

        public UrunTedarikEt()
        {
            InitializeComponent();
        }

        //! Bu form yüklenirken yapılan işlemler.
        private void UrunTedarikEt_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();

            string query = "SELECT * FROM tblProducts";

            dt = db.SelectTable(query);
            comboBoxUrunAdi.DisplayMember = "productName";
            comboBoxUrunAdi.ValueMember = "productID";
            comboBoxUrunAdi.DataSource = dt;

        }

        //! Tedarik etme işlemini yapar.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBoxUrunAdet.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "UPDATE tblProducts SET quantity=quantity+" + 
                        textBoxUrunAdet.Text.ToString() + " WHERE productID=" +
                        comboBoxUrunAdi.SelectedValue.ToString();

                    MessageBox.Show(query);

                    if (db.RunCommand(query) > 0)
                    {
                        MessageBox.Show("Tedarik İşlemi Gerçekleşti");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tedarik İşleminde Hata Oluştu!");
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanı Doldurunuz!!!");
            }
        }

        //! Tedarik işlemini iptal eder.
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
