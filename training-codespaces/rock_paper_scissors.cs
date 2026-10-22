using System;
namespace rock_paper_scissors
{
    class Program
    {
        static void Main (string [] args)
        {
            // Rock_Paper_Scissors

            Random random = new Random();

            int user, computer;
            
            computer = Convert.ToInt32(random.Next(1,4));
            System.Console.WriteLine("Choose one of them: (1) Rock | (2) Paper | (3) Scissors ");
            user = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("So your choice is: " + user);
            System.Console.ReadKey();
            System.Console.WriteLine("But computer's choice is: " + computer);
            if(user == 1 && computer == 2)
            {
                System.Console.WriteLine("Gamer Over! D:");
            }
            else if(user == 2 && computer == 3)
            {
                System.Console.WriteLine("Gamer Over! D:");
            }
            else if(user == 3 && computer == 1)
            {
                System.Console.WriteLine("Gamer Over! D:");
            }
            else if(user == computer)
            {
                System.Console.WriteLine("Draw O.O");
            }
            else
            {
                System.Console.WriteLine("You Win!!! :D");
            }
        }
    }
}