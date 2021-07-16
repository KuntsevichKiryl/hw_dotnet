using HW08_03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_03.Models
{
    class Middle : Developer, ICountSalary
    {
        public Middle(string firstN, string lastN, int exp, string resp, string tech, string git) : base(firstN, lastN, exp, resp, tech, git)
        {
            Title = "Middle Developer";
            Salary = CountSalary();
        }

        public int CountSalary()
        {
            int salary = baseSalary * 3;
            return salary;
        }
    }
}
