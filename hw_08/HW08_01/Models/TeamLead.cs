﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_01.Models
{
    class TeamLead : Developer
    {
        protected override int Salary { get => base.Salary; set => base.Salary = value * 8 + 500; }
        public TeamLead(string firstN, string lastN, int exp, string resp, string tech, string git) : base(firstN, lastN, exp, resp, tech, git)
        {
            Title = "Team(Teach) Leader";
        }
    }
}
