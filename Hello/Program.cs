using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yoour name is?...");
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            if (hoursOfSleep < 8)
            {
                Console.WriteLine("You need to get more sleep");
            } 
            else
            {
                Console.WriteLine("You are well rested.");
            }
            
        }
    }
}
