using System;
namespace random_training_2
{
    class Program
    {
        static void Main(string [] args)
        {
            Random choose_a_number = new Random();
            int choose, ur_number;
            while(true){
                    choose = Convert.ToInt32(choose_a_number.Next(1,10));
                    System.Console.WriteLine("Try ur luck and choose a number between 1 and 10");
                    ur_number = Convert.ToInt32(System.Console.ReadLine());
                        if(ur_number == choose)
                        {
                            System.Console.WriteLine("Gratz u r so lucky :P");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Press any key and try again :/");
                            System.Console.ReadKey();
                        }
            }
            
        }
    }
}