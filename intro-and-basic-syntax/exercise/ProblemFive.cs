//CONFIRMED from k4l3l
using System;

namespace syntax_basics_exersises
{
    class ProblemFive
    {
        static void Main(string[] args)
        {
            //CONFIRMED from Rakrone
            //We get from the console a name on the first line
            //on the next four lines we get integers for current health, max health, current energy, max energy
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            //we print a visualisation of the information above
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', maxHealth - currentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}|");
        }
    }
}
