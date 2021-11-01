using System;

namespace Laboration_1
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 5;
            Width = 6;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculateCircumference()
        {
            return Length * 2 + Width * 2;
        }
    }
}