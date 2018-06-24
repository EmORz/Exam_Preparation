using System;
using System.Linq;
using System.Collections.Generic;

namespace LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var field = new int[sizeOfField];
            var indexOfLadyBug = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x>=0 && x<sizeOfField)
                .ToList();
            //
            foreach (var item in indexOfLadyBug)
            {
                field[item] = 1;
            }

            while (true)
            {
                var commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands[0] == "end")
                {
                    break;
                }
                var currentIndex = int.Parse(commands[0]);
                var direction = (commands[1]);
                var flyLenght = int.Parse(commands[2]);
                //
                if (direction == "left")
                {
                    flyLenght *= -1;
                }
                if (currentIndex<0 || currentIndex>=sizeOfField)
                {
                    continue;
                }

                if (field[currentIndex] == 0)
                {
                    continue;
                }
                field[currentIndex] = 0;
                var newIndex = currentIndex;

                while (true)
                {
                    newIndex += flyLenght;
                    if (newIndex<0 || newIndex>=sizeOfField)
                    {
                        break;
                    }
                    if (field[newIndex] == 1)
                    {
                        continue;
                    }
                    field[newIndex] = 1;
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", field));

        }
    }
}
