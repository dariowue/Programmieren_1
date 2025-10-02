using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    class Program
    {
        static bool restart = true;
        static void Main(string[] args)
        {
            while (restart == true)
            {
                Console.WriteLine("This is a Joke IPA:");

                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                WebResponse response = request.GetResponse();

                using Stream responseStream = response.GetResponseStream();
                using StreamReader reader = new StreamReader(responseStream);
                string json = reader.ReadToEnd();

                JArray array = JArray.Parse(json);

                foreach (var joke in array)
                {
                    Console.ResetColor();
                    Console.WriteLine(joke["text"]);
                    Console.Write("Do you want to hear another one? y/n \n\n");
                    CheckKey();
                }
            }
        }
        
        static void CheckKey()
        { 
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                restart = true;
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nToo bad, this one would have been a good one");
                restart = false;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This wasn't an option, yet you still chose to press it");
                restart = false;
            }
        }
        
    }
}