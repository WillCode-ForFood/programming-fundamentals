using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double kcalPerHundred = double.Parse(Console.ReadLine()) / 100;
            double sugarPerHundred = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine($"{volume}ml {name}: \r\n{kcalPerHundred * volume}kcal, {sugarPerHundred * volume}g sugars");
        }
    }
}
