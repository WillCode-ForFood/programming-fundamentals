using System;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            //we are receiving four integers
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            //we are printing the integers 
            Console.WriteLine($"{a:d4} {b:d4} {c:d4} {d:d4}");
        }
    }
}
