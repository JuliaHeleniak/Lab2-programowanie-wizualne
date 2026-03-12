using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrugieOkno
{
    public partial class OknoWyboru : Form
    {
        public OknoWyboru(string tytul)
        {
            InitializeComponent();
            this.Text = tytul;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
