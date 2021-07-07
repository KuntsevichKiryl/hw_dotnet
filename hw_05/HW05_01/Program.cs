using System;
using System.Text;

namespace HW05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input string");
            string str = Console.ReadLine();
            string str2 = string.Empty;
            char b = default;
            foreach (char i in str)
            {

                if (char.IsDigit(i) || i == '-' || i == '+' || i == '*' || i == '/')
                {
                    str2 = str2 + i;
                }
                if (i == '-' || i == '+' || i == '*' || i == '/')
                {
                    b = i;
                }
            }

            string[] strMas = str2.Split('-', '+', '*', '/');

            if (b == '-')
            {
                Console.WriteLine(Convert.ToInt32(strMas[0]) - Convert.ToInt32(strMas[1]));
            }
            if (b == '+')
            {
                Console.WriteLine(Convert.ToInt32(strMas[0]) + Convert.ToInt32(strMas[1]));
            }
            if (b == '*')
            {
                Console.WriteLine(Convert.ToInt32(strMas[0]) * Convert.ToInt32(strMas[1]));
            }
            if (b == '/')
            {
                Console.WriteLine(Convert.ToInt32(strMas[0]) / Convert.ToInt32(strMas[1]));
            }
        }
    }
}
