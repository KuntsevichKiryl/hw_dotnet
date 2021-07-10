using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_01.models
{
    public class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0}", Age);
        }
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }
    }
}
