namespace Aufgabe_13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the line: ");
        Console.WriteLine(" ");
        string input = Console.ReadLine();
        int intInput = Convert.ToInt32(input);

        string [,] stringArray = new string [intInput, intInput];
        
        for (int i = 0; i < intInput; i++)
        {
            stringArray[i,i] = " ";
        }

        for (int row = 0; row < stringArray.GetLength(0); row++)
        {
            for (int column = 0; column < stringArray.GetLength(1); column++)
            {
                Console.Write(stringArray[row, column] + "*");
            }
            Console.WriteLine();
        }

    }
        
}