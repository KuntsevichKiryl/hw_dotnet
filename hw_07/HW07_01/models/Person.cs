using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_01.models
{
    public class Person
    {
        internal string Age { get; set; }
        internal string SetAge(int n)
        {
            string age = n + " years old";
            return age;
        }
        internal void SayHello()
        {
            Console.WriteLine("\nHello!");
        }
    }
}
