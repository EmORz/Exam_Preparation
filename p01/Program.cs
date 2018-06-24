using System;
using System.Collections.Generic;
using System.Linq;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raindrops
            var regions = byte.Parse(Console.ReadLine());
            var denisity = float.Parse(Console.ReadLine());
            var sum = 0.0;

            for (int i = 0; i < regions; i++)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                long raindropsCount = long.Parse(info[0]);
                int squareMeters = int.Parse(info[1]);
                double calc = raindropsCount*1.0 / squareMeters;
                sum += calc;
            }
            var first = sum / denisity;
            if (denisity != 0)
            {
                Console.WriteLine($"{first:f3}");
            }
            else
            {
                Console.WriteLine($"{sum:f3}");
            }

        }
    }
}
