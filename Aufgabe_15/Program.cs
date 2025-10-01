namespace Aufgabe_15;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Width of the trunk: ");
        string trunkWidthInput = Console.ReadLine();
        int trunkWidth = Convert.ToInt32(trunkWidthInput);
        Console.Write("Height of the trunk: ");
        string trunkHeightInput = Console.ReadLine();
        int trunkHeight = Convert.ToInt32(trunkHeightInput);
        Console.Write("Height of the treetop: ");
        string treetopHeightInput = Console.ReadLine();
        int treetopHeight = Convert.ToInt32(treetopHeightInput);

        DrawTreetop(treetopHeight, trunkWidth);
        DrawTrunk(trunkHeight, trunkWidth, treetopHeight);

    }

    static void DrawTreetop(int treetopHeight, int trunkWidth )
    {
        int amountSpaces;
        amountSpaces = (treetopHeight * 2 - 1 - trunkWidth) / 2;

        int amountSpacesTreetop;
        amountSpacesTreetop = (treetopHeight - 1);

        int amountStarsTreetop = 1;

        for (int a = 0; a < treetopHeight; a++)
        {
            int rowTreetop = 1;
            for (rowTreetop = 1; rowTreetop <= amountSpacesTreetop; rowTreetop++)
            {
                Console.Write(" ");
            }

            for (int rowTreetop2 = 1; rowTreetop2 <= amountStarsTreetop; rowTreetop2++)
            {
                Console.Write("*");
            }

            amountStarsTreetop = amountStarsTreetop + 2;
            amountSpacesTreetop--;
            Console.WriteLine();
        }
    }
    
    static void DrawTrunk(int trunkHeight, int trunkWidth, int treetopHeight )
    {
        int amountSpaces;
        amountSpaces = (treetopHeight * 2 - 1 - trunkWidth) / 2;
        
        for (int i = 0; i < trunkHeight; i++)
        {
            int rowTrunk = 1;
            for (rowTrunk = 1; rowTrunk <= amountSpaces; rowTrunk++)
            {
                Console.Write(" ");
            }

            int rowTrunk2 = 1;
            for (rowTrunk2 = 1; rowTrunk2 <= trunkWidth; rowTrunk2++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
    
    
}