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
    public partial class MusteriForm : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "SELECT * FROM tblCustomers";

        public MusteriForm()
        {
            InitializeComponent();
        }

        //! Bu Form Yüklenirken Yapılan İşlemler.
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            dataGridViewMusteri.MultiSelect = false;
            dataGridViewMusteri.AllowUserToResizeColumns = false;
            dataGridViewMusteri.AllowUserToResizeRows = false;
            dataGridViewMusteri.AllowUserToAddRows = false;
            dataGridViewMusteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMusteri.AllowUserToDeleteRows = false;
            dataGridViewMusteri.AllowUserToOrderColumns = true;
            dataGridViewMusteri.MultiSelect = false;
            dataGridViewMusteri.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewMusteri.DataSource = dt;
        }

        //! MainForm'a gönderen Fonksiyon.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! Müşteri Ekle Form'una gönderen Fonksiyon.
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Tag = this;
            musteriEkle.ShowDialog();
            updateTable();
        }

        //! Müşteri Silme İşlemleri.
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {           
            int index = dataGridViewMusteri.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dt.Rows[index][0]);
            
            string query = "DELETE FROM tblCustomers where customerID = " + id;

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

        //! Müşteri Güncelleme İşmeleri -> MusteriGuncelle Form'una gider.
        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewMusteri.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewMusteri.SelectedCells[0].Value.ToString());

                MusteriGuncelle musteriGuncelle = new MusteriGuncelle(id);
                musteriGuncelle.Tag = this;
                musteriGuncelle.ShowDialog();
                updateTable();
            }
        }

        //! Müşteri Arama İşlemleri.
        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

        //! DataGridView'i güncellenmesini Tetikler.
        private void btnYenile_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewMusteri.DataSource = dt;
            dataGridViewMusteri.Refresh();
        }

        void aramaFonksiyonu()
        {
            string firmaAdi = textBoxFirmaAdi.Text.ToUpper();
            string iletisimAdi = textBoxİletisimİsmi.Text.ToUpper();
            string sehir = textBoxSehir.Text.ToUpper();

            string appendixQuery = " WHERE customerName LIKE '%" + firmaAdi + "%' AND contactName LIKE '%" + iletisimAdi + "%' AND city LIKE '%" + sehir + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewMusteri.DataSource = dt;
            dataGridViewMusteri.Refresh();
        }

        private void textBoxSehir_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }
    }
}
