using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetkundigeFiguren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void btnCirkel_Click(object sender, EventArgs e)
        {
            Cirkel cirkel = new Cirkel();
            lblOmtrek.Text = lblOmtrek.Text = cirkel.Omtrek().ToString();
            lblOppervlak.Text = lblOppervlak.Text + cirkel.Oppervlak().ToString();
        }*/

        private void btnCirkel_Click_1(object sender, EventArgs e)
        {
            Cirkel cirkel = new Cirkel(3);
            lblOmtrek.Text = lblOmtrek.Text + cirkel.Omtrek().ToString();
            lblOppervlak.Text = lblOppervlak.Text + cirkel.Oppervlak().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rechthoek rechthoek = new Rechthoek(3, 4);
            lblOmtrek.Text = lblOmtrek.Text + rechthoek.Omtrek().ToString();
            lblOppervlak.Text = lblOppervlak.Text + rechthoek.Oppervlakte().ToString();
        }
    }
}
