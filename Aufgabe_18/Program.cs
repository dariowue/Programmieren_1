namespace Aufgabe_18;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your text: ");
        string userInput = Console.ReadLine();
        string userInputlowerCase = userInput.ToLower();

        int amountofVowels = GeneralVowelCounter(userInputlowerCase);
        
        // Der Dictionary ist nützlich, wenn ich neue Elemente hinzufügen müsste. Dabei würde ich jeweils nur 1 statt 2 Zeilen schreiben - Der Dictionary ist in diesem Fall unleserlicher.
        /* Dictionary < char,int> vowels = new Dictionary < char, int>(); // Dictionary: Speichert jeweils eine Sache, hier char
        vowels.Add('a',0); // hier füge ich den char 'a' hinzu und dahinter werden die Zählungen gespeichert
        vowels.Add('e',0);
        vowels.Add('i',0);
        vowels.Add('o',0);
        vowels.Add('u',0);
        vowels.Add('ä',0);
        vowels.Add('ö',0);
        vowels.Add('ü',0);
        

        foreach (char key in vowels.Keys) // Das führe ich für jeden Buchstaben im Dictionary aus
        {
            vowels[key] = VowelCounterLetter(userInputlowerCase, key);  // Hier übergebe ich den Buchstaben & Zählung und erhalte die neue Zählung zurück (siehe unten)
        } */
        
        
        int vowelCountLetterA = VowelCounterLetter(userInputlowerCase, 'a');
        int vowelCountLetterE = VowelCounterLetter(userInputlowerCase, 'e');
        int vowelCountLetterI = VowelCounterLetter(userInputlowerCase, 'i');
        int vowelCountLetterO = VowelCounterLetter(userInputlowerCase, 'o');
        int vowelCountLetterU = VowelCounterLetter(userInputlowerCase, 'u');
        int vowelCountLetterÄ = VowelCounterLetter(userInputlowerCase, 'ä');
        int vowelCountLetterÖ = VowelCounterLetter(userInputlowerCase, 'ö');
        int vowelCountLetterÜ = VowelCounterLetter(userInputlowerCase, 'ü');
        
        WriteGeneralVowelCount(amountofVowels);
        
        /*
        foreach (char key in vowels.Keys) // für jeden Key im Dictionary
        {
            WriteLetterCount(key, vowels[key]); // Hier gebe ich alle Zählungen aus (siehe unten)
        } */
        
        
        WriteLetterCount('a', vowelCountLetterA);
        WriteLetterCount('e', vowelCountLetterE);
        WriteLetterCount('i', vowelCountLetterI);
        WriteLetterCount('o', vowelCountLetterO);
        WriteLetterCount('u', vowelCountLetterU);
        WriteLetterCount('ä', vowelCountLetterÄ);
        WriteLetterCount('ö', vowelCountLetterÖ);
        WriteLetterCount('ü', vowelCountLetterÜ);
        
    }

    static int GeneralVowelCounter(string userInputlowerCase)
    {
        int amountofVowels = 0;
        
        for (int i = 0; i < userInputlowerCase.Length; i++)
        {
            if (userInputlowerCase[i]  == 'a' || userInputlowerCase[i] == 'e' || userInputlowerCase[i] == 'i' || userInputlowerCase[i] == 'o' || userInputlowerCase[i] == 'u' || userInputlowerCase[i] == 'ä'|| userInputlowerCase[i] == 'ö' || userInputlowerCase[i] == 'ü')
            {
                amountofVowels++;
            }
        }

        return amountofVowels;
    }

    static int  VowelCounterLetter(string userInputlowerCase, char letter)
    {
        int vowelCountLetter = 0;

        for (int i = 0; i < userInputlowerCase.Length; i++)
        {
            if (userInputlowerCase[i] == letter)
            {
                vowelCountLetter++;
            }
        }
        return vowelCountLetter;
    }

    static void WriteGeneralVowelCount(int amountofVowels)
    {
        if (amountofVowels == 0)
        {
            Console.WriteLine("Your text includes no vowels!");
        }

        if (amountofVowels == 1)
        {
            Console.WriteLine("Your text includes 1 vowel!");
        }

        else
        {
            Console.WriteLine($"Your text includes {amountofVowels} vowels");
        }
    }

    static void WriteLetterCount(char letter, int amount)
    {
        if (amount > 0)
        {
            Console.WriteLine($"The letter {letter} is {amount} times in your text");
        }
    }
}