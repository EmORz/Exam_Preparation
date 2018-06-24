using System;
using System.Collections.Generic;
using System.Linq;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();
            while (command != "I believe I can fly!")
            {
                string[] info = command.Split(' ').ToArray();

                if (info[1] != "=")
                {
                    string customer = info[0];
                    List<int> flights = new List<int>();
                    for (int i = 1; i <= info.Length-1; i++)
                    {
                        flights.Add(int.Parse(info[i]));
                    }
                    if (!customers.ContainsKey(customer))
                    {
                        customers.Add(customer, flights);
                    }
                    else
                    {
                        customers[customer].AddRange(flights);
                    }
                }
                else
                {
                    string customer1 = info[0];
                    string customer2 = info[2];
                    customers[customer1] = customers[customer2].ToList();
                }
                command = Console.ReadLine();
            }
            foreach (var fli in customers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{fli.Key} ::: {string.Join(", ", fli.Value.OrderBy(x => x))}");
            }
        }
    }
}
