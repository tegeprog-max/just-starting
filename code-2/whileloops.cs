using System;
namespace whileloops
{
    class Program
    {
        static void Main(string [] args)
    {
        string name = "";
        while(name == "")
            {
                System.Console.WriteLine("What's your name ?: ");
                name = System.Console.ReadLine();
                if(name != ""){
                    System.Console.WriteLine("Supp: " + name);
                }
                else
                {
                    continue;
                }

            }









        // int infinity = 0, convinf = 0;

        // infinity = Convert.ToInt(convinf);
        // while(convinf <= 10)
        // {
        //     convinf++;
        //     System.Console.WriteLine(convinf);
        // }
    }
    }
}