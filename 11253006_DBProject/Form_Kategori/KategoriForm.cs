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
    public partial class KategoriForm : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "SELECT categoryID[ID],categoryName[KATEGORİ ADI],description[AÇIKLAMA] FROM tblCategories";

        public KategoriForm()
        {
            InitializeComponent();
        }

        //! Bu form yüklenirken Yapılan İşlemler.
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            dataGridViewKategori.MultiSelect = false;
            dataGridViewKategori.AllowUserToResizeColumns = true;
            dataGridViewKategori.AllowUserToResizeRows = false;
            dataGridViewKategori.AllowUserToAddRows = false;
            dataGridViewKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKategori.AllowUserToDeleteRows = false;
            dataGridViewKategori.AllowUserToOrderColumns = true;
            dataGridViewKategori.MultiSelect = false;
            dataGridViewKategori.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewKategori.DataSource = dt;
        }

        //! KategoriEkle Form'una gönderen Fonksiyon.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriEkle = new KategoriEkle();
            kategoriEkle.Tag = this;
            kategoriEkle.ShowDialog();
            updateTable();
        }

        //! Kategori Silme İşlmeleri.
        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = dataGridViewKategori.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dt.Rows[index][0]);

            string query = "DELETE FROM tblCategories where categoryID = " + id;

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

        //! Kategori Güncelleme İşlemleri -> KategoriGuncelle Form'una gider.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewKategori.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewKategori.SelectedCells[0].Value.ToString());

                KategoriGuncelle kategoriGuncelle = new KategoriGuncelle(id);
                kategoriGuncelle.Tag = this;
                kategoriGuncelle.ShowDialog();
                updateTable();
            }
        }

        //! Departman Arama İşlemleri.
        void aramaFonksiyonu()
        {
            string kategoriAdi = textBoxAdi.Text.ToUpper();

            string appendixQuery = " WHERE categoryName LIKE '%" + kategoriAdi + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewKategori.DataSource = dt;
            dataGridViewKategori.Refresh();
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewKategori.DataSource = dt;
            dataGridViewKategori.Refresh();
        }

        //! Arama'daki text boxların her değişmesinde tetiklenir.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }
    }
}
