namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewKoszyk = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelSuma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewKoszyk
            // 
            this.listViewKoszyk.HideSelection = false;
            this.listViewKoszyk.Location = new System.Drawing.Point(45, 27);
            this.listViewKoszyk.Name = "listViewKoszyk";
            this.listViewKoszyk.Size = new System.Drawing.Size(298, 396);
            this.listViewKoszyk.TabIndex = 0;
            this.listViewKoszyk.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wybierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnWybierz_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Transport";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Zapłać";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnZaplac_Click);
            // 
            // labelSuma
            // 
            this.labelSuma.Location = new System.Drawing.Point(377, 75);
            this.labelSuma.Multiline = true;
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(236, 22);
            this.labelSuma.TabIndex = 4;
            this.labelSuma.Click += new System.EventHandler(this.Cena);
            this.labelSuma.TextChanged += new System.EventHandler(this.Cena);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewKoszyk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewKoszyk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox labelSuma;
    }
}

