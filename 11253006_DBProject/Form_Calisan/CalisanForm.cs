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
    public partial class CalisanForm : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "SELECT E.employeeID[ID],E.employeeName[ÇALIŞAN ADI],E.birthDate[DOĞUM TARİHİ],E.salary[MAAŞI],D.departmanName[DEPARTMAN ADI],E.joinDate[GİRİŞ TARİHİ],E.city[ŞEHİR] FROM tblEmployees E INNER JOIN tblDepartmans D ON D.departmanID=E.departmanID";

        public CalisanForm()
        {
            InitializeComponent();
        }

        //! Bu Form Yüklenirken Yapılan İşlemler.
        private void CalisanForm_Load(object sender, EventArgs e)
        {
            dataGridViewCalisan.MultiSelect = false;
            dataGridViewCalisan.AllowUserToResizeColumns = true;
            dataGridViewCalisan.AllowUserToResizeRows = false;
            dataGridViewCalisan.AllowUserToAddRows = false;
            dataGridViewCalisan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCalisan.AllowUserToDeleteRows = false;
            dataGridViewCalisan.AllowUserToOrderColumns = true;
            dataGridViewCalisan.MultiSelect = false;
            dataGridViewCalisan.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewCalisan.DataSource = dt;
        }

        //! MainForm'a gönderen Fonksiyon.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! DataGridView'i güncellenmesini Tetikler.
        private void btnYenile_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        //! Arama Fonksiyonu tuşu.
        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

        //! CalisanEkle Form'una gönderen Fonksiyon.
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            CalisanEkle calisanEkle = new CalisanEkle();
            calisanEkle.Tag = this;
            calisanEkle.ShowDialog();
            updateTable();
        }

        //! Calışan Silme İşlemleri.
        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            int index = dataGridViewCalisan.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dt.Rows[index][0]);

            string query = "DELETE FROM tblEmployees where employeeID = " + id;

            if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (db.RunCommand(query) > 0)
                {
                    MessageBox.Show("Silme İşlemi Gerçekleti.");
                    updateTable();
                }
                else
                {
                    MessageBox.Show("Silme işleminde Hata Oluştu!");
                }
            }
            else
            { }
        }

        //! Çalışan Güncelleme İşmeleri -> CalisanGuncelle Form'una gider.
        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewCalisan.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewCalisan.SelectedCells[0].Value.ToString());

                CalisanGuncelle calisanGuncelle = new CalisanGuncelle(id);
                calisanGuncelle.Tag = this;
                calisanGuncelle.ShowDialog();
                updateTable();
            }
        }

        //! Departman İşlemlerini -> DepartmanFom'a gider
        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanFom departmanFom = new DepartmanFom();
            departmanFom.Tag = this;
            departmanFom.ShowDialog();
            updateTable();
        }

        //! Calışan Arama İşlemleri.
        void aramaFonksiyonu()
        {
            string isciAdi = textBoxİsciAdi.Text.ToUpper();
            string departmanAdi = textBoxDepartman.Text.ToUpper();
            string sehir = textBoxSehir.Text.ToUpper();

            string appendixQuery = " WHERE E.employeeName LIKE '%" + isciAdi + "%' AND D.departmanName LIKE '%" + departmanAdi + "%' AND city LIKE '%" + sehir + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewCalisan.DataSource = dt;
            dataGridViewCalisan.Refresh();
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewCalisan.DataSource = dt;
            dataGridViewCalisan.Refresh();
        }

        //! Arama'daki text boxların her değişmesinde tetiklenir.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

    }
}
