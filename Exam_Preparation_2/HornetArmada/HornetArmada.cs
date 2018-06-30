using System;
using System.Linq;
using System.Collections.Generic;

namespace HornetArmada
{
    class HornerArmada
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, int> lastAct = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legions = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] splitData = Console.ReadLine().Split(" ->=:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                ////
                var lastActivity =int.Parse(splitData[0]);
                var legionName = splitData[1];
                var soldierType = (splitData[2]);
                var soldierCount = long.Parse(splitData[3]);
                //

                if (!legions.ContainsKey(legionName))
                {
                    legions.Add(legionName, new Dictionary<string, long>());
                    lastAct.Add(legionName, lastActivity);
                }
                if (!legions[legionName].ContainsKey(soldierType))
                {
                    legions[legionName][soldierType] = 0;   
                }
                if (lastAct[legionName] < lastActivity)
                {
                    lastAct[legionName] = lastActivity;
                }
                legions[legionName][soldierType] += soldierCount;
            }
            string[] command = Console.ReadLine().Split('\\');

            // Console.WriteLine(string.Join("\n", command));
            if (command.Length  == 1)
            {
                var type = command[0];

                foreach (var item in lastAct.OrderByDescending(activity => activity.Value))
                {

                    if (legions[item.Key].ContainsKey(type) )
                    {
                        Console.WriteLine(item.Value + " : " + item.Key);
                    }
                }

            }
            else
            {
                var searchedAct = int.Parse(command[0]);
                var type = command[1];

                foreach (var item in legions.Where(x => x.Value.ContainsKey(type)).OrderByDescending(f => f.Value[type]))
                {
                    if (lastAct[item.Key] < searchedAct)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value[type]);
                    }

                }

            }
  

        }
    }
}
