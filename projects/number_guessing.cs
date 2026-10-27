using System;
namespace number_guessing
{
    class Program
    {
        static void Main (string [] args)
        {
            Random rnumber = new Random();
            int usergss, storern;
            storern = rnumber.Next(1,5);
            usergss = Convert.ToInt32(System.Console.ReadLine());
            if(usergss == storern)
            {
                System.Console.WriteLine("Nice Shot!!!");
            }
            else
            {
                System.Console.WriteLine("Sad :V...");
            }
        }
    }
}