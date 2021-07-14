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
        string _model;
        internal string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        string _manufact;
        internal string Manufact
        {
            get
            {
                return _manufact;
            }
            set
            {
                _manufact = value;
            }
        }

        internal readonly DateTime year = DateTime.Now;
        uint _run;
        internal uint Run
        {
            get
            {
                return _run;
            }
            set
            {
                _run = value;
            }
        }

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
