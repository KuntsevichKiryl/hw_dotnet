using System;

namespace HW04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine($"input array element {i + 1}");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nsource array:");
            WriteArray(array);

            Console.WriteLine("\ninput missing element");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input missing element position");
            int b = int.Parse(Console.ReadLine());

            for (int i = array.Length - 1; i > b - 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[b - 1] = a;

            Console.WriteLine("\nfinal array:");
            WriteArray(array);
        }

        static void WriteArray(int[] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
