using System;
using System.Text;

namespace HW05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071," +
                "786 High Street Pollocksville NY 56432";
            Console.WriteLine("input zipcode");
            string zip = Console.ReadLine();
            string trav = Travel(addresses, zip);
            Console.WriteLine(trav);
        }
        static string Travel(string add, string zip)
        {
            string[] addMas = add.Split(',');
            StringBuilder sB = new(zip + ":");
            StringBuilder sB2 = new("/");
            bool check = false;
            for (int i = 0; i < addMas.Length; i++)
            {
                if (addMas[i].Contains(zip))
                {
                    if (check == true)
                    {
                        sB2.Append(',');
                        sB.Append(',');
                    }
                    int houseInd = addMas[i].IndexOf(' ');
                    sB2.Append(addMas[i], 0, houseInd);
                    sB.Append(addMas[i], houseInd + 1, addMas[i].Length - houseInd - 1);
                    sB.Remove(sB.Length - zip.Length - 1, zip.Length + 1);
                    check = true;
                }
            }
            sB.Append(sB2);
            return (sB.ToString());
        }
    }
}
