using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_02.models
{
    public class Person
    {

        public string Name { get; set; }
        House personHouse;
        House.Door personDoor;
        SmallApartment personSmallHouse;
        SmallApartment.Door personSmallDoor;

        public Person(string name, SmallApartment house, SmallApartment.Door door)
        {
            Name = name;
            personSmallHouse = house;
            personSmallDoor = door;
        }
        public Person(string name, House house, House.Door door)
        {
            Name = name;
            personHouse = house;
            personDoor = door;
        }
        public void ShowDataSmall()
        {
            Console.WriteLine("Name: {0}", Name);
            personSmallHouse.ShowData();
            personSmallDoor.ShowData();
        }
        public void ShowData()
        {
            Console.WriteLine("Name: {0}", Name);
            personHouse.ShowData();
            personDoor.ShowData();
        }
    }
}
