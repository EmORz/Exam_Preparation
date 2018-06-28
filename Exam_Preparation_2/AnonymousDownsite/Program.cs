using System;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberDownSite = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());
            //
            string[] name = new string[numberDownSite];
            decimal[] tootalLosses = new decimal[numberDownSite];
            //
            for (int i = 0; i < numberDownSite; i++)
            {
                var dataForHackSite = Console.ReadLine().Split();
                //
                var site = dataForHackSite[0];
                var siteVisits = long.Parse(dataForHackSite[1]);
                var sitePerVisits = decimal.Parse(dataForHackSite[2]);
                //
                name[i] = site;
                var temp = siteVisits * sitePerVisits;
                tootalLosses[i] = temp;

            }
            Console.WriteLine(string.Join("\n", name));
            var totalLossesSum = tootalLosses.Sum();
            Console.WriteLine($"Total Loss: {totalLossesSum:f20}");
            BigInteger securityTokens = BigInteger.Pow(securityKey, numberDownSite);
            Console.WriteLine("Security Token: " + securityTokens);
        }
    }
}
