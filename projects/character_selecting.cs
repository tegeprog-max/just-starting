using System;
namespace characters_roll
{
    class Program
    {
        static void Main (string [] args)
        {
            String[] character = {"Tege","Storm","Darton","Rose"};
            rolling(character);            
        }
        static void rolling(String[] character)
        {
            while(true){
                for(int index = 0; index < character.Length; index++)
                {
                    System.Console.WriteLine(character[index]);
                    Thread.Sleep(200);
                    System.Console.Clear();                
                }
            }
                            
        }
    }
}