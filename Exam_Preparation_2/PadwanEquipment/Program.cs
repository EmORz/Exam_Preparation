using System;

namespace PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numStudents = int.Parse(Console.ReadLine());
            //
            var priceLightsabers = double.Parse(Console.ReadLine());
            var priceRobes= double.Parse(Console.ReadLine());
            var priceBelt= double.Parse(Console.ReadLine());
            //
            var addPercentToLightsabers = Math.Ceiling(numStudents * 0.1+numStudents);
            var temp = 0;
            var belt = 0;
            if (numStudents % 6 ==0)
            {
                belt = numStudents / 6;
            }
            else
            {
                belt = (numStudents / 6);
            }
            var beltCont =numStudents - belt ;
            var total =(addPercentToLightsabers*priceLightsabers) + (numStudents * priceRobes)+(beltCont * priceBelt);
            if (total<=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total-budget:f2}lv more.");
            }
        }
    }
}
