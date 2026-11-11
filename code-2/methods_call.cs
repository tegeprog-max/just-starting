using System;
namespace methods_call{
    class Program{
        static void Main(string [] args){
            String[] name = {"Tege", "Storm"};
            testing_(name[0] + name[1]);
            System.Console.WriteLine(Multiply(5,5));
        }
        static void testing_(String naming){
            System.Console.WriteLine(naming);
        }
        static double Multiply(double a, double b)
        {
            return a * b;

        }
    }
}

