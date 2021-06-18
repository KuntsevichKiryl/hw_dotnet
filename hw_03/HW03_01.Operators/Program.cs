using System;

namespace HW03_01.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = ReadVar("input a");
            double b = ReadVar("input b");
            double c = Action("what to do + or -", a, b);
            double d = ReadVar("input result");

            if (d == c)
            {
                Console.WriteLine("right");
                return;
            }
            if (d < c)
            {
                Console.WriteLine("wrong, must be greater");
                return;
            }

            Console.WriteLine("wrong, must be less");

        }

        private static double Action(string text, double a, double b)
        {
            Console.WriteLine(text);
            string action = Console.ReadLine();
            switch (action)
            {
                case "+": return Sum(a, b);
                case "-": return (a - b);
                default:
                    Console.WriteLine("incorrect action");
                    System.Environment.Exit(1);
                    return double.NaN;
            }
        }

        private static double ReadVar(string text)
        {
            try
            {
                Console.WriteLine(text);
                return Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input");
                System.Environment.Exit(1);
                return double.NaN;
            }
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
