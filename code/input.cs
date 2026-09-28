using System;

namespace inputs
{
    class Program
    {
        static void Main (string [] args)
        {
            String name;
            System.Console.WriteLine("Whats your name ?: ");
            name = Console.ReadLine();
            System.Console.WriteLine("Your name is: " + name);
            System.Console.WriteLine("Whats your age ?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("You are " + age + " Years Old");
            Console.ReadKey();
        }
    }
}