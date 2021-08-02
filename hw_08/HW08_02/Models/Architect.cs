using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_02.Models
{
    class Architect : Developer
    {
        protected override int Salary { get => base.Salary; set => base.Salary = value * 12 + 1000; }
        public Architect(string firstN, string lastN, int exp, string resp, string tech, string git) : base(firstN, lastN, exp, resp, tech, git)
        {
            Title = "Architect";
        }
    }
}
