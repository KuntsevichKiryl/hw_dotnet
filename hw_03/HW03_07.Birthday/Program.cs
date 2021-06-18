using System;

namespace HW03_07.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input birth yaer");
            uint year = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Input birth month number");
            uint month = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Input present yaer");
            uint yearnow = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Input present month number");
            uint monthnow = Convert.ToUInt32(Console.ReadLine());
            if (year > yearnow || month > 12 || month == 0 || monthnow > 12 || monthnow == 0)
            {
                Console.WriteLine("incorrect date");
                return;
            }
            uint age = month - monthnow < 0 ? yearnow - year : yearnow - year - 1;
            Console.WriteLine($"Age: {age}");
        }
    }
}
