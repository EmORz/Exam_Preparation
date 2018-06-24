using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var numIterationBall = int.Parse(Console.ReadLine());
            //(snowballSnow / snowballTime) ^ snowballQuality
            int snow = 0;
            int time = 0;
            int quality = 0;
            BigInteger resultat = 0;
            for (int i = 0; i < numIterationBall; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                BigInteger temp = (snowballSnow/snowballTime);
                BigInteger result = temp;
                for (int j = 1; j < snowballQuality; j++)
                {
                    result *= temp;
                }
                if (result > resultat)
                {
                    resultat = result;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {resultat} ({quality})");
        }
    }
}
