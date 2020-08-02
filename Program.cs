using System;

namespace Code_Challenge_Day_16_Exceptions__String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            try
            {
                Console.WriteLine(int.Parse(s));
            }
            catch(Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
