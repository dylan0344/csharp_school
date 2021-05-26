using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MeetkundigeFiguren
{
    class Rechthoek
    {
        public Rechthoek(double breedte, double lengte)
        {
            _breedte = breedte;
            _hoogte = lengte;
        }

        private Point _Beginpunt = new Point(0, 0);
        double _breedte = 4;
        double _hoogte = 4;
        private int v;

        public double Oppervlakte()
        {
            return  _hoogte * _breedte;
        }
        public double Omtrek()
        {
            return 2 * _hoogte * _breedte;
        }
        public void Teken()
        {
        }
    }
}
