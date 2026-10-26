using System;
namespace nested_loops
{
    class Program
    {
        static void Main (string [] args)
        {
            System.Console.Write("How Many rows ?: ");
            int rows = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("How Many columns ?: ");
            int columns = Convert.ToInt32(System.Console.ReadLine());
            String symbol = System.Console.ReadLine();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    System.Console.Write(symbol);

                }
                System.Console.WriteLine();
            }

        }
    }
}