using System;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var nWingFlaps = int.Parse(Console.ReadLine());          // 2000
            var distanceInMeters = double.Parse(Console.ReadLine()); //5 meters for 1000 flaps =  2000 
            var endurance = int.Parse(Console.ReadLine());           // 
            //
            var distance = nWingFlaps / 1000 * distanceInMeters;     // its ok

            //and how much time it took him, to travel it. 
            var time = nWingFlaps / 100;
            var restTime = (nWingFlaps / endurance)*5+time;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{restTime} s.");


        }
    }
}
