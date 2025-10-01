namespace Aufgabe_15_Methodik;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Breite des Stammes? ");
        int stammBreite = Convert.ToInt32(Console.ReadLine());
        Console.Write("Höhe des Stammes? ");
        int stammHoehe = Convert.ToInt32(Console.ReadLine());
        Console.Write("Höhe der Krone?");
        int kronenHoehe = Convert.ToInt32(Console.ReadLine());

        ZeichneTannenbaum(stammBreite, stammHoehe, kronenHoehe);
        

    }

    static void ZeichneTannenbaum(int stammBreite, int stammHoehe, int kronenHoehe)
    {
        ZeichneKrone(kronenHoehe);
        ZeichneStamm(stammBreite, stammHoehe, kronenHoehe);
    }

    static void ZeichneZeile(int anzahlLeerzeichen, int anzahlSterne)
    {
        for (int i = 0; i < anzahlLeerzeichen; i++)
        {
            Console.Write(" ");
        }
        for (int a = 0; a < anzahlSterne; a++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }

    static void ZeichneKrone(int kronenHoehe)
    {
        int anzahlLeerzeichen = kronenHoehe - 1;
        int anzahlSterne = 1;
        
        for(int i = 0; i < kronenHoehe; i++)
        {
            ZeichneZeile(anzahlLeerzeichen, anzahlSterne);
            anzahlSterne += 2;
            anzahlLeerzeichen--;
        }
        
    }

    static void ZeichneStamm(int stammBreite, int stammHoehe, int kronenHoehe)
    {
        int anzahlLeerzeichen = (kronenHoehe * 2 - 1 - stammBreite) / 2;
        int anzahlSterne = stammBreite;

        for (int i = 0; i < stammHoehe; i++)
        {
            ZeichneZeile(anzahlLeerzeichen, anzahlSterne);
        }

    }
}