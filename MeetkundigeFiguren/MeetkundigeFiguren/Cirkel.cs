using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MeetkundigeFiguren
{
    class Cirkel
    {
        public Cirkel(int straal)
        {
            _Straal = straal;
        }
        private Point _Middelpunt = new Point(0, 0);
        private int _Straal = 0;
        public double Oppervlak()
        {
            return Math.PI * _Straal * _Straal;
        }      
        public double Omtrek()
        {
            return 2 * Math.PI * _Straal;
        }
        public void Teken()
        {
        }
    }   
}
