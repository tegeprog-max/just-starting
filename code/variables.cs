using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace variables
{
    class Program
    {
        static void Main (string [] args)
        {
            int x; //declaration
            x = 123; //inicialization
            int y = 321; //declaration + inicialization
            int z = x + y;
            Console.WriteLine(z);
            //INTEGERS NUMBERS
            int age = 24;
            Console.WriteLine("Your Age is " + age);

            // decimal type
            double height = 76.2; //DECIMAL NUMBERS
            Console.WriteLine("Your height is " + height);

            //Boolean variable
            bool alive = true;

            Console.WriteLine("Is it alive ? " + alive);

            // char is a single character.
            char symbol = '@';
            Console.WriteLine(symbol);
            
            // Strings
            String name = "Antonio";
            Console.WriteLine(name);

        }
    }
}