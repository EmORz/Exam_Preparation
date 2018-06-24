using System;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distancePer100Flaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());
            //
            double distance = (wingFlaps/1000)*distancePer100Flaps;
            //
            int allSeconds = wingFlaps/100;
            int secondsWithEndurance = (wingFlaps/endurance)*5;
            var timeSeconds = allSeconds + secondsWithEndurance;
            //
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{timeSeconds} s.");
        }
    }
}
