using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            lblLeeftijdError.Text = "";
            lblRijbewijsError.Text = "";
            lblJarenError.Text = "";
            lblResultaat.Text = "";
        }

        private void btnControleer_Click(object sender, EventArgs e) {
            int leeftijd = 0;
            string rijbewijs = "";
            int jaren = 0;


            // bepaal leeftijd
            try {
                leeftijd = int.Parse(txbLeeftijd.Text);
            }
            catch (FormatException) {
                lblLeeftijdError.Text = "Vul bij leeftijd een heel getal >= 18 in";
                //txbLeeftijd.Focus();
            }
            if (leeftijd < 18) {
                lblLeeftijdError.Text = "Onder de 18 is het niet toegestaan motor te rijden";
                return;
            }

            // bepaal type Rijbewijs
            rijbewijs = txbRijbewijs.Text.ToUpper();
            // MessageBox.Show(rijbewijs);
            if ( ((rijbewijs != "A1") &&
                 (rijbewijs != "A2") &&
                 (rijbewijs != "A3")) || (rijbewijs == "") ) {
                lblRijbewijsError.Text = "Vul bij rijbewijs A1/A2/A3 in";
                return;
            }
            

            //bepaal aantal jaar in bezit
            try {
                jaren = int.Parse(txbJaren.Text);
            }
            catch (FormatException) {
                lblJarenError.Text = "Vul bij aantal jaar in bezit een heel getal >= 0 in";
            }
            if (jaren < 0) {
                lblJarenError.Text = "Vul bij aantal jaar in bezit een heel getal >= 0 in";
                return;
            }

            // checks
            if ((leeftijd >= 22) && (jaren >= 2)) {
                lblResultaat.Text = "Rijbewijs A3 is toegestaan als je in het bezit bent van rijbewijs A2";
            }
            else if ( (leeftijd >= 20) && (jaren >= 2)) {
                lblResultaat.Text = "Rijbewijs A2 is toegestaan als je in het bezit bent van rijbewijs A1";
            }
            else if (leeftijd >= 18) {
                lblResultaat.Text = "Rijbewijs A1 is toegestaan";
            }
            else {
                lblResultaat.Text = "Rijbewijs niet toegestaan";
            }
        }
    }
}
