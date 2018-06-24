using System;
using System.Globalization;
using System.Numerics;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                DateTime dt = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
                var secInOneDay = 24 * 60 * 60;
                //Console.WriteLine(secInOneDay);
                BigInteger steps = BigInteger.Parse(Console.ReadLine())%secInOneDay;
                BigInteger secondsPerSteps = BigInteger.Parse(Console.ReadLine());
                //
                BigInteger timeForStepsInSec = steps * secondsPerSteps;
                //
                dt = dt.AddSeconds((double)timeForStepsInSec);
                Console.WriteLine($"Time Arrival: {dt.Hour.ToString("00")}:{dt.Minute.ToString("00")}:{dt.Second.ToString("00")}");
            }
            catch (Exception)
            {

                
            }


        }
    }
}
