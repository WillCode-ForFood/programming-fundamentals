using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double kcal = double.Parse(Console.ReadLine()) / 100;
            double sugar = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine($"{volume}ml {name}: \r\n{kcal * volume}kcal, {sugar * volume}g sugars");
        }
    }
}
