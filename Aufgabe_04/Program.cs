namespace Aufgabe_04;

class Program
{
    static void Main(string[] args)
    {
        string[] months = {"","January", "February", "March",  "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        string input;
        int monthNumber = 0;
         
        Console.Write("Enter a number between 1-12: ");
        input = Console.ReadLine();

        if (int.TryParse(input, out monthNumber) == true)
        {
            if (monthNumber > 1 && monthNumber < 12)
            {
                Console.WriteLine(months[monthNumber]);
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter a number between 1-12.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Enter an Integer");
        }
    }
}