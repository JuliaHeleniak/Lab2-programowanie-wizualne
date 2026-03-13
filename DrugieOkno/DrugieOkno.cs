using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrugieOkno
{
    public partial class OknoWyboru : Form
    {
        public string WybranyProdukt { get; private set; }
        private Dictionary<string, int> lokalneProdukty;
        public OknoWyboru(string tytul, Dictionary<string, int> produkty)
        {
            InitializeComponent();
            this.Text = tytul;
            this.lokalneProdukty = produkty;

            foreach (var p in produkty)
            {
                listBox1.Items.Add($"{p.Key} - {p.Value} zł");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string wybranyTekst = listBox1.SelectedItem.ToString();

                string nazwa = wybranyTekst.Split('-')[0].Trim();

               textBox1.Text = "Wybrano: " + nazwa;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string wybranyTekst = listBox1.SelectedItem.ToString();
                WybranyProdukt = wybranyTekst.Split('-')[0].Trim();
                
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
