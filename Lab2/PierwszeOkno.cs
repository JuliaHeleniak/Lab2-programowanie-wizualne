using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrugieOkno;
using TrzecieOkno;
using CzwarteOkno;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listViewKoszyk.View = View.Details;
            listViewKoszyk.Columns.Add("Produkt", 150);
        }

        private void btnWybierz_Click(object sender, EventArgs e)
        {

            var okno2 = new DrugieOkno.OknoWyboru("Menu Główne");
            okno2.Show(); 
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            var okno3 = new TrzecieOkno.OknoTransportu();
            okno3.KosztDostawy = 15; 
            okno3.Show(); 
        }

        private void btnZaplac_Click(object sender, EventArgs e)
        {
        
            var okno4 = new Lab2.OknoPlatnosci();
            okno4.UstawSume(120);
            okno4.Show();
        }
         private void Cena(object sender, EventArgs e)
        {
          
        }
    }
}