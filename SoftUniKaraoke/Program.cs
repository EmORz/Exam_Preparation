using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] clearSongs = new string[songs.Length];
            for (int s = 0; s < songs.Length; s++)
            {
                string temp = songs[s].Trim();
                clearSongs[s] = temp;
            }
            string performance = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            // name of songer and awards
            bool isGetAwards = true;
            while (performance !="dawn")
            {
                string name = performance.Split(new char[] { ','})[0];
                string songPerforming = performance.Split(new char[] { ',' })[1].Trim();
                string awardTheyGet = performance.Split(new char[] { ',' })[2].Trim();
                //
                if (participants.Contains(name) && clearSongs.Contains(songPerforming))
                {
                    isGetAwards = false;
                    if (!data.ContainsKey(name))
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        current.Add(awardTheyGet, 0);
                        data.Add(name, current);
                    }
                    if (!data[name].ContainsKey(awardTheyGet))
                    {
                        data[name].Add(awardTheyGet, 0);
                    }
                }
                performance = Console.ReadLine();
            }
            foreach (var singer in data.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.Write(singer.Key+": ");
                Console.WriteLine(singer.Value.Count+" awards");
                foreach (var item in singer.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine("--" + item.Key);

                }
            }
            if (isGetAwards)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
