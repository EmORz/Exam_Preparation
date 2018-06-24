using System;
using System.Collections.Generic;
using System.Linq;

namespace NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            while(command != "quit")
            {
                string[] info = command.Split(new char[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string country = info[0];
                string name = info[1];
                int days = int.Parse(info[2]);
                //
                if (!data.ContainsKey(country))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(name, days);
                    data.Add(country, current);
                }
                else
                {
                    if (!data[country].ContainsKey(name))
                    {
                        data[country].Add(name, days);
                    }
                    else
                    {
                        data[country][name] = days;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var pair in data.OrderByDescending(x => x.Value.Count ))
            {
                Console.WriteLine($"Country: {pair.Key}");
                foreach (var item in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{item.Key} : {item.Value}");
                }
            }

        }
    }
}
