using System;
namespace fore
{
    class Program
    {
        static void Main (string [] args)
        {
            String[] foods = {"Egg", "Meat", "Fries"};
            foreach(String food in foods)
            {
                System.Console.WriteLine(food);
            }
        }
    }
}