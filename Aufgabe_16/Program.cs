namespace Aufgabe_16;

class Program
{
    static int counter = 1;
    static bool gameStart = true;
    
    static void Main(string[] args)
    {
        while (gameStart == true)
        {
            counter = 1;
            Console.WriteLine("Your number (1..100): ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());


            Random rndm = new Random();
            int randomNumber = rndm.Next(1, 100);

            Console.Write(randomNumber);

            CorrectGuessedNumber(guessedNumber, randomNumber);
            Console.WriteLine("Play again? [y/n]");
            CheckKey();
        }


    }

    static void CorrectGuessedNumber(int guessedNumber, int randomNumber)
    {
        while ( guessedNumber != randomNumber)
        {
            
            if (guessedNumber < randomNumber)
            {
                counter++;
                Console.WriteLine("Your number is too small! Next try:");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
            }

            if (guessedNumber > randomNumber)
            {
                counter++;
                Console.WriteLine("Your number is too big! Next try:");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
            }

            if (guessedNumber == randomNumber)
            {
                Console.Write($"Your number is correct! it took you {counter} tries. ");
            }
            
        }
    }
    
    static void CheckKey()
    { 
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.Y)
        {
            Console.Clear();
            Console.WriteLine("You restarted the game!");
            gameStart = true;
        }
        else if (keyInfo.Key == ConsoleKey.N)
        {
            Console.Clear();
            Console.WriteLine("You stopped the game!");
            gameStart = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You stopped the game!");
            gameStart = false;
        }
    }
}