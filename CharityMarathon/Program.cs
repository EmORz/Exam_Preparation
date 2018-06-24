using System;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOfMarathon = int.Parse(Console.ReadLine());
            var runnersOfMarathon = long.Parse(Console.ReadLine());
            var numberOfLaps = int.Parse(Console.ReadLine());
            var lenghtOfTrack = long.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var amountOfMoneyDonatePerKilometers = double.Parse(Console.ReadLine());
            //
            var maxCapacityRunners = daysOfMarathon * capacityOfTrack;
            //
            if (maxCapacityRunners<runnersOfMarathon)
            {
                runnersOfMarathon = maxCapacityRunners;
            }
            double totalMeters = runnersOfMarathon * numberOfLaps * lenghtOfTrack;
            totalMeters /= 1000;
            totalMeters *= amountOfMoneyDonatePerKilometers;
            //
            Console.WriteLine($"Money raised: {totalMeters:F2}");
            
        }
    }
}
