using HW08_03.Models;
using System;

namespace HW08_03
{
    class Program
    {
        static void Main(string[] args)
        {
            DevArray.devArray[1].GetSalary();
            DevArray.devArray[3].GetResponsibilities();
            Array.Sort(DevArray.devArray, new DevArrayByTitle());
            DevArray.DevArrayOut();
        }
    }
}
