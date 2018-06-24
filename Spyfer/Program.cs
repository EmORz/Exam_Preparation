using System;
using System.Collections.Generic;
using System.Linq;

namespace Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (i == 0)
                {
                    if (sequence[i] == sequence[i+1])
                    {
                        sequence.RemoveAt(i+1);
                        i = 0;
                    }
                }
                else if (i == sequence.Count - 1)
                {
                    if (sequence[i] == sequence[i-1])
                    {
                        sequence.RemoveAt(i-1);
                        i = 0;
                    }
                }
                else
                {
                    if (sequence[i] == sequence[i-1] + sequence[i+1])
                    {
                        sequence.RemoveAt(i + 1);
                        sequence.RemoveAt(i - 1);
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
