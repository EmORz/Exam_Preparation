﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            //80 To4ki
            string input = Console.ReadLine();
            List<string> str = new List<string>();
            string temp = "";
            while (input != "Visual Studio crash")
            {
                string[] arr = input.Split();
                foreach (var item in arr)
                {
                    if (item != "32656" && item != "19759" && item != "32763" && item != "0")
                    {
                        temp += item+" ";
                    }

                }
                string[] stt = temp.Trim().Split();
                string tt = "";
                for (int i = 1; i < stt.Length; i++)
                {
                    tt += (Convert.ToChar(int.Parse(stt[i])));
                }
                str.Add(tt);
                temp = "";

                
                input = Console.ReadLine();
            }
            foreach (var item in str)
            {
                Console.WriteLine(item);

                
            }

        }
    }
}
