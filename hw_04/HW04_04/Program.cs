using System;

namespace HW04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a poem");
            string poemString = Console.ReadLine().Replace("O", "A");
            string[] poem = poemString.Split(";");

            Console.WriteLine("result: ");
            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine(poem[i]);
            }
        }
    }
}
