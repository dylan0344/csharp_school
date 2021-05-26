using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmfoutvoorbeeld : Form
    {
        public frmfoutvoorbeeld()
        {
            InitializeComponent();
        }
        //
        // Buttons
        //
        private void button1_Click(object sender, EventArgs e)
        {
            // Initialisatie variabele
            double getal = 0;
            double breuk = 0;

            // https://stackoverflow.com/questions/4262286/why-does-c-sharp-allow-dividing-a-non-zero-number-by-zero-in-floating-point-type

            // Toekennen van waarden / berekeningen
            //try
            //{
                getal = double.Parse(txbGetal.Text);
                breuk = 1 / getal;
     
            //}
            /*catch (Exception exception)
            {
                
                MessageBox.Show("Er is een fout opgetreden. " + exception.Message);
            }*/
            // Tonen van de uitkomst
            MessageBox.Show("De breuk van " + getal.ToString() + " is: " +
                                 breuk.ToString());
        }
    }
}
