using System;

namespace Laboration_1
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle()
        {
            //Imagine a triangle where A is the side to the left, Base is the side at the bottom
            //and the hypotenuse is C.
            Base = 5;
            Height = 6;
            A = 7;
            C = 8;
        }

        public override double CalculateArea()
        {
            return Base * Height / 2;
        }

        public override double CalculateCircumference()
        {
            return A + Base + C;
        }
    }
}