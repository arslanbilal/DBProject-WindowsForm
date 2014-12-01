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
    public partial class TedarikciForm : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "SELECT supplierID[ID], supplierName[TEDARİKÇİ ADI], contactName[İLETİŞİM ADI], address[ADRES], city[ŞEHİR], country[ÜLKE], phone[TELEFON] FROM tblSuppliers";

        public TedarikciForm()
        {
            InitializeComponent();
        }

        //! Bu Form Yüklenirken Yapılan İşlemler.
        private void TedarikciForm_Load(object sender, EventArgs e)
        {
            dataGridViewTedarikci.MultiSelect = false;
            dataGridViewTedarikci.AllowUserToResizeColumns = false;
            dataGridViewTedarikci.AllowUserToResizeRows = false;
            dataGridViewTedarikci.AllowUserToAddRows = false;
            dataGridViewTedarikci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTedarikci.AllowUserToDeleteRows = false;
            dataGridViewTedarikci.AllowUserToOrderColumns = true;
            dataGridViewTedarikci.MultiSelect = false;
            dataGridViewTedarikci.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewTedarikci.DataSource = dt;
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

        //! TedarikciEkle Form'una gönderen Fonksiyon.
        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            TedarikciEkle tedarikciEkle = new TedarikciEkle();
            tedarikciEkle.Tag = this;
            tedarikciEkle.ShowDialog();
            updateTable();
        }

        //! Müşteri Silme İşlemleri.
        private void btnTedarikciSil_Click(object sender, EventArgs e)
        {
            int index = dataGridViewTedarikci.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dt.Rows[index][0]);

            string query = "DELETE FROM tblSuppliers where supplierID = " + id;

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

        //! Tedarikçi Güncelleme İşmeleri -> TedarikciGuncelle Form'una gider.
        private void btnTedarikciGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTedarikci.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewTedarikci.SelectedCells[0].Value.ToString());

                TedarikciGuncelle tedarikciGuncelle = new TedarikciGuncelle(id);
                tedarikciGuncelle.Tag = this;
                tedarikciGuncelle.ShowDialog();
                updateTable();
            }
        }

        //! Arama Fonksiyonu tuşu.
        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

        //! Tedarikçi Arama İşlemleri.
        void aramaFonksiyonu()
        {
            string tedarikciAdi = textBoxTedarikciAdi.Text.ToUpper();
            string iletisimAdi = textBoxTedarikciİletisimİsmi.Text.ToUpper();
            string sehir = textBoxTedarikciSehir.Text.ToUpper();

            string appendixQuery = " WHERE supplierName LIKE '%" + tedarikciAdi + "%' AND contactName LIKE '%" + iletisimAdi + "%' AND city LIKE '%" + sehir + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewTedarikci.DataSource = dt;
            dataGridViewTedarikci.Refresh();
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewTedarikci.DataSource = dt;
            dataGridViewTedarikci.Refresh();
        }

        //! Arama'daki text boxların her değişmesinde tetiklenir.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }

    }
}
