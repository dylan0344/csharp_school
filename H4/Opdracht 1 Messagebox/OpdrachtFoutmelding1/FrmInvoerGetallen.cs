using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtVariabelen2
{
    public partial class FrmInvoerGetallen : Form
    {
        byte getal1 = 0;

        public FrmInvoerGetallen()
        {
            InitializeComponent();
        }
        //
        // Controls - Textboxen
        //
        private void txbGetal1_TextChanged(object sender, EventArgs e)
        {
            // Hier wordt het getal 'gelezen' uit het invoervak 
            // en 'vertaald' naar een byte-variable.
            byte getal1 = 0;

            try
            {
                getal1 = byte.Parse(txbGetal1.Text);
                // Bij dit getal wordt vervolgens twee opgeteld.
                // De waarde van de variabele verandert dan.
                getal1 = (byte)(getal1 + 2);
                // Tenslotte wordt het nieuwe getal weergegeven in een Label.
                lblUitvoer.Text = getal1.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void txbGetal2_TextChanged(object sender, EventArgs e)
        {
            // Definieren lokale variabele
            sbyte getal2 = 0; 

            try
            {
                // We kunnen hier beide getallen ‘inlezen’ vanuit de TextBoxen
                // naar sbyte-variabelen. Maar we lezen er maar 1 in.
                // Het andere getal was al ingelezen
                getal2 = sbyte.Parse(txbGetal2.Text);
                // De berekening is nu wat minder ingewikkeld.
                getal1 = (byte)(sbyte)(getal1 + getal2);
                // En de laatste regel is hetzelfde als bij label1.
                lblUitvoer.Text = getal1.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
