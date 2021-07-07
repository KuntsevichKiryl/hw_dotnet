using System;

namespace HW04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] array1 = new int[10];
            Random ran = new Random();
            for (i = 0; i < array1.Length; i++)
            {
                array1[i] = ran.Next();
            }

            int[] array2 = new int[10];
            for (i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"input array element {i + 1}");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int[] array3 = new int[10];
            for (i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }

            Console.WriteLine("\nArray 1: ");
            WriteArray(array1);
            Console.WriteLine("\nArray 2: ");
            WriteArray(array2);
            Console.WriteLine("\nArray 3: ");
            WriteArray(array3);

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
