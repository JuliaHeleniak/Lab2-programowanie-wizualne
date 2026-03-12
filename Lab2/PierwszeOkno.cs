using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {

        private List<string> koszyk = new List<string>();

        public Form1()
        {
            InitializeComponent();
          
            listViewKoszyk.View = View.Details;
            listViewKoszyk.Columns.Add("Produkt", 150);
        }


        private void btnWybierz_Click(object sender, EventArgs e)
        {

            string kategoria = "Dania Główne";
            List<string> dostepneMenu = new List<string> { "Pizza", "Burger", "Sałatka" };

            FormWybor oknoWyboru = new FormWybor(kategoria, dostepneMenu);

            if (oknoWyboru.ShowDialog() == DialogResult.OK;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            FormTransport oknoTransportu = new FormTransport();

            oknoTransportu.NumerZamowienia = 101;
            oknoTransportu.CzyPriorytet = true;
        }

        private void btnZaplac_Click(object sender, EventArgs e)
        {
            FormPlatnosc oknoPlatnosci = new FormPlatnosc();
            oknoPlatnosci.Show();
        }

        private void Cena(object sender, EventArgs e)
        {

        }
    }
}
