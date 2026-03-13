using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab2
{
    
    public partial class OknoPlatnosci : Form
    {
        private int kwotaDoZaplaty;
        public OknoPlatnosci()
        {
            InitializeComponent();
        }

        
        public void UstawSume(int suma)
        {
            kwotaDoZaplaty = suma;
            labelSuma.Text = $"Zapłać: {suma} zł";
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelSuma.Text = $"Zapłać Przelewem: {kwotaDoZaplaty} zł";
            }
        }
       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                 labelSuma.Text = $"Zapłać Kartą: {kwotaDoZaplaty} zł";
            }
            
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                labelSuma.Text = $"Zapłać Blikiem: {kwotaDoZaplaty} zł";                
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                labelSuma.Text = $"Zapłać Google Pay: {kwotaDoZaplaty} zł";                
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                labelSuma.Text = $"Zapłać Apple Pay: {kwotaDoZaplaty} zł";            
            }
        }

        private void labelSuma_Click(object sender, EventArgs e)
        {
            string metoda = "";
            if (radioButton1.Checked) metoda = "Przelewem";
            if (radioButton2.Checked) metoda = "Kartą";
            if (radioButton3.Checked) metoda = "Blikiem";
            if (radioButton4.Checked) metoda = "Google Pay";
            if (radioButton5.Checked) metoda = "Apple Pay";

            if (metoda != "")
            {
                MessageBox.Show($"Dziękujemy za zamówienie! Opłacono metodą: {metoda}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wybrać metodę płatności!");
            }
        }
    }
}