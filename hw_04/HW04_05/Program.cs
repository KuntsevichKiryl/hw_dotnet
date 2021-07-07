using System;

namespace HW04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ("A collection of reading resources mostly about " +
                "life and issues in Britain and the United States, in intermediate level " +
                "English - with word guides, exercises and classroom activities.");
            Console.WriteLine($"source string:\n{str}");

            LongDel(str);
            LongToShort(str);
            LetterCount(str);
            SortArray(str);
        }
        static void LongDel(string str)
        {
            string[] strMas = str.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int lenght = 0;
            int i;
            for (i = 0; i < strMas.Length; i++)
            {
                if (lenght < strMas[i].Length)
                {
                    lenght = strMas[i].Length;
                }
            }

            for (i = 0; i < strMas.Length; i++)
            {
                if (lenght == strMas[i].Length)
                {
                    str = str.Replace(strMas[i], "");
                }
            }

            Console.WriteLine($"\nstring with longest word deleted:\n{str.Replace("  ", " ")}");
        }
        static void LongToShort(string str)
        {
            string[] strMas = str.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int lenghtMax = 0;
            int lenghtMin = strMas[0].Length;
            string lon = null;
            string shor = null;
            string temp = "---";
            for (int i = strMas.Length - 1; i >= 0; i--)
            {
                if (lenghtMax < strMas[i].Length)
                {
                    lenghtMax = strMas[i].Length;
                    lon = strMas[i];
                }
                if (lenghtMin >= strMas[i].Length)
                {
                    lenghtMin = strMas[i].Length;
                    shor = strMas[i];
                }
            }

            if (shor == strMas[0])
            {
                str = " " + str;
            }

            Console.WriteLine($"\nstring with longest and shortest words swapped:\n{str.Replace(" " + shor, " " + temp).Replace(lon, shor).Replace(temp, lon).Trim()}");
        }
        static void LetterCount(string str)
        {
            char[] ch = str.ToCharArray();
            int i;
            int letter = 0;
            int whiteSpc = 0;
            for (i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(ch[i]))
                {
                    letter++;
                }
                if (char.IsWhiteSpace(ch[i]))
                {
                    whiteSpc++;
                }
            }
            Console.WriteLine($"\nletters: {letter}, spaces: {whiteSpc}, punctuation marks: {str.Length - letter - whiteSpc}");
        }
        static void SortArray(string str)
        {
            string[] strMas = str.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(strMas, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(strMas);
            Console.WriteLine("\nsorted array:");
            for (int i = 0; i < strMas.Length; i++)
            {
                Console.WriteLine(strMas[i]);
            }
        }
    }
}
