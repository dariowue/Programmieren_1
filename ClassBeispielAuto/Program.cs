namespace ClassBeispielAuto;

using System;

class Auto
{
    public string Marke;
    public string Farbe;
    public int Baujahr;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Autokonfigurator");
        Console.WriteLine("----------------");
        
        Auto userAuto = new Auto();
        Console.Write("Welche Marke soll dein Auto haben?");
        userAuto.Marke = Console.ReadLine();
        Console.Write("Welche Farbe soll dein Auto haben?");
        userAuto.Farbe = Console.ReadLine();
        Console.Write("Welches Baujahr soll dein Auto haben?");
        userAuto.Baujahr = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Dein Auto hat die Farbe {userAuto.Farbe} und die Marke {userAuto.Marke} aus {userAuto.Baujahr}.");
        
    }
}
