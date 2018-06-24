using System;

namespace Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double tank = double.Parse(Console.ReadLine());
            double heavyWinds = double.Parse(Console.ReadLine());
            //
            var perMile = 25;
            var perMileHeavy = perMile * 1.5;
            //
            var normal = distance - heavyWinds;
            var specialCase = heavyWinds * perMileHeavy;
            var normalCase = normal * perMile;
            //
            var totalFuel = normalCase + specialCase;
            totalFuel *= 1.05;
            Console.WriteLine($"Fuel needed: {totalFuel:f2}L");
            //
            if (tank>=totalFuel)
            {
                Console.WriteLine($"Enough with {tank-totalFuel:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {totalFuel-tank:f2}L more fuel.");
            }

              
        }
    }
}
