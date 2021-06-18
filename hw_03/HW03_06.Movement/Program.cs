using System;

namespace HW03_06.Movement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("to exit input \"exit\"");
            while (true)
            {
                Movement("where to go");
            }
        }

        private static void Movement(string text)
        {
            Console.WriteLine(text);
            string action = Console.ReadLine();
            switch (action)
            {
                case "w":
                case "W":
                    Console.WriteLine("forward");
                    break;
                case "a":
                case "A":
                    Console.WriteLine("left");
                    break;
                case "s":
                case "S":
                    Console.WriteLine("back");
                    break;
                case "d":
                case "D":
                    Console.WriteLine("right");
                    break;
                case "exit":
                case "EXIT":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("stay");
                    break;
            }
        }
    }
}
