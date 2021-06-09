using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RijGetallenZonderLoop
{
    public partial class FrmRijGetallenZonderLoop : Form
    {
        //
        // Initialisatie
        //
        // Constructor
        public FrmRijGetallenZonderLoop()
        {
            InitializeComponent();
        }
        //
        // Controls
        //
        // Controls - Buttons
        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVulTextBox_Click(object sender, EventArgs e)
        {
            // Ook hier maken we weer gebruik van een hulp variabele.
            // Iedere keer schrijven naar het scherm kost heel veel rekencapaciteit en
            // door een hulpvariabele te gebruiken krijg je een 
            // betere scheiding tussen logica en design
            //
            // Het commando Environment.Newline betekent hetzelfde als \r\n
            // Dus einde regel, nieuwe regel.
            // Alleen Environment.NewLine werkt ook op Linux platforms en daar
            // hebben ze een andere escape sequence voor eende regel, nieuwe regel.
            // Met andere woorden Environment.NewLine werkt altijd en overal
            string uitvoer = 50 + Environment.NewLine;
            uitvoer = uitvoer + 51 + Environment.NewLine;
            uitvoer = uitvoer + 52 + Environment.NewLine;
            uitvoer = uitvoer + 53 + Environment.NewLine;
            uitvoer = uitvoer + 54 + Environment.NewLine;
            uitvoer = uitvoer + 55 + Environment.NewLine;
            uitvoer = uitvoer + 56 + Environment.NewLine;
            uitvoer = uitvoer + 57 + Environment.NewLine;
            uitvoer = uitvoer + 58 + Environment.NewLine;
            uitvoer = uitvoer + 58 + Environment.NewLine;
            uitvoer = uitvoer + 60 + Environment.NewLine;
            uitvoer = uitvoer + 61 + Environment.NewLine;
            uitvoer = uitvoer + 62 + Environment.NewLine;
            uitvoer = uitvoer + 63 + Environment.NewLine;
            uitvoer = uitvoer + 64 + Environment.NewLine;
            uitvoer = uitvoer + 65 + Environment.NewLine;
            uitvoer = uitvoer + 66 + Environment.NewLine;
            uitvoer = uitvoer + 67 + Environment.NewLine;
            uitvoer = uitvoer + 68 + Environment.NewLine;
            uitvoer = uitvoer + 69 + Environment.NewLine;
            uitvoer = uitvoer + 70 + Environment.NewLine;
            uitvoer = uitvoer + 71 + Environment.NewLine;
            uitvoer = uitvoer + 72 + Environment.NewLine;
            uitvoer = uitvoer + 73 + Environment.NewLine;
            uitvoer = uitvoer + 74 + Environment.NewLine;
            uitvoer = uitvoer + 75 + Environment.NewLine;
            uitvoer = uitvoer + 76 + Environment.NewLine;
            uitvoer = uitvoer + 77 + Environment.NewLine;
            uitvoer = uitvoer + 78 + Environment.NewLine;
            uitvoer = uitvoer + 79 + Environment.NewLine;
            uitvoer = uitvoer + 80 + Environment.NewLine;
            uitvoer = uitvoer + 81 + Environment.NewLine;
            uitvoer = uitvoer + 82 + Environment.NewLine;
            uitvoer = uitvoer + 83 + Environment.NewLine;
            uitvoer = uitvoer + 84 + Environment.NewLine;
            uitvoer = uitvoer + 85 + Environment.NewLine;
            uitvoer = uitvoer + 68 + Environment.NewLine;
            uitvoer = uitvoer + 87 + Environment.NewLine;
            uitvoer = uitvoer + 88 + Environment.NewLine;
            uitvoer = uitvoer + 89 + Environment.NewLine;
            uitvoer = uitvoer + 90 + Environment.NewLine;
            uitvoer = uitvoer + 91 + Environment.NewLine;
            uitvoer = uitvoer + 92 + Environment.NewLine;
            uitvoer = uitvoer + 93 + Environment.NewLine;
            uitvoer = uitvoer + 94 + Environment.NewLine;
            uitvoer = uitvoer + 95 + Environment.NewLine;
            uitvoer = uitvoer + 96 + Environment.NewLine;
            uitvoer = uitvoer + 97 + Environment.NewLine;
            uitvoer = uitvoer + 98 + Environment.NewLine;
            uitvoer = uitvoer + 99 + Environment.NewLine;
            uitvoer = uitvoer + 100 + Environment.NewLine;

            // In de reeks staat 1 fout... waar staat deze?

            // Schrijven naar het scherm
            txbGetallen.Text = uitvoer;
        }
    }
}
