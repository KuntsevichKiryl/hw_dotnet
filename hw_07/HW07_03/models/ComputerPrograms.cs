using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_03.models
{
    class ComputerPrograms : General
    {
        public ComputerPrograms(string name, string code, string category, double size) : base(name,
            code, category, size)
        { }
    }
}
