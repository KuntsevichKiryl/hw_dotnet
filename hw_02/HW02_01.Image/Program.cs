using System;
using System.IO;
namespace HW02_01.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1. Чтение текстового файла
             * 2. Создание и заполнение массива для хранения значений байтов в текстовом виде
             * 3. Создание массива байтов из их текстового представления
             * 4. Сохранение массива байтов в формате изображения
             */

            StreamReader textReader = new StreamReader(@"..\..\..\source\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();
            string[] arrayOfTextResult = textReaderResult.Trim().Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length];
            for (int i = 0; i < arrayOfTextResult.Length; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"..\..\..\source\image.png", imageBytes);
        }
    }
}
