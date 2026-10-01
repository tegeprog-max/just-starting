using System;
namespace operators_training
{
    class Program
    {
        static void Main (string [] args)
        {
            // OPERATORS
            int number1, number2, eq;

            System.Console.WriteLine("+");
            Console.ReadKey();
            System.Console.WriteLine("Welcome to plus S");
            System.Console.WriteLine("First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            System.Console.ReadKey();
            System.Console.WriteLine("Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            System.Console.ReadKey();
            eq = Convert.ToInt32(number1 + number2);
            System.Console.WriteLine("And we have: " + eq);
            System.Console.WriteLine(":D");
            System.Console.ReadKey();
        }
    }
}