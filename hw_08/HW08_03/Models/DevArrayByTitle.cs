using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_03.Models
{
    class DevArrayByTitle : IComparer<Developer>
    {
        static Type[] priority = { typeof(Architect), typeof(TeamLead), typeof(Senior), typeof(Middle), typeof(Junior) };
        public int Compare(Developer x, Developer y)
        {
            int xOrder = Array.IndexOf(priority, x.GetType());
            int yOrder = Array.IndexOf(priority, y.GetType());
            return xOrder.CompareTo(yOrder);
        }
    }
}
