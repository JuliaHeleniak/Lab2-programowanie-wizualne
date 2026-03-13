using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrugieOkno
{
    public partial class OknoWyboru : Form
    {
        public string WybranyProdukt { get; private set; }
        public OknoWyboru(string tytul, List<string> produkty)
        {
            InitializeComponent();
            this.Text = tytul;
            foreach (var p in produkty)
            {
                listBox1.Items.Add(p);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                WybranyProdukt = listBox1.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
