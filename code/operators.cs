using System;
namespace operators
{
    class Program
    {
        static void Main (string [] args)
        {
            int number1, number2, result;
            System.Console.WriteLine("if it is a plus plus, it will be like: ");
            System.Console.WriteLine("First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("So when it comes for plus signal, it will be like: ");
            Console.ReadKey();
            result = Convert.ToInt32(number1 + number2);
            System.Console.WriteLine(number1 + " + " + number2 + " is " + result);
            Console.ReadKey();
            System.Console.WriteLine("Thats it... and it can be replicated putting different signals like, +, -, *, / or even %");
            Console.ReadKey();
            System.Console.WriteLine("Thanks :D");
            

        }
    }
}