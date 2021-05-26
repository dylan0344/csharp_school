using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3_1_DatumTijd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVandaag_Click(object sender, EventArgs e)
        {
            // deze functie wordt uitgevoerd als er op de knop btnVandaag
            // wordt geklikt

            // we maken een DateTime object

            DateTime vandaag = DateTime.Now;

            // een label heeft een propery Text
            // elk object heeft een methode ToString();
            lblDatumTijd.Text = vandaag.ToString();


            // we zetten de tekst op het label


        }

        private void btnLeeftijd_Click(object sender, EventArgs e)
        {
            // we halen de datum op uit de datepicker
            DateTime geboortedatum = dateTimePickerGeboortedatum.Value;

            // we berekenen het verschil met de tijd nu
            TimeSpan leeftijd = DateTime.Now - geboortedatum;

           // int interval = Convert.ToInt32(Math.Floor(different / increment));

            // we bepalen het aantal jaar en zetten dat op het label
            lblDatumTijd.Text = Math.Floor(leeftijd.TotalDays / 365).ToString();

        }
    }
}
