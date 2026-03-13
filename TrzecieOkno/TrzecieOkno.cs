using System;
using System.Windows.Forms; 

namespace TrzecieOkno
{
    
    public partial class OknoTransportu : Form
    {
        
        public int KosztDostawy { get; set; }

        public OknoTransportu()
        {
            InitializeComponent(); 
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.KosztDostawy = 0; // Odbiór jest darmowy
                this.DialogResult = DialogResult.OK; // Ustawienie wyniku na OK
                this.Close(); // Zamknięcie okna
            }
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.KosztDostawy = 15; // Przykładowa cena dostawy
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.KosztDostawy = 25; // Droższa opcja dostawy
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
