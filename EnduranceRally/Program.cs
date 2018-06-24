using System;
using System.Collections.Generic;
using System.Linq;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] zonesTrace = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] indexFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //
            //starting fuel
            var position = 0;

            for (int i = 0; i < drivers.Length; i++)
            {
                bool isPositiveFuel = true;
                double fuel = drivers[i].ToCharArray()[0];
                for (int j = 0; j < zonesTrace.Length; j++)
                {
                    if (indexFuel.Contains(j))
                    {
                        fuel += zonesTrace[j];
                    }
                    else
                    {
                        fuel -= zonesTrace[j];
                    }
                    if (fuel<=0)
                    {
                        position = j;
                        isPositiveFuel = false;
                        break;
                    }
                }
                if (isPositiveFuel)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{drivers[i]} - reached {position}");
                }
            }
        }
    }
}
