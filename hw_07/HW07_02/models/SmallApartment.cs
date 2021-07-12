using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_02.models
{
    public class SmallApartment : House
    {
        public SmallApartment(int a) : base(a)
        {
        }
        public override void ShowData()
        {
            Console.WriteLine("I am a little apartment, my area is {0} m2", Area);
        }
    }
}
