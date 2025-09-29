namespace Aufgabe_02;

class Program
{
    static void Main(string[] args)
    {
        int secondsoftheMonth;
        string input;
        int daysoftheMonth = 0; //Als int definieren und den Wert 0 für TryParse als Anhaltspunkt angeben
        
        
        Console.WriteLine("Calculation of seconds of a month depending on its number of days");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("How many days does the month have for which you want to calculate the number of seconds?");
        input = Console.ReadLine();
        
    if (int.TryParse(input, out daysoftheMonth) == true) // bei out wird hier das Resultat in den Out-Parameter 'daysoftheMonth' geschrieben und dadurch muss ich nicht eine separate Variable hinzufügen und nachher noch konvertieren.
    {
        if ((daysoftheMonth < 28 || daysoftheMonth > 31))
        {
         Console.WriteLine($"invalid input. There is no month with {daysoftheMonth} days");
        }
        else
        {
        secondsoftheMonth = daysoftheMonth * 24 * 60 * 60;
        Console.WriteLine($"A month with {daysoftheMonth} days has {secondsoftheMonth} seconds");
        }
    }
    else
    {
        Console.WriteLine("invalid input. Enter an integer");
    }


    
    }
}