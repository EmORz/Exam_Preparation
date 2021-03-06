﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> account = Console.ReadLine().Split().ToList();
            string commands = Console.ReadLine();

            while (commands !="Play!")
            {
                string[] gamesAndCommands = commands.Split(new char[] { ' ', '-'}, StringSplitOptions.RemoveEmptyEntries);
                if (gamesAndCommands[0] == "Install" || gamesAndCommands[0] == "Update" 
                    || gamesAndCommands[0] == "Uninstall"|| gamesAndCommands[0] == "Expansion")
                {
                    if (gamesAndCommands[0] == "Install")
                    {
                        if (!account.Contains(gamesAndCommands[1]))
                        {
                            account.Add(gamesAndCommands[1]);
                        }
                    }
                    if (gamesAndCommands[0] == "Uninstall")
                    {
                        if (account.Contains(gamesAndCommands[1]))
                        {
                            account.Remove(gamesAndCommands[1]);
                        }
                    }
                    if (gamesAndCommands[0] == "Update")
                    {
                        if (account.Contains(gamesAndCommands[1]))
                        {
                            account.Remove(gamesAndCommands[1]);
                            account.Insert(account.Count, gamesAndCommands[1]);
                        }
                    }
                    if (gamesAndCommands[0] == "Expansion")
                    {
                        if (account.Contains(gamesAndCommands[1]))
                        {
                            string expansion = gamesAndCommands[1] + ":" + gamesAndCommands[2];
                            // Console.WriteLine(expansion);
                            var indeces = account.IndexOf(gamesAndCommands[1]);
                            account.Insert(indeces+1, expansion);
                            //Console.WriteLine(indeces);
                        }
                    }
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", account));

        }
    }
}
