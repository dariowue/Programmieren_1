namespace Aufgabe1;

class Program
{
    static void Main(string[] args)
    {
        int number1;
        int number2; 
        
        Console.Write("Number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"sum = {number1 + number2}");
    }
}