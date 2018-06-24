using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehavies = Console.ReadLine().Split( new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            List<long> aliveBee = new List<long>();
            foreach (var bee in beehavies)
            {
                if (hornets.Count == 0)
                {
                    aliveBee.Add(bee);
                    continue;                    
                }
                var power = hornets.Sum();
                if (power >= bee)
                {
                    if (power == bee)
                    {
                        hornets.RemoveAt(0);
                    }

                }
                else
                {
                    aliveBee.Add(bee - power);
                    hornets.RemoveAt(0);
                }

            }
            if (aliveBee.Count !=0 )
            {
                Console.WriteLine(string.Join(" ", aliveBee));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
