using System;
using System.Collections.Generic;
using System.Linq;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();

            for (long i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(';').ToArray();
                string directory = info[0];
                long size = long.Parse(info[1]);
                List<string> fileInfo = directory.Split('\\').ToList();
                string file = fileInfo[fileInfo.Count - 1];
                fileInfo.RemoveAt(fileInfo.Count-1);
                string root = string.Join("\\",fileInfo);
                if (!database.ContainsKey(root))
                {
                    Dictionary<string, long> current = new Dictionary<string, long>();
                    current.Add(file, size);
                    database.Add(root, current);

                }
                else
                {
                    if (!database[root].ContainsKey(file))
                    {
                        database[root].Add(file, size);
                    }
                    else
                    {
                        database[root][file] = size;
                    }
                }
            }
            string[] final = Console.ReadLine().Split(new[] { " in "}, StringSplitOptions.None).ToArray();
            string extencion = final[0];
            string place = final[1];

            Dictionary<string, long> wontedOnes = new Dictionary<string, long>();

            foreach (var pair in database)
            {
                if (pair.Key.StartsWith(place + "\\"))  
                {
                    foreach (var item in pair.Value)
                    {
                        if (item.Key.EndsWith("."+extencion))
                        {
                            wontedOnes.Add(item.Key, item.Value);
                        }
                    }
                }
            }
            if (wontedOnes.Count > 0)
            {
                foreach (var wonted in wontedOnes.OrderByDescending(X => X.Value).OrderBy(X => X.Key))
                {
                    Console.WriteLine($"{wonted.Key} - {wonted.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
