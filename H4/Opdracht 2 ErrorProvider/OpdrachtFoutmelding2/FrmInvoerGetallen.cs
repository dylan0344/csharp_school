using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtFoutmelding2
{
    public partial class FrmInvoerGetallen : Form
    {
        //
        // Initialisatie
        //
        // Globale variabelen
        byte getal1 = 0;
        //
        //'Constructor
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
                // Wissen van de foutboodschap bij de ErrorProvider met de naam errorProvioder1
                errorProvider1.SetError(txbGetal1, "");
            }
            catch (Exception exception)
            {
                // Instellen van de foutboodschap bij de ErrorProvider met de 
                // naam errorProvioder1 en bij de textbox txbGetal1.
                errorProvider1.SetError(txbGetal1, exception.Message);
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
                getal2 = (sbyte)(getal1 + getal2);
                // En de laatste regel is hetzelfde als bij label1.
                lblUitvoer.Text = getal1.ToString();
                // Wissen van de foutboodschap bij de ErrorProvider met de naam errorProvioder1
                errorProvider1.SetError(txbGetal2, "");
            }
            catch (Exception exception)
            {
                // Instellen van de foutboodschap bij de ErrorProvider 
                // met de naam errorProvioder1 bij de textbox txbGetal2
                errorProvider1.SetError(txbGetal2, exception.Message);
            }

            //
            // Bij de optellingen krijg je niet altijd de fouten die je verwacht
            // Dit komt omdat er op verschillende regels verschillende fouten kunnen ontstaan.
            // In de toekomst zul je dan ook zo precies mogelijk programmeren, waarbij
            // je precies weet welke fouten eventueel waar kunnen optreden.
        }
    }
}
