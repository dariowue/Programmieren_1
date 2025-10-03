using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Partnerarbeit_Kontakte;

class Program
{
    static bool kontaktAbfrage = true;
    static bool ReihenfolgeVorundNachname;
    static Dictionary<int, Kontakt> kontakte = new Dictionary<int, Kontakt>();

    static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("* Kontakte erfassen *");
        Console.WriteLine("*********************");

        KontakteHinzufuegen();

        if (kontaktAbfrage == false)
        {
            Console.Clear();
            Console.Write("Wie sollen die Kontakte ausgegeben werden? \nVor- oder Nachname zuerst? (v/n)");
            CheckKeyVoroderNachname();

            Console.WriteLine("\n--- Kontakte ---");
            foreach (var eintrag in kontakte)
            {
                var person = eintrag.Value;

                if (ReihenfolgeVorundNachname == true)
                {
                    Console.WriteLine($"{person.Vorname} {person.Nachname} ({person.EMail})");
                }
                else if (ReihenfolgeVorundNachname == false)
                {
                    Console.WriteLine($"{person.Nachname} {person.Vorname} ({person.EMail})");
                }
            }
        }

        static void KontakteHinzufuegen()
        {
            while (kontaktAbfrage == true)
            {
                Kontakt person = new Kontakt();

                Console.Write("\n\nVorname: ");
                person.Vorname = Console.ReadLine();

                Console.Write("Nachname: ");
                person.Nachname = Console.ReadLine();

                Console.Write("EMail: ");
                person.EMail = Console.ReadLine();

                kontakte.Add(kontakte.Keys.Count + 1, person);

                Console.Write("Eingabe beenden? (j/n) ");
                CheckKeyJaoderNein();
            }
        }

        static void CheckKeyJaoderNein()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.J)
            {
                kontaktAbfrage = false;
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                kontaktAbfrage = true;
            }
            else
            {
                kontaktAbfrage = true;
            }
        }

        static void CheckKeyVoroderNachname()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.V)
            {
                ReihenfolgeVorundNachname = true;
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                ReihenfolgeVorundNachname = false;
            }
            else
            {
                Console.Clear();
                Console.Write("Falsche Eingabe! Vor- oder Nachname zuerst? (v/n)");
                CheckKeyVoroderNachname();
            }
        }

    }
}