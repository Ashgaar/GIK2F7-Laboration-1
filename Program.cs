using System;

namespace Laboration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new();
            Console.WriteLine($"Area of the rectangle: {r.CalculateArea()}");
            Console.WriteLine($"Circumference of the rectangle: {r.CalculateCircumference()}");
            Console.WriteLine();

            Circle c = new();
            Console.WriteLine($"Area of the circle: {c.CalculateArea()}");
            Console.WriteLine($"Circumference of the circle: {c.CalculateCircumference()}");
            Console.WriteLine();

            Triangle t = new();
            Console.WriteLine($"Area of the triangle: {t.CalculateArea()}");
            Console.WriteLine($"Circumference of the triangle: {t.CalculateCircumference()}");
            Console.WriteLine();
        }
    }
}