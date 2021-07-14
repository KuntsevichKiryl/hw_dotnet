using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_04.Booking.Com.Models
{
    class PersonArray
    {
        public readonly Person[] persArray = new Person[] { new Person("Vasya", "123qwe"),
            new Person("Petya", "456asd"), new Person("Huan", "789zxc") };
        public int position = -1;
        public bool Login()
        {
            Console.WriteLine("Input login");
            string name = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < persArray.Length; i++)
            {
                if (name.Equals(persArray[i].Name))
                {
                    Console.WriteLine("Input password");
                    string pass = Console.ReadLine();
                    if (pass.Equals(persArray[i].Password))
                    {
                        check = true;
                        Console.WriteLine("\nWelcome {0}", name);
                        position = i;
                        break;
                    }
                    else Console.WriteLine("Wrong password");
                    break;
                }
                if (i == persArray.Length - 1)
                {
                    Console.WriteLine("User {0} does not exist", name);
                }
            }
            return check;
        }
    }
}
