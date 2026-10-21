using System;
namespace while_training
{
    class Program
    {
        static void Main (string [] args)
        {
            int age, born;
            string tryagain;
            System.Console.WriteLine("How old are you ?: ");
            age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("What its your born year ?: ");
            born = Convert.ToInt32(System.Console.ReadLine());
            while(born + age != DateTime.Now.Year)
            {
                if(born + age == DateTime.Now.Year){
                    System.Console.WriteLine("So you are " + age + " years old and have born in " + born);
                }else{
                    System.Console.WriteLine("Your age doesnt meet with your born year, wanna try again ?: Yes (Y) or No (N)");
                    tryagain = System.Console.ReadLine();
                    if (tryagain == "Y")
                    {
                        System.Console.WriteLine("How old are you ?: ");
                        age = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("What its your born year ?: ");
                        born = Convert.ToInt32(System.Console.ReadLine());
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