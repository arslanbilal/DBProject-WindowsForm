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
    public partial class TedarikciEkle : Form
    {
        DBOperation db;

        public TedarikciEkle()
        {
            InitializeComponent();
        }

        private void TedarikciEkle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
        }

        //! Eklemenin yapıldığı Fonksiyon.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //INSERT INTO table_name (column1,column2,column3,...) VALUES (value1,value2,value3,...);

            if (textBoxTedarikciAdi.Text != "" && textBoxTedarikciIletisimİsmi.Text != "" && textBoxTedarikciAdres.Text != "" && textBoxTedarikciSehir.Text != "" && textBoxTedarikciUlke.Text != "" && textBoxTedarikciTelefon.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "INSERT INTO tblSuppliers (supplierName,contactName,address,city,country,Phone) VALUES ('" +
                        textBoxTedarikciAdi.Text.ToUpper().Trim() + "','" +
                        textBoxTedarikciIletisimİsmi.Text.ToUpper().Trim() + "','" +
                        textBoxTedarikciAdres.Text.ToUpper().Trim() + "','" +
                        textBoxTedarikciSehir.Text.ToUpper().Trim() + "','" +
                        textBoxTedarikciUlke.Text.ToUpper().Trim() + "','" +
                        textBoxTedarikciTelefon.Text.Trim() + "')";

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

        //! Ekleme İşlemini İptal eder.
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
