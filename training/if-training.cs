using System;
namespace if_training
{
    class Program
    {
        static void Main (string [] args)
        {
            // Some if conditions training
            // Form

            string name, nickname,city,food,gender;
            int age, birthday;

            /// STRINGS ///

            // NAME //
            System.Console.WriteLine("What's your name ?: ");
            name = System.Console.ReadLine();
            System.Console.WriteLine("So your name is: " + name);
            System.Console.ReadKey();
            // NICKNAME //
            System.Console.WriteLine("What's your nickname ?: ");
            nickname = System.Console.ReadLine();
            System.Console.WriteLine("So your nickname is: " + nickname);
            System.Console.ReadKey();
            // CITY //
            System.Console.WriteLine("What's your city ?: ");
            city = System.Console.ReadLine();
            System.Console.WriteLine("So your city is: " + city);
            System.Console.ReadKey();
            // FOOD //
            System.Console.WriteLine("What's your favorite food ?: ");
            food = System.Console.ReadLine();
            System.Console.WriteLine("So your favorite food is: " + food);
            System.Console.ReadKey();
            // GENDER //
            System.Console.WriteLine("What's your gender ?: ");
            gender = System.Console.ReadLine();
            System.Console.WriteLine("So your gender is: " + gender);
            System.Console.ReadKey();

            /// INTEGERS ///
            
            System.Console.WriteLine("How old are you ?: ");
            age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("So you are: " + age + " years old.");
            System.Console.ReadKey();
            
            System.Console.WriteLine("When is your birthday ?: ");
            birthday = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("So your birthday is in: " + birthday);
            System.Console.ReadKey();
        }
    }
}