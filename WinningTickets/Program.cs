using System;
using System.Linq;

namespace WinningTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var tick in input)
            {

                var left = new string(tick.Take(10).ToArray());
                var right = new string(tick.Skip(10).Take(10).ToArray());

                var countL = SeqCount(left);
                var countR = SeqCount(right);
                var min = Math.Min(countL, countR);
                if (tick.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var symbol = "";
                    foreach (var item in tick)
                    {
                        if (item == '@' || item == '#' || item == '$' || item == '^')
                        {
                            symbol = item.ToString();
                            break;
                        }
                    }
                    if (min == 10)
                    {
                        Console.Write($"ticket ");
                        Console.Write($"\"{tick}\"");
                        Console.WriteLine($" - {min}{symbol} Jackpot!");
                    }
                    else if (min >= 6 && min <10)
                    {
                        Console.Write($"ticket ");
                        Console.Write($"\"{tick}\"");
                        Console.WriteLine($" - {min}{symbol}");
                    }
                    else
                    {
                        Console.Write($"ticket ");
                        Console.Write($"\"{tick}\" - ");
                        Console.WriteLine("no match");
                    }
                }



            }

        }
        static int SeqCount(string side)
        {
            int count = 1;
            int longest = int.MinValue;
            //
            for (int i = 0; i < side.Length - 1; i++)
            {
                var cuurent = side[i];
                var next = side[i + 1];

                if ('@' == side[i] || '#' == side[i] || '$' == side[i] || '^' == side[i])
                {
                    if (cuurent == next)
                    {
                        count++;
                    }
                }
                else
                {
                    longest = count;
                    count = 1;
                }
            }
            if (count > longest)
            {
                longest = count;
                count = 1;
            }

            return longest;
        }
    }
}
