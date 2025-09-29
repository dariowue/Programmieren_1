namespace Aufgabe_07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numbers between 1 and 30 that can be divided by 5 and/or 3:");

        int i = 1;

        while (i <= 30)
        {
            i++;
            if (i % 5 == 0 || i % 3 == 0)
            {
                if (i == 30)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ","); 
                }
            }
        }
    }
}