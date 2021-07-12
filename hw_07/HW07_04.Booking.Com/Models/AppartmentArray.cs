using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_04.Booking.Com.Models
{
    class AppartmentArray
    {
        public readonly Appartment[] appArray = new Appartment[] {
            new Appartment("Moscow", DateTime.Parse("2021/8/5"), DateTime.Parse("2021/10/20"), 2, 0, 1, 150),
            new Appartment("Moscow", DateTime.Parse("2021/9/15"), DateTime.Parse("2021/10/28"), 4, 7, 2, 160),
            new Appartment("Taganrog", DateTime.Parse("2021/9/15"), DateTime.Parse("2021/10/28"), 4, 2, 2, 60) };
        int[] chosenApp = new int[10];
        int j = 0;
        public void Search(string town, DateTime arrive, DateTime leave, int person, int child, int room)
        {
            for (int i = 0; i < appArray.Length; i++)
            {
                if (town.Equals(appArray[i].city))
                {
                    if (arrive >= appArray[i].arriveDate && arrive < appArray[i].leaveDate)
                    {
                        if (leave <= appArray[i].leaveDate && leave > appArray[i].arriveDate)
                        {
                            if (person <= appArray[i].numOfPerson)
                            {
                                if (child <= appArray[i].numOfChild)
                                {
                                    if (room <= appArray[i].numOfRoom)
                                    {
                                        chosenApp[j] = i;
                                        Console.WriteLine("\n{0}. {1}", j + 1, appArray[i].ToString());
                                        j++;
                                        Console.WriteLine("From {0} to {1} it will cost for you - {2}",
                                            arrive, leave, CalcPrice(arrive, leave, person, appArray[i].basePrice));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (j == 0)
            {
                Console.WriteLine("\nThere is no any apartments");
            }

        }
        private int CalcPrice(DateTime arrive, DateTime leave, int numOfPers, int basePrice)
        {
            int price = Convert.ToInt32((leave - arrive).TotalDays * basePrice / 5 + numOfPers * basePrice * 0.5);
            return price;
        }
        public string Purchase(DateTime arrive, DateTime leave, int person, int child)
        {
            if (j != 0)
            {
                int a;
                Console.WriteLine("\nChoose variant by pressing its number");
                a = Convert.ToInt32(Console.ReadLine());
                appArray[chosenApp[a - 1]].arriveDate = arrive;
                appArray[chosenApp[a - 1]].leaveDate = leave;
                appArray[chosenApp[a - 1]].numOfPerson = person;
                appArray[chosenApp[a - 1]].numOfChild = child;
                appArray[chosenApp[a - 1]].wholePrice = CalcPrice(arrive, leave, person, appArray[chosenApp[a - 1]].basePrice);
                string result=appArray[chosenApp[a - 1]].ToString() + ", price - " + CalcPrice(arrive, leave, person, appArray[chosenApp[a - 1]].basePrice);
                appArray[chosenApp[a - 1]] = default;
                return result;
            }
            else
            {
                Console.WriteLine("\nYou didn't find acceptable variant");
                return string.Empty;
            }
        }
    }
}
