using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_04.Booking.Com.Models
{
    class Person
    {
        public string name;
        public string password;
        public Person(string login, string pass)
        {
            name = login;
            password = pass;
        }
    }
}
