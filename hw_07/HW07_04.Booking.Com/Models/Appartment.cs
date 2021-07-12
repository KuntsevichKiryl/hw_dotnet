using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_04.Booking.Com.Models
{
    class Appartment
    {
        public string city;
        public DateTime arriveDate;
        public DateTime leaveDate;
        public int numOfPerson;
        public int numOfChild;
        public int numOfRoom;
        public int basePrice;
        public int wholePrice;

        public Appartment(string town, DateTime arrive, DateTime leave, int person, int child, int room, int price)
        {
            city = town;
            arriveDate = arrive;
            leaveDate = leave;
            numOfPerson = person;
            numOfChild = child;
            numOfRoom = room;
            basePrice = price;
        }
        public override string ToString()
        {
            return $"City - {city}, arrive date - {arriveDate}, leave date - {leaveDate}, maximum number of persons - {numOfPerson}, maximum number of children - {numOfChild}, maximum rooms - {numOfRoom}";
        }
    }
}
