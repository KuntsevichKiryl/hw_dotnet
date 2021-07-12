using HW07_02.models;
using System;

namespace HW07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input area");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("input person name");
            string name = Console.ReadLine();
            Console.WriteLine("input door color");
            string color = Console.ReadLine();

            if (area > 50)
            {
                House house = new(area);
                House.Door door = house.GetDoor(color);
                Person person = new(name, house, door);
                person.ShowData();
            }
            else
            {
                SmallApartment house = new(area);
                SmallApartment.Door door = house.GetDoor(color);
                Person person = new(name, house, door);
                person.ShowDataSmall();
            }
        }
    }
}
