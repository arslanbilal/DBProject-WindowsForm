﻿using System;
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


        //! Müşteri Ekranına Geçişi Sağlar.
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriForm musteriForm = new MusteriForm();
            musteriForm.Tag = this;
            musteriForm.ShowDialog(this);
        }

        //! İşçi Ekranına Geçişi Sağlar.
        private void btnIsci_Click(object sender, EventArgs e)
        {
            CalisanForm calısanForm = new CalisanForm();
            calısanForm.Tag = this;
            calısanForm.ShowDialog(this);
        }

        //! Ürün Ekranına Geçişi Sağlar.
        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm();
            urunForm.Tag = this;
            urunForm.ShowDialog(this);
        }

        //! Tedarikçi Ekranına Geçişi Sağlar.
        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            TedarikciForm tedarikciForm = new TedarikciForm();
            tedarikciForm.Tag = this;
            tedarikciForm.ShowDialog();
        }

        //! Satış Ekranına Geçişi Sağlar.
        private void btnSatis_Click(object sender, EventArgs e)
        {
            SatisForm satisFrom = new SatisForm();
            satisFrom.Tag = this;
            satisFrom.ShowDialog(); 
        }

        //! Yararlı Tablolar Ekranına Geçişi Sağlar.
        private void btnYararli_Click(object sender, EventArgs e)
        {
            YararliTablolar yararliTablolar = new YararliTablolar();
            yararliTablolar.Tag = this;
            yararliTablolar.ShowDialog();
        }

    }
}
