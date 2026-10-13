using System;
namespace conditions
{
    class Program
    {
        static void Main(string [] args)
        {
            string name;
            int age;
            System.Console.WriteLine("What's your name ?: ");
            name = System.Console.ReadLine();
            System.Console.WriteLine("So your name is: " + name);
            System.Console.WriteLine("About your age ?: ");
            age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("You're " + age + " Iuyears old.");
            System.Console.ReadKey();
            System.Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");
        }
    }
}