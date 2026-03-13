using CzwarteOkno;
using DrugieOkno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrzecieOkno;

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
        Dictionary<string, int> menuZCenami = new Dictionary<string, int>
        {
            { "Pizza", 30 },
            { "Burger", 25 },
            { "Sushi", 45 },
            { "Ramen", 40 },
            { "Kebab", 20 }
        };

        private void btnWybierz_Click(object sender, EventArgs e)
        {
            var okno2 = new DrugieOkno.OknoWyboru("Wybierz danie", menuZCenami);

            if (okno2.ShowDialog() == DialogResult.OK)
            {
                string produkt = okno2.WybranyProdukt;
                int cena = menuZCenami[produkt];

                
                ListViewItem item = new ListViewItem(produkt);
                item.SubItems.Add(cena.ToString());
                listViewKoszyk.Items.Add(item);

                PrzeliczSume();
            }
        }
        private void PrzeliczSume()
        {
            int suma = 0;
            foreach (ListViewItem item in listViewKoszyk.Items)
            {
                suma += int.Parse(item.SubItems[1].Text);
            }
            labelSuma.Text = $"Suma: {suma} zł"; // Wyświetlanie łącznej ceny obok koszyka
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            var okno3 = new TrzecieOkno.OknoTransportu();
            if (okno3.ShowDialog() == DialogResult.OK)
            {
                // Pobieramy koszt wybrany w oknie 3 przez właściwość
                int cenaTransportu = okno3.KosztDostawy;

                int sumaProduktow = 0;
                foreach (ListViewItem item in listViewKoszyk.Items)
                {
                    sumaProduktow += int.Parse(item.SubItems[1].Text);
                }

                // Teraz sumujemy produkty z transportem
                int sumaCalkowita = sumaProduktow + cenaTransportu;

                // Wyświetlamy wynik
                labelSuma.Text = $"Suma z dostawą: {sumaCalkowita} zł";
            }
        }

        private void btnZaplac_Click(object sender, EventArgs e)
        {
            int sumaDoZaplaty = 0;
            foreach (ListViewItem item in listViewKoszyk.Items)
            {
                sumaDoZaplaty += int.Parse(item.SubItems[1].Text);
            }
            string tekstSuma = labelSuma.Text;
            string tylkoCyfry = new string(tekstSuma.Where(char.IsDigit).ToArray());

            int ostatecznaKwota = 0;
            if (!string.IsNullOrEmpty(tylkoCyfry))
            {
                ostatecznaKwota = int.Parse(tylkoCyfry);
            }
            
            var okno4 = new Lab2.OknoPlatnosci();
            okno4.UstawSume(ostatecznaKwota); // Przekazujemy realną sumę do metody publicznej
            okno4.Show();
        }
         private void Cena(object sender, EventArgs e)
        {
          
        }
    }
}