using System;
namespace review
{
    class Program
    {
        static void Main (string [] args)
        {
            //Constant
            // const int number = 5; Cant be changed
            //Convert
            // int number = 50;
            // int turnitinanumber;
            // turnitinanumber = Convert.ToInt32(number);
            //Input
            // string question;
            // Console.WriteLine("Which's ur favorite color ?");
            // question = Console.ReadLine();
            //Math
            // int n1, n2, res;
            // Console.WriteLine("First Number: ");
            // n1 = System.Console.ReadLine("");
            // Console.WriteLine("Second Line: ");
            // n2 = System.Console.ReadLine("");
            // res = n1 + n2;
            // System.Console.WriteLine(n1 + "+" + n2 + "is" + res);
            //Methods -- Will be learned while coding.
            //Operators are similar to math content so we have +, -, *, / and more.
            //OutPut is the process of using System.Console.WriteLine to check the result 
            // or even a Input without a user's answer.
            //It's a method that can help the user generate numbers, text or choose anything in a list.
            //And variables are what turn almost everything in here possible, like storing data or 
            // inputs interaction.

            //Random
            Random random = new Random();
            int num1 = random.Next(1,3);
            System.Console.WriteLine(num1);
            int count = 0;
            while(num1 != 2)
            {
                count++;
                Console.WriteLine("There is no number 2 here. " + "(" + count + ")");
                if(count == 100)
                {
                    break;
                }
            }

        }
    }
}