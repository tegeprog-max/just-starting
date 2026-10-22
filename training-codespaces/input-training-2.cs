using System;
namespace input_traning_2{

    class Program
    {
        static void Main (string [] args)
        {
            int id, password;
            bool native_lang;
            System.Console.WriteLine("ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            System.Console.WriteLine("Password: ");
            password = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            System.Console.WriteLine("So your ID is: " + id + "and " + " your password is: " + password);
            System.Console.WriteLine("Is English your native lang ?: ");
            native_lang = Convert.ToBoolean(Console.ReadLine());
            Console.ReadKey();
            if(native_lang == true)
            {
                System.Console.WriteLine("nice to know :P ");
            }
            else
            {
                System.Console.WriteLine("Oka '-' ");
            }
        }
    }
}