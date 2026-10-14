using System;
namespace switch_{
    class Program
    {
        static void Main (string [] args)
        {
            int number;
            System.Console.WriteLine("Number: ");
            number = Convert.ToInt32(System.Console.ReadLine());
            switch(number){
                case 5:
                System.Console.WriteLine("Well Done our number is 5");
                break;
                case 6:
                System.Console.WriteLine("This is not our number and its bigger than it");
                break;
                default:
                System.Console.WriteLine("Nice Try");
                break;
            }
        }
    }
}