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
    public partial class TedarikciGuncelle : Form
    {
        DBOperation db;
        DataTable dt;
        int id;

        //! Bu Class'ın constructor'ı
        public TedarikciGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //! Bu Form'un yüklenirken yapılacak Görevler.
        private void TedarikciGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();

            string query = "SELECT * FROM tblSuppliers WHERE supplierID = " + id;

            dt = db.SelectTable(query);

            textBoxTedarikciAdi.Text = dt.Rows[0][1].ToString();
            textBoxTedarikciIletisimİsmi.Text = dt.Rows[0][2].ToString();
            textBoxTedarikciAdres.Text = dt.Rows[0][3].ToString();
            textBoxTedarikciSehir.Text = dt.Rows[0][4].ToString();
            textBoxTedarikciUlke.Text = dt.Rows[0][5].ToString();
            textBoxTedarikciTelefon.Text = dt.Rows[0][6].ToString();
        }

        //! Güncelleme İşleminin Yapıldığı Fonksiyon
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // UPDATE table_name SET column1=value1,column2=value2,... WHERE some_column=some_value; 

            if (textBoxTedarikciAdi.Text != "" && textBoxTedarikciIletisimİsmi.Text != "" && textBoxTedarikciAdres.Text != "" && textBoxTedarikciAdres.Text != "" && textBoxTedarikciUlke.Text != "" && textBoxTedarikciTelefon.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "UPDATE tblSuppliers SET" +
                        " supplierName ='" + textBoxTedarikciAdi.Text.ToUpper().Trim() +
                        "',contactName='" + textBoxTedarikciIletisimİsmi.Text.ToUpper().Trim() +
                        "',address='" + textBoxTedarikciAdres.Text.ToUpper().Trim() +
                        "',city='" + textBoxTedarikciSehir.Text.ToUpper().Trim() +
                        "',country='" + textBoxTedarikciUlke.Text.ToUpper().Trim() +
                        "',phone='" + textBoxTedarikciTelefon.Text.Trim() +
                        "' WHERE supplierID=" + id;

                    MessageBox.Show(query);

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
                { }
            }
        }

        //! Güncelleme İşlemini iptal eden Fonksiyon.
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
