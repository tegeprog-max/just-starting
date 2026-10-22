using System;
namespace hypotenuse
{
    class Program
    {
        static void Main(string [] args)
        {
            double a, b, c;
            System.Console.WriteLine("Try a number: ");
            a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Try another number: ");
            b = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Press any key...");
            System.Console.ReadLine();
            c = Math.Sqrt((a * a) + (b * b));
            System.Console.WriteLine(c);
        }
    }
}