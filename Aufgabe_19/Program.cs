namespace Aufgabe_19;

class Program
{
    static void Main(string[] args)
    {
        bool keypressed = false;
        while (keypressed == false)
        {
            Console.WriteLine("Enter a calculation (or press Q to quit)");
            string userInput = Console.ReadLine();
            if (userInput == "q")
            {
                keypressed = true;
                Console.WriteLine("You pressed q which stopped the programm");
            }
            else
            {
                try // Versucht es, falsch es nicht funktioniert --> Direkt zu catch
                {
                    string userInputwithoutSpaces = userInput.Replace(" ", ""); // Abstände löschen bzw. Ersetzen
                    string[] userInputwithoutSpacesOperators = userInputwithoutSpaces.Split('+', '-', '*', '/'); //Hier werden die Operatoren aus der Rechnung entfernt
                    int number1 = int.Parse(userInputwithoutSpacesOperators[0]); //Nummer 1 definieren (links vom Operator)
                    int number2 = int.Parse(userInputwithoutSpacesOperators[1]); //Nummer 2 definieren (rechts vom Operator)
                    string operationSigns = "+-*/"; // Hier muss ich diese neu definieren, da sie bei .Split entfernt werden und nicht gespeichert also kann ich nicht mehr darauf zugreifen.
                    CalculateUserInput(number1, number2, operationSigns, userInput); //Deshalb wird hier der ganze userInput mit den Operationszeihen verglichen, da ich nicht einfach nur das Operationszeichen abgespeichert habe.
                }
                catch //Hier wird die Aktion eingefügt, welche ausgeführt wird, wenn es nicht zutrifft.
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }

    static int CalculateUserInput(int number1, int number2, string operationSigns, string userInput)
    {
            foreach (char operationSign in userInput) // Überprüft aus dem String, was in der Eingabe vorkommt
            {
                if (operationSigns.Contains(operationSign))
                {
                    if (operationSign == '+')
                    {
                        Console.WriteLine($"{number1 + number2}");
                    }

                    if (operationSign == '-')
                    {
                        Console.WriteLine($"{number1 - number2}");
                    }

                    if (operationSign == '*')
                    {
                        Console.WriteLine($"{number1 * number2}");
                    }

                    if (operationSign == '/')
                    {
                        if (number2 != 0)
                        {
                            Console.WriteLine($"{number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed!!");
                        }
                    }
                }
            }
            return 0; //Muss einfach etwas zurückgeben, spielt aber keine Rolle, denn die Ausgabe wird direkt hier durchgeführt.
    
        }
}