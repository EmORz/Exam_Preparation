using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymouseTreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            // Console.WriteLine(string.Join("\n", inputLine));
            string commands = Console.ReadLine();

            while (commands != "3:1")
            {
                string[] tokens = commands.Split();
                string command = tokens[0];
                if (command == "merge")
                {
                    var stratIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    var stringConcat = "";
                    if (stratIndex > inputLine.Count || stratIndex < 0)
                    {
                        stratIndex = 0;
                    }
                    if (endIndex > inputLine.Count - 1 || endIndex < 0)
                    {
                        endIndex = inputLine.Count - 1;
                    }
                    for (int i = stratIndex; i < endIndex + 1; i++)
                    {
                        stringConcat += inputLine[i];
                    }
                    inputLine.RemoveRange(stratIndex, endIndex - stratIndex + 1);
                    inputLine.Insert(stratIndex, stringConcat);
                }
                else if (command == "divide")
                {
                    List<string> listOfDidvided = new List<string>();
                    var index = int.Parse(tokens[1]);
                    var particion = int.Parse(tokens[2]);
                    //
                    string word = inputLine[index];
                    inputLine.RemoveAt(index);
                    var lenght = word.Length / particion;
                    //
                    for (int i = 0; i < particion; i++)
                    {
                        if (i == particion + 1)
                        {
                            listOfDidvided.Add(word.Substring(lenght * i));
                        }
                        else
                        {
                            listOfDidvided.Add(word.Substring(lenght * i, lenght));
                        }
                    }
                    inputLine.InsertRange(index, listOfDidvided);
                    //

                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
