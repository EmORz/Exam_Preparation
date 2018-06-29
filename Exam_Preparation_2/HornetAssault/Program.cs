using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehavies = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            //
            for (int i = 0; i < beehavies.Count; i++)
            {
                var powerOfHornets = hornets.Sum();

                if (powerOfHornets > 0)
                {

                    if (powerOfHornets > beehavies[i])
                    {
                        beehavies[i] = 0;
                    }
                    else
                    {
                        hornets.RemoveAt(0);
                        beehavies[i] -= powerOfHornets;
                    }
                }
            }
            Console.WriteLine(beehavies.Sum()>0 ? string.Join(" ", beehavies.Where(e => e !=0)):string.Join(" ", hornets));

        } 
    }
}
