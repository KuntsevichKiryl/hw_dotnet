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
            StringBuilder zipAndAddress = new(zip + ":");
            StringBuilder houseNum = new("/");
            bool check = false;
            for (int i = 0; i < addMas.Length; i++)
            {
                if (addMas[i].Contains(zip))
                {
                    if (check)
                    {
                        houseNum.Append(',');
                        zipAndAddress.Append(',');
                    }
                    int houseInd = addMas[i].IndexOf(' ');
                    houseNum.Append(addMas[i], 0, houseInd);
                    zipAndAddress.Append(addMas[i], houseInd + 1, addMas[i].Length - houseInd - 1);
                    zipAndAddress.Remove(zipAndAddress.Length - zip.Length - 1, zip.Length + 1);
                    check = true;
                }
            }
            zipAndAddress.Append(houseNum);
            return (zipAndAddress.ToString());
        }
    }
}
