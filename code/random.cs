using System;
using System.Globalization;
namespace random_Numbers
{
    class Program
    {
        static void Main (string [] args)
        {
            Random somenumber = new Random();
            Boolean trueorfalse;
            while(true){
            int num = somenumber.Next(1,3);
            System.Console.WriteLine("Press some key to generate a random number");
            System.Console.WriteLine("If this number results in 2 u r able to the next step");
            System.Console.ReadKey();
            System.Console.WriteLine(num);
            if(num == 2)
            {
                System.Console.WriteLine("Gz, now press any key to try our double version.");
                System.Console.ReadKey();
                System.Console.WriteLine("Here we go with our double version");
                double numd = somenumber.NextDouble();
                System.Console.WriteLine("Press any key to check ur random double number");
                System.Console.ReadKey();
                System.Console.WriteLine(numd);
                }
                else
                {
                    System.Console.WriteLine("Unfort ur number 2 isnt here ;(, Thanks for playing");
                    System.Console.WriteLine("Wanna try again ?: ");
                    trueorfalse = Convert.ToBoolean(System.Console.ReadLine());
                    if(trueorfalse == true)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}