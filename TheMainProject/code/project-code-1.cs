using System;
using System.Runtime;
namespace mainproject_head
{
    class Program
    {
        static void Main (string [] args)
        {
            Profile();
        }
        // NickName
        static void Profile()
        {
            // Name
            string name = "TegeStorm";
            System.Console.WriteLine("Name: " + name );
            int age = 24;
            System.Console.WriteLine("Age: " + age + " years old");
             String [] Projects = {"Chesmitry_Lab", "TheMainProject", "Compact_Gamer_B75"} ;
            foreach(String project in Projects)
            {
                System.Console.WriteLine(project);
            }
        }
    }
}