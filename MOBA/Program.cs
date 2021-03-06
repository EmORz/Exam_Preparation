﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MOBA
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex battle = new Regex("(vs)");
            Regex statistikForPlayer = new Regex("(->)");

            Dictionary<string, Dictionary<List<string>, int>> statticData = new Dictionary<string, Dictionary<List<string>, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }
                if (statistikForPlayer.Match(input).Success)
                {
                    string[] data = input.Split(new char[] { ' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                    string name = data[0];
                    string position = data[1];
                    List<string> temp = new List<string>();
                    temp.Add(position);
                    int skill = int.Parse(data[2]);

                    if (!statticData.ContainsKey(name))
                    {
                        Dictionary<List<string>, int> current = new Dictionary<List<string>, int>();
                        current.Add(temp, skill);
                        statticData.Add(name, current);
                    }
                    if (!statticData[name].ContainsKey(temp))
                    {
                        statticData[name].Add(temp, skill);
                    }
                    if (statticData[name].ContainsKey(temp))
                    {
                        statticData[name][temp] = skill;

                    }
                }
                if (battle.Match(input).Success)
                {
                    
                }
            }
            foreach (var item in statticData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var temp = 0;
                foreach (var sum in item.Value)
                {
                    temp += sum.Value;
                }
                Console.WriteLine(item.Key+$": {temp} skill");
                foreach (var i in item.Value.OrderByDescending(x => x.Value).ThenBy(y => y))
                {
                    Console.WriteLine("- "+i.Key+ " <::> " + i.Value);
                }
            }
        }
    }
}
