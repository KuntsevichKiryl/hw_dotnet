using HW08_03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_03.Models
{
    class Architect : Developer, ICountSalary
    {
        public Architect(string firstN, string lastN, int exp, string resp, string tech, string git) : base(firstN, lastN, exp, resp, tech, git)
        {
            Title = "Architect";
            Salary = CountSalary();
        }
        public int CountSalary()
        {
            int salary = baseSalary * 12 + 1000;
            return salary;
        }
    }
}
