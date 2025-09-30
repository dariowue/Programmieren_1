namespace Aufgabe_12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Zahlen Aufsummieren");
        Console.WriteLine("-------------------");
        Console.WriteLine("\nEnter the integers to be summed, seperated by commas");
        
        string input = Console.ReadLine();
        string[] inputArray  = input.Split(',');
        int [] intArray = Array.ConvertAll(inputArray, int.Parse);
        
        SumUp(intArray);
        
    }
    
    static int[] SumUp(int[] intArray) 
    {    
        int[] result = new int[intArray.Length]; 
        int sum = 0;
        
        for (int i = 0; i < intArray.Length; i++)
        {
            while (i <= intArray.Length - 1)
            {
                sum = intArray[i] + sum;
                
                if(i != intArray.Length -1)
            {
                Console.Write("[" + i + "]" + " -> " + sum + ", ");
                i++;
            }
            else
            {
                Console.Write("[" + i + "]" + " -> " + sum);
                i++;
            }
        }
     }
        return result; 
    }
    
}