using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bam4a19_H10_Tekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeken_Click(object sender, EventArgs e)
        {
            int y; // y coordinaat
            int marge = 10; // de afstand tussen de lijnen
            int lijndikte = 2; 
            ColorDialog kleurkiezer = new ColorDialog();
            Color kleur = Color.Black; // default
            if (kleurkiezer.ShowDialog() == DialogResult.OK)
            {
                // Als de kleur wijzigd, wordt de jkleur getoond
                // als achtergrond kelur van de knop
                // Vervolgens tekenen we de horizontale lijnen opnieuw
                // in de nieuwe kleur.
                kleur = kleurkiezer.Color;
            };
            
            Pen tekenpotlood = new Pen(kleur, lijndikte);
            Graphics papier = pbTekening.CreateGraphics();
            // papier.DrawLine(tekenpotlood, 10, 10, 250, 0);


            /* elke plek op de PictureBox heeft een x en een y coordinaat, notatie (x, y)
             * de x-as gebruiken we voor de horizontale positie
             * de y-as voor de vertikale
             * 
             * (0,0)      <-      x        ->            (pbTekening.Width, 0)
             *
             *
             * ^
             * |
             * 
             * 
             * 
             * y
             * 
             * 
             * 
             * 
             * |
             * V
             * 
             * 
             * 
             * (0, pbTekening.Height)                (pbTekening.Width, pbTekening.Height)
             */             

            // merk op dat pbTekening.Width dynamisch is
            for (y = 0; y < pbTekening.Width; y += marge)
            {
                papier.DrawLine(tekenpotlood, y, 0, y, pbTekening.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
