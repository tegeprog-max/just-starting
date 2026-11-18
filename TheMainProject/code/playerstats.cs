using System;
namespace playerstats
{
    class Program
    {
        static void Main(string [] args)
        {
            List<String>playerstats = new List<String>();
            playerstats.Add("HP");
            String [] playersts = playerstats.ToArray();
            System.Console.WriteLine(playersts[0]);
           
        }
    }
}