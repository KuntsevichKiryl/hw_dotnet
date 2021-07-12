using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_02.models
{
    public class House
    {
        public int Area { get; set; }
        public House(int a)
        {
            Area = a;
        }
        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2", Area);
        }
        public Door GetDoor(string color)
        {
            return new Door(color);
        }
        public class Door
        {
            public string Color { get; set; }
            public Door(string color)
            {
                Color = color;
            }
            public void ShowData()
            {
                Console.WriteLine("I am a door, my color is {0}", Color);
            }
        }
    }
}
