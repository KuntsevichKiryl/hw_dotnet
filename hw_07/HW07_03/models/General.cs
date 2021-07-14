using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_03.models
{
    class General
    {
        string Name { get; set; }
        string Code { get; set; }
        string Category { get; set; }
        double Size { get; set; }
        public General(string name, string code,string category,double size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }
    }
}
