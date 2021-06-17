using System;
using System.Net.NetworkInformation;

namespace Lab4
{
    public class Circle: GeomatricObject
    {
        private double radius;

        public Circle(double x)
        {
            this.radius = x;
        }

        public Circle(double x, string c, double w) : base(c, w)
        {
            this.radius = x;
        }

        public override String toString()
        {
            return "Circle has: radius is " + radius + ", color is" + PColor + ", wight is " + PWight;
        }

        public override double findArea()
        {
            return Math.PI * radius * radius;
        }
        public override double findPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}