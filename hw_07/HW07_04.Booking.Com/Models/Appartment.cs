using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_04.Booking.Com.Models
{
    class Appartment
    {
        string _city;
        internal string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        DateTime _arriveDate;
        internal DateTime ArriveDate
        {
            get
            {
                return _arriveDate;
            }
            set
            {
                _arriveDate = value;
            }
        }
        DateTime _leaveDate;
        internal DateTime LeaveDate
        {
            get
            {
                return _leaveDate;
            }
            set
            {
                _leaveDate = value;
            }
        }

        int _numOfPerson;
        internal int NumOfPerson
        {
            get
            {
                return _numOfPerson;
            }
            set
            {
                _numOfPerson = value;
            }
        }
        int _numOfChild;
        internal int NumOfChild
        {
            get
            {
                return _numOfChild;
            }
            set
            {
                _numOfChild = value;
            }
        }
        int _numOfRoom;
        internal int NumOfRoom
        {
            get
            {
                return _numOfRoom;
            }
            set
            {
                _numOfRoom = value;
            }
        }
        int _basePrice;
        internal int BasePrice
        {
            get
            {
                return _basePrice;
            }
            set
            {
                _basePrice = value;
            }
        }
        int _wholePrice;
        internal int WholePrice
        {
            get
            {
                return _wholePrice;
            }
            set
            {
                _wholePrice = value;
            }
        }

        public Appartment(string town, DateTime arrive, DateTime leave, int person, int child, int room, int price)
        {
            City = town;
            ArriveDate = arrive;
            LeaveDate = leave;
            NumOfPerson = person;
            NumOfChild = child;
            NumOfRoom = room;
            BasePrice = price;
        }
        public override string ToString()
        {
            return $"City - {City}, arrive date - {ArriveDate}, leave date - {LeaveDate}, maximum number of persons - {NumOfPerson}, maximum number of children - {NumOfChild}, maximum rooms - {NumOfRoom}";
        }
    }
}
