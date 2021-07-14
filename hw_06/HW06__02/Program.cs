using System;

namespace HW06__02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество мотоциклов");
            uint n = UintValid();
            Motorcycle[] newMoto = new Motorcycle[n];

            for (byte i = 0; i < n; i++)
            {
                newMoto[i] = new Motorcycle();
                Console.WriteLine("\nМодель мотоцикла №{0}", i + 1);
                newMoto[i].Model = ReadArg();
                Console.WriteLine("Производитель мотоцикла");
                newMoto[i].Manufact = ReadArg();
                Console.WriteLine("Пробег");
                newMoto[i].Run = RunCheck();
                Console.WriteLine("Тип двигателя");
                uint engType = EngineSelect();

                switch (engType)
                {
                    case 1:
                        newMoto[i].newEngine.engineType = "бензиновый";
                        Console.WriteLine("Объем");
                        newMoto[i].newEngine.capacity = CapacityCheck();
                        break;
                    case 2:
                        newMoto[i].newEngine.engineType = "электро";
                        break;
                    case 3:
                        newMoto[i].newEngine.engineType = "гибрид";
                        Console.WriteLine("Объем");
                        newMoto[i].newEngine.capacity = CapacityCheck();
                        break;
                }
                Console.WriteLine("Мощность");
                newMoto[i].newEngine.power = PowerCheck();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nМотоцикл №{0}", i + 1);
                Console.WriteLine("Мотоцикл (Производитель): {0}, Модель: {1}, Vin Number(Идентификатор): {2}, Год выпуска: {3}, " +
                    "Пробег: {4} км, Тип двигателя: {5}, Двигатель(Объем): {6} куб.см, Мощность: {7} л/с",
                    newMoto[i].Manufact, newMoto[i].Model, newMoto[i].vin, newMoto[i].year.Year, newMoto[i].Run,
                    newMoto[i].newEngine.engineType, newMoto[i].newEngine.capacity, newMoto[i].newEngine.power);
            }

        }

        static uint UintValid()
        {
            bool valid = uint.TryParse(ReadArg(), out uint a);
            while (!valid)
            {
                Console.WriteLine("Неверное значение");
                valid = uint.TryParse(ReadArg(), out a);
            }
            return a;
        }
        static string ReadArg()
        {
            string data = Console.ReadLine();
            while (String.IsNullOrEmpty(data))
            {
                Console.WriteLine("Данные не введены, повторите ввод");
                data = Console.ReadLine();
            }
            return data;
        }
        static uint RunCheck()
        {
            uint run;
            do
            {
                Console.WriteLine("выбрать от 0 до 100");
                run = UintValid();
            } while (run > 100);
            return run;
        }
        static uint EngineSelect()
        {
            uint engType;
            do
            {
                Console.WriteLine("ввести 1 для бензинового, 2 для электро, 3 для гибрида");
                engType = UintValid();
            } while (engType != 1 && engType != 2 && engType != 3);
            return engType;
        }
        static uint CapacityCheck()
        {
            uint capacity;
            do
            {
                Console.WriteLine("от 125 до 3200");
                capacity = UintValid();
            } while (capacity < 125 || capacity > 3200);
            return capacity;
        }
        static uint PowerCheck()
        {
            uint power;
            do
            {
                Console.WriteLine("от 50 до 300");
                power = UintValid();
            } while (power < 50 || power > 300);
            return power;
        }
    }
}
