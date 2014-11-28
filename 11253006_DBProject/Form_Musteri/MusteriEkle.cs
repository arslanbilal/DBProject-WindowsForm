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
    public partial class MusteriEkle : Form
    {
        DBOperation db;

        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! Eklemen'n yapıldığı Fonksiyon.
        private void btnEkle_Click(object sender, EventArgs e)
        {

            //INSERT INTO table_name (column1,column2,column3,...) VALUES (value1,value2,value3,...);

            if (textBoxFirmaAdi.Text != "" && textBoxIletisimAdi.Text != "" && textBoxAdres.Text != "" && textBoxSehir.Text != "" && textBoxUlke.Text != "" && textBoxTelefon.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "INSERT INTO tblCustomers (customerName,contactName,address,city,country,Phone) VALUES ('" +
                        textBoxFirmaAdi.Text.ToUpper().Trim() + "','" +
                        textBoxIletisimAdi.Text.ToUpper().Trim() + "','" +
                        textBoxAdres.Text.ToUpper().Trim() + "','" +
                        textBoxSehir.Text.ToUpper().Trim() + "','" +
                        textBoxUlke.Text.ToUpper().Trim() + "','" +
                        textBoxTelefon.Text.Trim() + "')";

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
                else
                { }
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
