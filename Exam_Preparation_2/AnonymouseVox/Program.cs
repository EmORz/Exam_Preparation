using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AnonymouseVox
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern1 =new Regex (@"([A-Za-z]+)(.+)\1");
            var codingMessage = Console.ReadLine();
            Regex pattern2 = new Regex( @"{(.+?)}");
            var partOfMessage = Console.ReadLine();
            //
            MatchCollection messages =  pattern2.Matches(partOfMessage);
            List<string> allMessages = new List<string>();
            //
            MatchCollection textLine = pattern1.Matches(codingMessage);
            //
            StringBuilder sb = new StringBuilder(codingMessage);

            foreach (Match word in messages)
            {
                allMessages.Add(word.Groups[1].Value);
            }
            var counter = 0;
            var corection = 0;

            foreach (Match word in textLine)
            {
                int position = word.Groups[2].Index;
                string text = word.Groups[2].Value;
                var replacement = allMessages[counter];
                sb.Replace(text, replacement, position+corection, text.Length);
                
                corection += replacement.Length - text.Length;
                counter++;
            }
            Console.WriteLine(sb.ToString());


        }
    }
}
