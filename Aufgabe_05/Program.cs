using System.ComponentModel.Design;

namespace Aufgabe_05;

class Program
{
    static void Main(string[] args)
    {
        double numberofKilometers;
        double numberofLaps;
        string input;
        

        Console.Write("Enter the number of kilometers: ");
        numberofKilometers = Convert.ToDouble(Console.ReadLine());

        if (numberofKilometers > 42)
        {
            Console.WriteLine("You can't do it!");
        }
        else
        {
            numberofLaps = numberofKilometers / 0.4;
            Console.WriteLine($"That's {numberofLaps} rounds. Ready for the run? yes or no?");
            input = Console.ReadLine();

            if (input == "yes")
            {
               int i = 1;
               while (i <= numberofLaps)
               {
                   Console.WriteLine($"You run lap {i} ");
                   i++;
               }

               if (i > numberofLaps)
               {
                   Console.WriteLine("You did it!");
               }
            }
        }
    }
}
