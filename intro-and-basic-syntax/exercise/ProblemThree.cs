using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            //we are reading 2 doubles
            double km = double.Parse(Console.ReadLine());
            double miles = km * 1.60934;
            //we are printing miles!!!!!!!!!
            Console.WriteLine($"{miles:F2}");

        }
    }
}

