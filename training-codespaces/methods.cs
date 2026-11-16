using System;
namespace methods_training
{
    class Program
    {
        static void Main (string [] args)
        {
            calling_names("Santiago");
            Multiply(5.5);
            Plus(5);
            Arr(["Tomato", "Apple", "Banana"]);
            trueorfalse(true);
        }
        static void calling_names(String name)
        {
            System.Console.WriteLine(name);
        }
        static void Multiply(double res)
        {
            System.Console.WriteLine(res * res);
        }
        static void Plus(int res)
        {
            System.Console.WriteLine(res + res);
        }
        static void Arr(String[] somearr)
        {
            foreach(String arr in somearr)
            {
                System.Console.WriteLine(arr);
            }
        }
        static void trueorfalse(Boolean trueorfalsebuddy)
        {
            System.Console.WriteLine(trueorfalsebuddy);
        }
    }
}