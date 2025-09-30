namespace Aufgabe_14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check if a year is a leap year");
        Console.WriteLine("******************************");
        
        
        bool keypressed = false;

        while (keypressed == false)
        {
            int year;
            string input;

            Console.WriteLine("\nEnter Year (q + enter to Quit): ");
            input = Console.ReadLine();


            if (input == "q")
            {
                keypressed = true;
                Console.WriteLine("You pressed q which stopped the programm");
            }
            else
            {
                year = Convert.ToInt32(input);
                keypressed = false;
                
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            Console.WriteLine("This is a leap year!");
                        }
                        else
                        {
                            Console.WriteLine("This isn't a leap year!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is a leap year!");
                    }
                }
                else 
                {
                    Console.WriteLine("This isn't a leap year!");
                }

            }
        }
    }
}