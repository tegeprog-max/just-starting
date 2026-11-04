using System;
namespace methods_call{
    class Program{
        static void Main(string [] args){
            String[] name = {"Tege", "Storm"};
            testing_(name[0] + name[1]);
        }
        static void testing_(String naming){
            System.Console.WriteLine(naming);
        }
    }
}

