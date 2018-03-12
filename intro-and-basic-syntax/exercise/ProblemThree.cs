using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////CONFIRMED from Rakrone
            //we are reading 2 doubles
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * 1.60934;
            //we are printing miles!!!!!!!!!
            Console.WriteLine($"{miles:F2}");

        }
    }
}

