using System;

namespace Laboration_1
{
    public class Circle : Shape
    {
        public double Pi { get; set; }
        public double Radius { get; set; }

        public Circle()
        {
            Pi = Math.PI;
            Radius = 7;
        }

        public override double CalculateArea()
        {
            return Pi * Math.Pow(Radius, 2);
        }

        public override double CalculateCircumference()
        {
            return 2 * Pi * Radius;
        }
    }
}