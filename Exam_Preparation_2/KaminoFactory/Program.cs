using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtOfSequence = int.Parse(Console.ReadLine());
            var position = 0;
            var dnaSequence = Console.ReadLine();
            while (dnaSequence!="Clone them!")
            {
                var splitSequence = dnaSequence.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int i = 0; i < splitSequence.Count-1; i++)
                {
                    if (splitSequence[i] == 1)
                    {
                        position = i;
                        Console.WriteLine(splitSequence[i]);
                    }
                }
                dnaSequence = Console.ReadLine();
            }
            Console.WriteLine(position);
        }
    }
}
