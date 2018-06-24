using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace HornerComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = @"(^[\d]+) <-> ([A-Za-z0-9]+)$";
            string broadcast = @"(^[\D]+) <-> ([A-Za-z0-9]+$)";

            Regex messageRegex = new Regex(message);
            Regex broadcastRegex = new Regex(broadcast);

            List<string> messageData = new List<string>();
            List<string> broadcastData = new List<string>();

            string input = "";

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] { " <-> " },
                    StringSplitOptions.RemoveEmptyEntries);
                if (messageRegex.IsMatch(input))
                {
                    messageData.Add($"{string.Join("", inputArgs[0].ToCharArray().Reverse())} -> {inputArgs[1]}");
                }
                if (broadcastRegex.IsMatch(input))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char ch in inputArgs[1].ToCharArray())
                    {
                        if (Char.IsLower(ch))
                        {
                            sb.Append(Char.ToUpper(ch));
                            continue;
                        }
                        if (Char.IsUpper(ch))
                        {
                            sb.Append(Char.ToLower(ch));
                            continue;
                        }
                        sb.Append(ch);
                    }
                    broadcastData.Add($"{sb} -> {inputArgs[0]}");
                }
            }
            Console.WriteLine("Broadcasts:");
            Print(broadcastData);
            Console.WriteLine("Messages:");
            Print(messageData);
            
        }

        public static void Print(List<string> collection)
        {
            if (collection.Count != 0)
            {
                foreach (var current in collection)
                {
                    Console.WriteLine($"{current}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
