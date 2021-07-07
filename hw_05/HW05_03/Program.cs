using System;

namespace HW05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a1 = { "arp", "live", "strong" };
            string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[a1.Length];
            int k = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a2[j].Contains(a1[i]))
                    {
                        r[k] = a1[i];
                        k++;
                        j = a2.Length;
                    }
                }
            }
            Array.Resize(ref r, k);
            Array.Sort(r);
            for (k = 0; k < r.Length; k++)
            {
                Console.WriteLine(r[k]);
            }
        }
    }
}
