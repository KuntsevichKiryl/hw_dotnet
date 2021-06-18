using System;

namespace HW03_01.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = ReadInput("input a");
            double b = ReadInput("input b");

            double c = Sum(a, b);
            Console.WriteLine($"a + b = {c}");
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
