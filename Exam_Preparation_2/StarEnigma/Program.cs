using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Regex starPattern = new Regex(@"([sS]|[tT]|[aA]|[rR])");
            Regex regexArmada = new Regex(@"\@([A-Za-z]+)|:([0-9]+)!([A-Za-z])!->([0-9]+)");
            
            var str = "";
           
            var ataker = 0;
            var destroyer = 0;
            List<string> line = new List<string>();
            for (int i = 0; i < num; i++)
            {
                var codingMessage = Console.ReadLine();
                StringBuilder sb = new StringBuilder(codingMessage);
                MatchCollection matchLetters = starPattern.Matches(codingMessage);
                var count = 0;
                foreach (Match item in matchLetters)
                {
                    count++;
                }
                string temp = sb.ToString();

                for (int substrac = 0; substrac < temp.Length; substrac++)
                {
                    int everyChar = temp[substrac] - count;
                    char transformToChar = Convert.ToChar(everyChar);
                    str += transformToChar;
                }
                line.Add(str);

                str = "";
            }
            List<string> ataka = new List<string>();
            List<string> destroeyrs = new List<string>();


            for (int i = 0; i < line.Count; i++)
            {                
                MatchCollection matches = regexArmada.Matches(line[i]);
                Match m = regexArmada.Match(line[i]);
                string tre = m.Groups[1].Value;
                foreach (Match item in matches)
                {
                    if (item.Groups[3].Value == "A")
                    {
                        ataker++;
                        ataka.Add(tre);
                    }
                    if (item.Groups[3].Value == "D")
                    {
                        destroyer++;
                        destroeyrs.Add(tre);
                    }
                }
            }
            var atakMessage = "Attacked planets: "+ataker;
            var destroyMessage = "Destroyed planets: " + destroyer;

            Console.WriteLine(atakMessage);
            foreach (var lop in ataka.OrderBy(x => x))
            {
                Console.WriteLine("-> "+lop);
            }

            Console.WriteLine(destroyMessage);
            foreach (var destroi in destroeyrs.OrderBy(x => x))
            {
                Console.WriteLine("-> " +destroi);
            }
        }
    }
}
