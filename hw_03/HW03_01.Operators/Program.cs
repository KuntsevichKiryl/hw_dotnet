using System;

namespace HW03_01.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = ReadInput("input a");
            double b = ReadInput("input b");
            double d = ReadInput("input result");

            double c = Sum(a, b);
            if (d == c)
            {
                Console.WriteLine("right");
                return;
            }
            Console.WriteLine("wrong");

        }

        private static double ReadInput(string text)
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
