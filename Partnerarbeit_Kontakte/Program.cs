using System.ComponentModel;
using System.Runtime.CompilerServices;
//Gruppenmitglieder: Dario W. & Benjamin K.
namespace Partnerarbeit_Kontakte;

class Program
{
    static bool kontaktAbfrage = true;
    static bool ReihenfolgeVorundNachname;
    static Dictionary<int, Kontakt> kontakte = new Dictionary<int, Kontakt>(); //Muss hier sein, sonst kann man nicht auf die gespeicherten Werte zugreifen.

    static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("* Kontakte erfassen *");
        Console.WriteLine("*********************");

        KontakteHinzufuegen();

        if (kontaktAbfrage == false) //falls Eingabe beendet
        {
            Console.Clear();
            Console.Write("Wie sollen die Kontakte ausgegeben werden? \nVor- oder Nachname zuerst? (v/n)");
            CheckKeyVoroderNachname(); //Reihenfolge lesen

            Console.WriteLine("\n--- Kontakte ---");
            foreach (var eintrag in kontakte) //Für jeden Eintrag (Person) in Kontakte
            {
                var person = eintrag.Value; //Variable Person wird Wert aus Kontakt Dicitonary zugeordnet

                if (ReihenfolgeVorundNachname == true) //true: Beginn mit Vornamen
                {
                    Console.WriteLine($"{person.Vorname} {person.Nachname} ({person.EMail})");
                }
                else if (ReihenfolgeVorundNachname == false) //false: Beginn mit Nachnamen
                {
                    Console.WriteLine($"{person.Nachname} {person.Vorname} ({person.EMail})");
                }
            }
        }
    }

        static void KontakteHinzufuegen()
        {
            while (kontaktAbfrage == true) //Um abbrechen zu können, falls j gedrückt
            {
                Kontakt person = new Kontakt(); //neues Element im Dictionary erstellen

                Console.Write("\n\nVorname: ");
                person.Vorname = Console.ReadLine(); //Werte den Unterkategorien der Klasse zuweisen

                Console.Write("Nachname: ");
                person.Nachname = Console.ReadLine(); //Werte den Unterkategorien der Klasse zuweisen

                Console.Write("EMail: ");
                person.EMail = Console.ReadLine(); //Werte den Unterkategorien der Klasse zuweisen

                kontakte.Add(kontakte.Keys.Count + 1, person); //Der Inhalt des Dictionary wird um 1 erhöht und dann unter diesem Key werden die Werte gespeichert

                Console.Write("Eingabe beenden? (j/n) ");
                CheckKeyJaoderNein(); //Soll die Erfassung weiter gehen?
            }
        }

        static void CheckKeyJaoderNein()
        {
            //Frage: Abbrechen? Ja -> Abbruch / Nein -> While-Schlaufe wiederholt sich erneut
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
            //V: Beginnt mit Vorname, N: Beginnt mit Nachname
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
