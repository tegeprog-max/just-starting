using System;
namespace input
{
    class Program
    {
        static void Main (string [] args){
            string name;
            int age;
            System.Console.WriteLine("What's your name ?: ");
            name = Console.ReadLine();
            System.Console.WriteLine("Your name is: " + name);
            System.Console.ReadKey();
            System.Console.WriteLine("How old are u ?: ");
            age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("You are: " + age + " years old.");
            System.Console.ReadKey();
            System.Console.WriteLine("Well well so ur name is: " + name + " and u are " + age + " years old.");
            System.Console.ReadKey();
        }
    }
    
}