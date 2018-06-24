using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"TO: ([A-Z]*); MESSAGE: (.*);";
            var key = Console.ReadLine();
            var input = Console.ReadLine();
            //
            List<Match> messages = new List<Match>();

            while (input !="END")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match m = Regex.Match(input, pattern);
                    messages.Add(m);
                }
                input = Console.ReadLine();
            }
            StringBuilder result = new StringBuilder();
            foreach (Match m in  messages.OrderBy(x => x.Groups[1].Value))
            {
                for (int i = 0; i < m.Value.Length; i++)
                {
                    result.Append((char)(m.Value[i]+int.Parse(key[i % key.Length].ToString())));
                }
                Console.WriteLine(result);
                result.Clear();
            }
        }
    }
}
