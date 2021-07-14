using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_01.models
{
    public class Teacher : Person
    {
        private readonly string _subject = "Csharp";
        public void Explain()
        {
            Console.WriteLine("Our topic today is {0}. Explanation begins", _subject);
        }
    }
}
