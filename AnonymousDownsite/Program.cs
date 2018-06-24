using System;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int countAfectSite = int.Parse(Console.ReadLine());
            int securyriteToken = int.Parse(Console.ReadLine());
            string[] siteData = new string[countAfectSite];
            decimal middSum = 0M;
            BigInteger secToken = 1;
            for (int site = 0; site < countAfectSite; site++)
            {
                string[] dataWebsite = Console.ReadLine().Split(' ').ToArray();
                string sites = dataWebsite[0];
                long siteVisits = Convert.ToInt64(dataWebsite[1]);
                decimal sitePricePerVisite = Convert.ToDecimal(dataWebsite[2]);
                //
                siteData[site] = sites;
                middSum += (sitePricePerVisite*siteVisits);
                secToken *= securyriteToken;

            }
            foreach (var item in siteData)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total Loss: {middSum:F20}");
            Console.WriteLine($"Security Token: {secToken}");
        }
    }
}
