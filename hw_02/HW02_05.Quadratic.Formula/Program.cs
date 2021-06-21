using System;

namespace HW02_05.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            try
            {
                Console.WriteLine("Input a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input c");
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (a == 0)
            {
                double x = -c / b;
                Console.WriteLine($"Корень {x}");
                return;
            }

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("Корней нет");
                return;
            }

            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine($"Первый корень: {x1} \nВторой корень: {x2}");


        }
    }
}
