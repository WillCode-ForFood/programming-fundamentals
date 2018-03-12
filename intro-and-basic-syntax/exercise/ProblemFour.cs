//CONFIRMED from Rakrone
using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve the name of the beverage

            string name = Console.ReadLine();
            //Here we receive the properties of the beverage
            int volume = int.Parse(Console.ReadLine());
            double kcal = double.Parse(Console.ReadLine()) / 100;
            double sugar = double.Parse(Console.ReadLine()) / 100;
            // lastly we calculate and print the volume, energy & sugar values
            Console.WriteLine($"{volume}ml {name}: \r\n{kcal * volume}kcal, {sugar * volume}g sugars");
        }
    }
}
