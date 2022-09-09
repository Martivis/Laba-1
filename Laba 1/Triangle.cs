using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Triangle : Polygon
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


        public Triangle() : base(3)
        {
            A = new Point();
            B = new Point();
            C = new Point();
        }
        public Triangle(Point a, Point b, Point c) : base(3)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CountArea()
        {
            return Math.Abs((B.X - A.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y)) / 2;
        }
        public bool isExists()
        {
            double a = CountLength(A, B);
            double b = CountLength(B, C);
            double c = CountLength(C, A);
            return a < b + c &&
                   b < a + c &&
                   c < a + b;
        }
    }
}
