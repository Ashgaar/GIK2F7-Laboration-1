using System;

namespace Laboration_1
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            Console.WriteLine("Error 1");
            return 0;
        }

        public virtual double CalculateCircumference()
        {
            Console.WriteLine("Error 2");
            return 0;
        }
    }
}