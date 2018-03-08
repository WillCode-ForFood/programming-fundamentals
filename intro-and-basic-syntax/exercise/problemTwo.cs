//CONFIRMED from iandrew40
using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve two inputs (A - width, B - height) that are the sides of a rectangle
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            // the variable "area" calculates the area of the rectangle
            double area = sideA * sideB;
            // finally print the area as a floating point, formatted to the 2nd char after the decimal point
            Console.WriteLine($"{area:F2}");
        }
    }
}