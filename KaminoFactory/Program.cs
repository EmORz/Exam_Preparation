using System;
using System.Collections.Generic;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtSequence = int.Parse(Console.ReadLine());
            //
            List<int[]> tempList1 = new List<int[]>();
            List<byte> position = new List<byte>();
            List<string> tempL = new List<string>();
            //
            var count = 0;
            //
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] sequence = input.Split('!').Select(int.Parse).ToArray();
            }
            //ToDo


        }
    }
}
