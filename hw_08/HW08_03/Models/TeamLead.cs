using HW08_03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_03.Models
{
    class TeamLead : Developer, ICountSalary
    {
        public TeamLead(string firstN, string lastN, int exp, string resp, string tech, string git) : base(firstN, lastN, exp, resp, tech, git)
        {
            Title = "Team(Teach) Leader";
            Salary = CountSalary();
        }

        public int CountSalary()
        {
            int salary = baseSalary * 8 + 500;
            return salary;
        }
    }
}
