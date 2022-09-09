using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Trapezoid : Polygon
    {
        public Point A
        {
            get { return _points[0]; }
            set { _points[0] = value; }
        }
        public Point B
        {
            get { return _points[1]; }
            set { _points[1] = value; }
        }
        public Point C
        {
            get { return _points[2]; }
            set { _points[2] = value; }
        }
        public Point D
        {
            get { return _points[3]; }
            set { _points[3] = value; }
        }

        public Trapezoid() : base(4)
        {
            A = new Point();
            B = new Point();
            C = new Point();
            D = new Point();
        }
        public Trapezoid(Point a, Point b, Point c, Point d) : base(4)
        {
            A = a;
            B = b;
            C = c;
            D = d;  
        }
    }
}
