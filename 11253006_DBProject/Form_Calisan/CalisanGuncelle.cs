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
    public partial class CalisanGuncelle : Form
    {
        DBOperation db;
        DataTable dt;
        DataTable dtComboBox;
        int id;

        //! Bu Class'ın constructor'ı  
        public CalisanGuncelle(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //? Bu Form'un yüklenirken yapılacak Görevler.
        private void CalisanGuncelle_Load(object sender, EventArgs e)
        {
            db = new DBOperation();
            dt = new DataTable();
            dtComboBox = new DataTable();

            string query = "SELECT * FROM tblEmployees WHERE employeeID=" + id;
            string queryCmb = "SELECT * FROM tblDepartmans";

            dt = db.SelectTable(query);
            dtComboBox = db.SelectTable(queryCmb);
            comboBoxDepartman.DisplayMember = "departmanName";
            comboBoxDepartman.ValueMember = "departmanID";
            comboBoxDepartman.DataSource = dtComboBox;


            //? sadd
            //string birtDate = String.Format("{0:yyyy-MM-dd}", dt.Rows[0][2].ToString());
            //MessageBox.Show(birtDate);

            //string[] birth = dt.Rows[0][2].ToString().Split('-');
            //string[] join = dt.Rows[0][5].ToString().Split('-');

            //for (int i = 0; i < birth.Length; i++)
            //{
            //    string aaa = String.Format("join: {0}\nbirth: {1}",join[i], birth[i]);
            //    MessageBox.Show(aaa);
            //}

            
            textBoxIsciAdi.Text = dt.Rows[0][1].ToString();
            //dateTimePickerDogumTarihi.Value = new DateTime(Convert.ToInt16(birth[0]), Convert.ToInt16(birth[1]),Convert.ToInt16(birth[2]));
            textBoxMaas.Text = dt.Rows[0][3].ToString();
            comboBoxDepartman.SelectedValue = dt.Rows[0][4].ToString();
            //dateTimePickerGirisTarihi.Value = new DateTime(Convert.ToInt16(join[0]), Convert.ToInt16(join[1]), Convert.ToInt16(join[2]));
            textBoxSehir.Text = dt.Rows[0][6].ToString();
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

            if (textBoxIsciAdi.Text != "" && textBoxSehir.Text != "" && textBoxMaas.Text != "")
            {
                if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string birtDate = String.Format("{0:yyyy-MM-dd}", dateTimePickerDogumTarihi.Value);
                    string joinDate = String.Format("{0:yyyy-MM-dd}", dateTimePickerGirisTarihi.Value);

                    string query = "UPDATE tblEmployees SET" +
                        " employeeName ='" + textBoxIsciAdi.Text.ToUpper().Trim() +
                        "',birthDate='" + birtDate +
                        "',salary=" + textBoxMaas.Text.ToUpper().Trim() +
                        ",departmanID=" + comboBoxDepartman.SelectedValue.ToString() +
                        ",joinDate='" + joinDate +
                        "',city='" + textBoxSehir.Text.Trim() +
                        "' WHERE employeeID=" + id;

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
