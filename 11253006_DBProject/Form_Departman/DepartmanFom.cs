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
    public partial class DepartmanFom : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "SELECT * FROM tblDepartmans";

        public DepartmanFom()
        {
            InitializeComponent();
        }

        //! Bu form yüklenirken Yapılan İşlemler.
        private void DepartmanFom_Load(object sender, EventArgs e)
        {
            dataGridViewDepartman.MultiSelect = false;
            dataGridViewDepartman.AllowUserToResizeColumns = false;
            dataGridViewDepartman.AllowUserToResizeRows = false;
            dataGridViewDepartman.AllowUserToAddRows = false;
            dataGridViewDepartman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDepartman.AllowUserToDeleteRows = false;
            dataGridViewDepartman.AllowUserToOrderColumns = true;
            dataGridViewDepartman.MultiSelect = false;
            dataGridViewDepartman.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewDepartman.DataSource = dt;
        }

        //! DepartmanEkle Form'una gönderen Fonksiyon.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DepartmanEkle departmanEkle = new DepartmanEkle();
            departmanEkle.Tag = this;
            departmanEkle.ShowDialog();
            updateTable();
        }
        
        //! Departman Silme işlemleri
        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = dataGridViewDepartman.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dt.Rows[index][0]);

            string query = "DELETE FROM tblDepartmans where departmanID = " + id;

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

        //! Departman Güncelleme İşmeleri -> DepartmanGuncelle Form'una gider. 
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartman.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewDepartman.SelectedCells[0].Value.ToString());

                DepartmanGuncelle departmanGuncelle = new DepartmanGuncelle(id);
                departmanGuncelle.Tag = this;
                departmanGuncelle.ShowDialog();
                updateTable();
            }
        }

        //! Arama Fonksiyonu tuşu.
        private void btnAra_Click(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

        //! Departman Arama İşlemleri.
        void aramaFonksiyonu()
        {
            string departmanAdi = textBoxAdi.Text.ToUpper();

            string appendixQuery = " WHERE departmanName LIKE '%" + departmanAdi + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewDepartman.DataSource = dt;
            dataGridViewDepartman.Refresh();
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewDepartman.DataSource = dt;
            dataGridViewDepartman.Refresh();
        }

        //! Arama'daki text boxların her değişmesinde tetiklenir.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }
    }
}
