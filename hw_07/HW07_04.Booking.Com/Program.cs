using HW07_04.Booking.Com.Models;
using System;

namespace HW07_04.Booking.Com
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonArray basicPers = new();
            AppartmentArray basicApp = new();
            string[] data = new string[2];

            if (basicPers.Login())
            {
                data[0] = basicPers.persArray[basicPers.position].Name;
                string city = "Moscow";
                DateTime arrive = DateTime.Parse("2021/10/1");
                DateTime leave = DateTime.Parse("2021/10/11");
                int person = 2;
                int child = 0;
                int room = 1;
                basicApp.Search(city, arrive, leave, person, child, room);
                data[1] = basicApp.Purchase(arrive, leave, person, child);
            }
        }
    }
}
