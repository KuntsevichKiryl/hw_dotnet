using System;

namespace HW03_09.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a");
            string a = ReadArg();
            Console.WriteLine("Input b");
            string b = ReadArg();
            Console.WriteLine($"Sum = { Calculator.Sum(Convert.ToDouble(a), Convert.ToDouble(b)) }");
            Console.WriteLine($"Sub = { Calculator.Sub(Convert.ToDouble(a), Convert.ToDouble(b)) }");
            Console.WriteLine($"Multiple = { Calculator.Mult(Convert.ToDouble(a), Convert.ToDouble(b)) }");
            Console.WriteLine($"Divide = { Calculator.Div(double.Parse(a), double.Parse(b)) }");
            Console.WriteLine($"Rest from divide = { Calculator.RestDiv(double.Parse(a), double.Parse(b)) }");
            Console.WriteLine($"Circle square a = { Calculator.Square(a) }");
            Console.WriteLine($"Circle square b = { Calculator.Square(b) }");
        }
        static string ReadArg()
        {
            return Console.ReadLine();
        }
    }
    class Calculator
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        public static double RestDiv(double a, double b)
        {
            return a % b;
        }
        public static double Square(string n)
        {
            if (double.TryParse(n, out double r) && r >= 0)
            {
                return Math.PI * Math.Pow(r, 2);
            }
            else
            {
                Console.WriteLine("Incorrect radius");
                return double.NaN;
            }
        }
    }
}
