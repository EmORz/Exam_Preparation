using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePattern = @"^Type: (Normal|Warning|Danger)$";
            string sourcePattern = @"^Source: ([A-Za-z0-9]+)$";
            string forecastPattern = @"^Forecast: ([^.!,?]+)$";
            string source = "";
            string type = "";
            string forecast = "";
            bool sourceReady = false;
            bool typeReady = false;
            bool forecastReady = false;
            //
            string command = Console.ReadLine();
            List<string> result = new List<string>();
            //

            while (command != "Davai Emo")
            {
                if (typeReady == false && Regex.IsMatch(command, typePattern))
                {
                    Match t = Regex.Match(command, typePattern);
                    type = t.Groups[1].Value;
                    typeReady = true;
                }
                if (typeReady == true && sourceReady == false && Regex.IsMatch(command, sourcePattern))
                {
                    Match s = Regex.Match(command, sourcePattern);
                    source = s.Groups[1].Value;
                    sourceReady = true;
                }
                if (typeReady == true && sourceReady == true && forecastReady == false && Regex.IsMatch(command, forecastPattern))
                {
                    Match f = Regex.Match(command, forecastPattern);
                    forecast = f.Groups[1].Value;
                    forecastReady = true;
                }
                if (typeReady == true && sourceReady == true && forecastReady == true )
                {
                    string str = $"({type}) {forecast} ~ {source}";
                    result.Add(str);
                    typeReady = false;
                    sourceReady = false;
                    forecastReady = false;
                }
                command = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
