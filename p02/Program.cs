using System;
using System.Collections.Generic;
using System.Linq;

namespace p02
{
    class Program
    {
        //Rainer
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[sequence.Length-1];
            int[] initial = new int[sequence.Length - 1];
            int index = sequence[sequence.Length-1];
            var steps = 0;
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = sequence[i];
                initial[i] = sequence[i];
            }
            while (true)
            {
                for (int i = 0; i < field.Length; i++)
                {
                    field[i]--;
                }
                if (field[index] == 0)
                {
                    break;
                }
                for (int i = 0; i < field.Length; i++)
                {
                    if (field[i] == 0)
                    {
                        field[i] = initial[i];
                    }
                }
                steps++;
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", field));
            Console.WriteLine(steps);
        }
    }
}
