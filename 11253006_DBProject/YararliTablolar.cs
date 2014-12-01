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
    public partial class YararliTablolar : Form
    {
        DBOperation db;
        DataTable dt;
        string query;

        public YararliTablolar()
        {
            InitializeComponent();
        }

        private void YararliTablolar_Load(object sender, EventArgs e)
        {
            dataGridViewTablo.MultiSelect = false;
            dataGridViewTablo.AllowUserToResizeColumns = true;
            dataGridViewTablo.AllowUserToResizeRows = false;
            dataGridViewTablo.AllowUserToAddRows = false;
            dataGridViewTablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTablo.AllowUserToDeleteRows = false;
            dataGridViewTablo.AllowUserToOrderColumns = true;
            dataGridViewTablo.MultiSelect = false;
            dataGridViewTablo.ReadOnly = true;
            
            
            db = new DBOperation();
            dt = new DataTable();

            btn1();
        }

        private void btnView200_Click(object sender, EventArgs e)
        {
            btn1();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            btn2();
        }

        void btn1()
        {
            query = "SELECT * FROM vwUnderStok";
            dt = db.SelectTable(query);

            lblTabloAdi.Text = "200'den Az Bulunan Ürünler";
            dataGridViewTablo.DataSource = dt;
        }

        void btn2()
        {
            query = "SELECT D.departmanName[DEPARTMAN ADI], COUNT(D.departmanName)[KİŞİ SAYISI] FROM tblEmployees E INNER JOIN tblDepartmans D ON D.departmanID=E.departmanID GROUP BY D.departmanName";
            dt = db.SelectTable(query);

            lblTabloAdi.Text = "Departmanlarda Bulunan Çalışan Sayısı";
            dataGridViewTablo.DataSource = dt;
        }
    }
}
