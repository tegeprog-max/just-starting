using System;
namespace operators
{
    class Program
    {
        static void Main(string [] args)
        {
            int usertries = 0, data = 0;
            while (true)
            {
                System.Console.WriteLine("Done!");
                usertries++;
                data++;
                if(usertries == 5 && data == 5 || data >= 3)
                {
                    break;
                }    
            }
            
        }
    }
}