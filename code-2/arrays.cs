using System;
using System.Drawing;
namespace wkingwarrays
{
    class Program
    {
        static void Main (string [] args)
        {
            String[] fruits = {"Apple", "PineApple", "Banana", "Orange"};
            for(int index = 0; index < fruits.Length; index++)
            {
                System.Console.WriteLine(fruits[index]);
            }
        }
    }
}