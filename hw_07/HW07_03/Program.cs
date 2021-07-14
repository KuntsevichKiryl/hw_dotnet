using HW07_03.models;
using System;

namespace HW07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int i;
            MusicFiles[] musArray = new MusicFiles[10];
            for (i = 0; i < 10; i++)
            {
                musArray[i] = new MusicFiles(RandomString(), rnd.Next(10, 3600), RandomString(),
                    RandomString(), RandomString(), rnd.Next());
            }
            Films[] filmsArray = new Films[11];
            for (i = 0; i < 11; i++)
            {
                filmsArray[i] = new Films(RandomString(), RandomString(), RandomString(),
                    RandomString(), RandomString(), RandomString(), rnd.Next());
            }
            ComputerPrograms[] progArray = new ComputerPrograms[12];
            for (i = 0; i < 12; i++)
            {
                progArray[i] = new ComputerPrograms(RandomString(), RandomString(), RandomString(), rnd.Next());
            }
        }
        public static string RandomString()
        {
            Random rnd = new();
            string stringRnd = "";
            for (int i = 0; i < 11; i++)
            {
                stringRnd += ((char)rnd.Next(97, 122)).ToString();
            }
            return stringRnd;
        }
    }
}
