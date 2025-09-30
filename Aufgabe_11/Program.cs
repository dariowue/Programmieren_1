namespace Aufgabe_11;

class Program
{
    static void Main(string[] args)
    {
        int number1;
        int number2;
        int checkSum;
        
        
        Console.Write("number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        int biggerNumber = Math.Max(number1,number2);
        int smallerNumber = Math.Min(number1,number2);
        
        Console.WriteLine("number,  checksum,  number/checksum");
        

        while (smallerNumber <= biggerNumber)
        {
            checkSum = CalculateChecksum(smallerNumber);
            if (smallerNumber % checkSum == 0)
            {
                Console.WriteLine(smallerNumber + "\t"  + checkSum + "\t" + smallerNumber / checkSum);
            }
            smallerNumber++;
        }
        
    }
    
    static int CalculateChecksum(int smallerNumber)
    {
        int checksum = 0;
        int sum = 0;
        
        while (smallerNumber != 0)
        {
            sum = sum + (smallerNumber % 10);
            smallerNumber /= 10;
        }

        return sum;
        
    }
    
    
    
}