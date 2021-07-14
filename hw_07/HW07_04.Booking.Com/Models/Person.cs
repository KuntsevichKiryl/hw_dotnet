using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_04.Booking.Com.Models
{
    class Person
    {
        string _name;
        internal string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        string _password;
        internal string Password
        {
            get
            {
                return _password;
            }
            private set
            {
                _password = value;
            }
        }
        public Person(string login, string pass)
        {
            Name = login;
            Password = pass;
        }
    }
}
