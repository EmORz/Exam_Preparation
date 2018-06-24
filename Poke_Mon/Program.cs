using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exhaustion = int.Parse(Console.ReadLine());
            //
            var countTarget = 0;
            double tempPower = pokePower;
            //
            var result = 0;
            while (true)
            {
                tempPower -= distance;
                countTarget++;
                if ((tempPower >= distance) && (tempPower == pokePower*0.5) && (exhaustion !=0))
                {
                    tempPower /= exhaustion;
                }
                if (distance>tempPower)
                {
                    break;
                }
            }
            Console.WriteLine((int)(tempPower));
            Console.WriteLine(countTarget);
        }
    }
}
