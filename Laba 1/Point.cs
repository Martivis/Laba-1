using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point() {}
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public void MoveTo(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
