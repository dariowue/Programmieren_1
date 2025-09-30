namespace Aufgabe_10;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        int finalResult;
        
        Console.Write("number: ");
        userNumber = Convert.ToInt32(Console.ReadLine());
        
        finalResult = CalculateChecksum(userNumber);
        Console.WriteLine(finalResult);
        
        
        
    }
    
    static int CalculateChecksum(int userNumber)
    {
        int checksum = 0;
        int sum = 0;
        
        while (userNumber != 0)
        {
            sum = sum + (userNumber % 10);
            userNumber /= 10;
        }

        return sum;
        
    }
    
}