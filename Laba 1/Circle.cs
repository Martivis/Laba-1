using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Circle
    {
        private double _radius;


        public Point Center { get; set; }
        public double Radius
        {
            get 
            { 
                return _radius; 
            }
            set
            {
                if (value >= 0)
                    _radius = value;
                else
                    _radius = 0;
            }
        }


        public Circle()
        {
            Center = new Point();
        }
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
        public Circle(double x, double y, double radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

        public void Move(double dx, double dy)
        {
            Center.Move(dx, dy);
        }
        public void MoveTo(double x, double y)
        {
            Center.MoveTo(x, y);
        }
        public double CountPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double CountArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
