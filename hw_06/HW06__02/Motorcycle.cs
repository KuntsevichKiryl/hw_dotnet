using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW06__02
{
    class Motorcycle
    {
        internal readonly Guid vin = Guid.NewGuid();
        internal string model;
        internal string manufact;
        internal DateTime year = DateTime.Now;
        internal uint run;
        internal Engine newEngine = new();
        internal class Engine
        {
            internal uint capacity;
            internal uint power;
            internal string engineType;
        }

        string Def(string a)
        {
            a = default;
            Console.WriteLine("Значение сброшено");
            return a;
        }
        uint Def(uint a)
        {
            a = default;
            Console.WriteLine("Значение сброшено");
            return a;
        }
    }
}
