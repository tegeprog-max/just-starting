using System;
namespace Calculator
{
    class Program
    {
        static void Main (string [] args)
        {
            int number = 0, numbertwo = 0;
            string stop;
            while (true)
            {
                System.Console.WriteLine("Number 1: ");
                number = Convert.ToInt32(System.Console.ReadLine());
                if(number < 0)
                {
                    break;
                }
                System.Console.WriteLine("Number 2: ");
                numbertwo = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("We have: " + number * numbertwo);

            }
        }
    }
}