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
    public partial class SatisForm : Form
    {
        DBOperation db;
        DataTable dt;
        string baseQuery = "select O.orderID[ID], P.productName[ÜRÜN ADI], C.customerName[MÜŞTERİ ADI],E.employeeName[ÇALIŞAN ADI],O.orderDate[SATIŞ TARİHİ],O.quantity[MİKTAR] from tblOrders O INNER JOIN tblCustomers C ON C.customerID=O.customerID INNER JOIN tblEmployees E ON E.employeeID=O.employeeID INNER JOIN tblProducts P ON P.productID=O.productID";

        public SatisForm()
        {
            InitializeComponent();
        }

        //! Bu Formn Yüklenirken Yapılan İşlemler.
        private void SatisForm_Load(object sender, EventArgs e)
        {
            dataGridViewSatis.MultiSelect = false;
            dataGridViewSatis.AllowUserToResizeColumns = true;
            dataGridViewSatis.AllowUserToResizeRows = false;
            dataGridViewSatis.AllowUserToAddRows = false;
            dataGridViewSatis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSatis.AllowUserToDeleteRows = false;
            dataGridViewSatis.AllowUserToOrderColumns = true;
            dataGridViewSatis.MultiSelect = false;
            dataGridViewSatis.ReadOnly = true;

            db = new DBOperation();
            dt = new DataTable();
            dt = db.SelectTable(baseQuery);
            dataGridViewSatis.DataSource = dt;
        }

        //! Bu Formu kapatır.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! DataGridView'e günceller.
        private void btnYenile_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        //! Satış Ekleme Form'una yönlendirir.
        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            SatisEkle satisEkle = new SatisEkle();
            satisEkle.Tag = this;
            satisEkle.ShowDialog();
            updateTable();
        }

        //! Satis Güncelleme İşlemleri
        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSatis.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridViewSatis.SelectedCells[0].Value.ToString());

                SatisGuncelle satisGuncelle = new SatisGuncelle(id);
                satisGuncelle.Tag = this;
                satisGuncelle.ShowDialog();
                updateTable();
            }
        }

        //! DataGridView'i güncelleyen Fonksiyon.
        private void updateTable()
        {
            dt = db.SelectTable(baseQuery);
            dataGridViewSatis.DataSource = dt;
            dataGridViewSatis.Refresh();
        }

        //! Arama işleminin yapıldığı fonksiyon.
        void aramaFonksiyonu()
        {
            string isciAdi = textBoxIsciAdi.Text.ToUpper();
            string musteriAdi = textBoxMusteriAdi.Text.ToUpper();
            string urunAdi = textBoxUrunAdi.Text.ToUpper();

            string appendixQuery = " WHERE C.customerName LIKE '%" + musteriAdi + "%' AND E.employeeName LIKE '%" +isciAdi + "%' AND P.productName LIKE '%" + urunAdi + "%'";

            db = new DBOperation();
            dt = db.SelectTable(baseQuery + appendixQuery);
            dataGridViewSatis.DataSource = dt;
            dataGridViewSatis.Refresh();
        }

        //! TextBox
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            aramaFonksiyonu();
        }
    }
}
