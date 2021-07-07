using System;
using System.Text;

namespace HW05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "!1a!2.3!!.. 4.!.?6 7! ..?";
            int a = str.Length - str.IndexOf('?');
            StringBuilder sB = new(str);
            sB.Replace(' ', '_', sB.Length + 1 - a, a - 1);
            for (int i = 0; i < sB.Length - a; i++)
            {
                if (sB[i] == '!' || sB[i] == '.')
                {
                    sB.Remove(i, 1);
                    i--;
                }
            }
            str = sB.ToString();
            Console.WriteLine(str);
        }
    }
}
