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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        // Müşteri Ekranına Geçişi Sağlar.
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri Ekranı");
            //? Application.Run(new MusteriForm());
        }

        // İşçi Ekranına Geçişi Sağlar.
        private void btnIsci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşçi Ekranı");
        }

        // Ürün Ekranına Geçişi Sağlar.
        private void btnUrun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Ekranı");
        }

        // Tedarikçi Ekranına Geçişi Sağlar.
        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tedarikçi Ekranı");
        }

        // Satış Ekranına Geçişi Sağlar.
        private void btnSatis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış Ekranı");
        }

        // Yararlı Tablolar Ekranına Geçişi Sağlar.
        private void btnYararli_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yararlı Tablolar");
        }

        // Admin Ekranına Geçişi Sağlar.
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Ekranı");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //! DBOperation db = new DBOperation();

            //! DataTable dt = db.SelectTable("select * from tblCustomers");
        }

    }
}
