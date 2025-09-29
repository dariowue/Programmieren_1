namespace Aufgabe_06;

class Program
{
    static void Main(string[] args)
    {
        int linebreak = 10;
        for (int i = 1; i < 11; ++i)
        {
            for (int n = 1; n < 11; n++)
            {
                int result = i * n;
                Console.Write(result + "\t");
                if (linebreak == result)
                {
                    Console.WriteLine("  ");
                    linebreak = linebreak + 10;
                }
            }
        }

    }
}