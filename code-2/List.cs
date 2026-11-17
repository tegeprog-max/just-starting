using System;
namespace using_lists{
    class Program
    {
        static void Main (string [] args)
        {
            List<String> food = new List<String>();
            food.Add("Potatoes");
            food.Add("Fries");
            System.Console.WriteLine(food[0]);
            System.Console.WriteLine(food.Count);
            System.Console.WriteLine(food.IndexOf("Potatoes"));
            System.Console.WriteLine(food.Contains("Fries"));
            food.Insert(0, "Apple");
            foreach(String foods in food)
            {
               System.Console.WriteLine(foods);
            }
            int i = 0;
            int space = 5;
            while(i < space)
            {
                i++;
                System.Console.WriteLine(".");

            }
            food.Clear();
            food.Insert(0, "PineApple");
            foreach(String foods in food)
            {
                System.Console.WriteLine(foods);
            }


        }
    }
}