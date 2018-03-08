using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            double miles = km * 1.60934;

            Console.WriteLine($"{miles:F2}");

        }
    }
}

