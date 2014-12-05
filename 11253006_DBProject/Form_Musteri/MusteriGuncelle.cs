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
    public partial class MusteriGuncelle : Form
    {
        DBOperation db;
        DataTable dt;
        int id;

        //! Bu Class'ın constructor'ı      
        public MusteriGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //! Bu Form'un yüklenirken yapılacak Görevler.
        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();

            string query = "SELECT * FROM tblCustomers WHERE customerID = " + id;

            dt = db.SelectTable(query);

            textBoxFirmaAdi.Text = dt.Rows[0][1].ToString();
            textBoxIletisimİsmi.Text = dt.Rows[0][2].ToString();
            textBoxAdres.Text = dt.Rows[0][3].ToString();
            textBoxSehir.Text = dt.Rows[0][4].ToString();
            textBoxUlke.Text = dt.Rows[0][5].ToString();
            textBoxTelefon.Text = dt.Rows[0][6].ToString();
        }

        //! Güncelleme İşlemini iptal eden Fonksiyon.
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //! Güncelleme İşleminin Yapıldığı Fonksiyon
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
         // UPDATE table_name SET column1=value1,column2=value2,... WHERE some_column=some_value; 
  
            if (textBoxFirmaAdi.Text != "" && textBoxIletisimİsmi.Text != "" && textBoxAdres.Text != "" && textBoxSehir.Text != "" && textBoxUlke.Text != "" && textBoxTelefon.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "UPDATE tblCustomers SET" +
                        " customerName ='" + textBoxFirmaAdi.Text.ToUpper().Trim() +
                        "',contactName='" + textBoxIletisimİsmi.Text.ToUpper().Trim() +
                        "',address='" + textBoxAdres.Text.ToUpper().Trim() +
                        "',city='" + textBoxSehir.Text.ToUpper().Trim() +
                        "',country='" + textBoxUlke.Text.ToUpper().Trim() +
                        "',Phone='" + textBoxTelefon.Text.Trim() + 
                        "' WHERE customerID=" + id;

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
