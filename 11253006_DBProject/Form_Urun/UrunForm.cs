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
    public partial class UrunForm : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "SELECT P.productID ID, P.productName [ÜRÜN ADI], C.categoryName [KATEGORİ ADI], S.supplierName [TEDARİKÇİ ADI], P.quantity [MİKTAR], P.price [FİYAT] FROM tblProducts P INNER JOIN tblCategories C ON C.categoryID = P.categoryID INNER JOIN tblSuppliers S ON S.supplierID = P.supplierID";

        public UrunForm()
        {
            InitializeComponent();
        }

        //! Bu Form Yüklenirken Yapılan İşlemler.
        private void UrunForm_Load(object sender, EventArgs e)
        {
            dataGridViewUrun.MultiSelect = false;
            dataGridViewUrun.AllowUserToResizeColumns = true;
            dataGridViewUrun.AllowUserToResizeRows = false;
            dataGridViewUrun.AllowUserToAddRows = false;
            dataGridViewUrun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUrun.AllowUserToDeleteRows = false;
            dataGridViewUrun.AllowUserToOrderColumns = true;
            dataGridViewUrun.MultiSelect = false;
            dataGridViewUrun.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewUrun.DataSource = dt;
        }

        //! Bu Formu kapatır.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //! DataGridView'i günceller.
        private void btnYenile_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        //! TedarikEt Formuna geçer.
        private void btnTedarikEt_Click(object sender, EventArgs e)
        {
            UrunTedarikEt urunTedarikEt = new UrunTedarikEt();
            urunTedarikEt.Tag = this;
            urunTedarikEt.ShowDialog();
            updateTable();
        }

        //! UrunEkle Form'una geçer.
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Tag = this;
            urunEkle.ShowDialog();
            updateTable();
        }

        //! Ürün Silme İşlemleri.
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int index = dataGridViewUrun.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dt.Rows[index][0]);

            string query = "DELETE FROM tblProducts where productID = " + id;

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

        //! UrunGuncelle Form'una geçer.
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {

            if (dataGridViewUrun.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewUrun.SelectedCells[0].Value.ToString());

                UrunGuncelle urunGuncelle = new UrunGuncelle(id);
                urunGuncelle.Tag = this;
                urunGuncelle.ShowDialog();
                updateTable();

            }

        }

        //! Arama Fonksiyonu tuşu.
        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

        //! Kategori Form'unu açar.
        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();
            kategoriForm.Tag = this;
            kategoriForm.ShowDialog();
            updateTable();
        }

        //! Ürün Arama İşlemleri.
        void aramaFonksiyonu()
        {
            string urunAdi = textBoxUrunAdi.Text.ToUpper();
            string kategoriAdi = textBoxUrunKategori.Text.ToUpper();
            string tedarikciAdi = textBoxUrunTedarikci.Text.ToUpper();

            string appendixQuery = " WHERE P.productName LIKE '%" + urunAdi + "%' AND C.categoryName LIKE '%" + kategoriAdi + "%' AND S.supplierName LIKE '%" + tedarikciAdi + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewUrun.DataSource = dt;
            dataGridViewUrun.Refresh();
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewUrun.DataSource = dt;
            dataGridViewUrun.Refresh();
        }

        //! Arama'daki text boxların her değişmesinde tetiklenir.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }



    }
}
