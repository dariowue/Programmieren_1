namespace Aufgabe_08;

class Program
{
    static void Main(string[] args)
    {
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };
        Console.WriteLine("Your comment:");
        string comment= Console.ReadLine();
        string finalComment = comment.ToLower(); // Hier wird die Eingabe des Kommentars klein geschrieben, egal wie es eingegeben wurde.
        
        int amountforbiddenWords = 0;
        

        foreach (string word in forbiddenWords)
        {
            if ( finalComment.Contains(word))
            {
                amountforbiddenWords++;
            }
            
        }
        
        Console.WriteLine($"You comment includes {amountforbiddenWords} forbidden words");
        Console.WriteLine("Your comment won't be posted!");
        
    }
    
    
}