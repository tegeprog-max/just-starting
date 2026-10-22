using System;
namespace training_random
{
    class Program
    {
        static void Main(string [] args)
        {
            Random t_random = new Random();
            int trdm;
            trdm = t_random.Next(1,10);
            System.Console.WriteLine(trdm);
            System.Console.WriteLine("Press Any Key to Finish...");
            System.Console.ReadLine();
        }
    }
}