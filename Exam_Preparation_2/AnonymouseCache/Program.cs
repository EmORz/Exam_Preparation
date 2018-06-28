using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymouseCache
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = new List<string>();
            var dict = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                var splitInfo = input.Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (splitInfo.Length == 1)
                {
                    var set = splitInfo[0];
                    cache.Add(set);

                }
                else
                {
                    var key = splitInfo[0];
                    var size = long.Parse(splitInfo[1]);
                    var set = splitInfo[2];
                    //
                    if (!dict.ContainsKey(set))
                    {
                        dict.Add(set, new Dictionary<string, long>());
                    }
                    dict[set][key] = size;
                }
                input = Console.ReadLine();
            }
            foreach (var item in cache)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Remove(item);
                }
            }
            if (cache.Count > 0)
            {
                var result = dict.OrderByDescending(x => x.Value.Values.Sum()).First();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Values.Sum()}");
                foreach (var item in result.Value)
                {
                    Console.WriteLine("$."+item.Key);
                }
            }

        }
    }
}
