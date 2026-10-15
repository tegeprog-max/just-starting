using System;
using System.Drawing;
namespace switches_training
{
    class Program
    {
        static void Main (string [] args)
        {
            // Fruit List
            //Switches
            int Number = 0;
            Number = Convert.ToInt32(System.Console.ReadLine());
            switch (Number)
            {
                case 0:
                System.Console.WriteLine("Number: " + Number);
                break;
                case 1:
                System.Console.WriteLine("Number: " + Number);
                break;
                case 2:
                System.Console.WriteLine("Number: " + Number);
                break;
                default:
                System.Console.WriteLine("Nah... Sad");
                break;
            }
        }
    }
}