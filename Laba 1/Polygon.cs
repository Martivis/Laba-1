using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Polygon
    {
        protected Point[] _points;


        public Polygon(uint pointsNumber)
        {
            _points = new Point[pointsNumber];
        }

        public Point[] Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public void Move(double dx, double dy)
        {
            for (int i = 0; i < _points.Length; i++)
            {
                _points[i].Move(dx, dy);
            }
        }
        public double CountPerimeter()
        {
            double result = CountLength(_points[0], _points[^1]);
            for (int i = 0; i < _points.Length - 1; i++)
            {
                result += CountLength(_points[i], _points[i + 1]);
            }
            return result;
        }

        protected double CountLength(Point a, Point b)
        {
            return Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
        }
    }
}
