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
        string baseQuery = "SELECT * FROM tblProducts";

        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {

        }

        //! Bu Formu kapatır.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {

        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();
            kategoriForm.Tag = this;
            kategoriForm.ShowDialog();
            //updateTable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
