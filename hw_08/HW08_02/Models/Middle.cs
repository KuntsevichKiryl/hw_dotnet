using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_02.Models
{
    class Middle : Developer
    {
        protected override int Salary { get => base.Salary; set => base.Salary = value * 3; }
        public Middle(string firstN, string lastN, int exp, string resp, string tech, string git) : base(firstN, lastN, exp, resp, tech, git)
        {
            Title = "Middle Developer";
        }
    }
}
