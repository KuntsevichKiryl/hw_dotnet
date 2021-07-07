using System;
using System.Diagnostics;

namespace HW04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            long[] array = new long[100_000_000];
            Random ran = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next();
            }

            Stopwatch my = new Stopwatch();
            my.Start();
            ReverseArray(array);
            my.Stop();

            Stopwatch notMy = new Stopwatch();
            notMy.Start();
            Array.Reverse(array);
            notMy.Stop();

            Console.WriteLine($"my time: {my.ElapsedMilliseconds} ms");
            Console.WriteLine($"not my time: {notMy.ElapsedMilliseconds} ms");

        }
        static void ReverseArray(long[] array)
        {
            int i;
            long a;
            for (i = 0; i <= array.Length / 2; i++)
            {
                a = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = a;
            }
        }
    }
}
