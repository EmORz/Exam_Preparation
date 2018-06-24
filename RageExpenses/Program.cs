using System;
using System.Numerics;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLostGames = int.Parse(Console.ReadLine());
            //
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headsetCount = countLostGames / 2;
            int mouseCount = countLostGames / 3;

            int keyboardCount = 0;
            int displays = 0;
            for (int game = 1; game <= countLostGames; game++)
            {

                if (game % 2 == 0 && game % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displays++;
                    }
                }
            }
            decimal total = (headsetCount*headsetPrice)+(mouseCount*mousePrice)+(keyboardCount*keyboardPrice)+(displays*displayPrice);
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
