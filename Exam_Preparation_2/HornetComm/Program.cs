using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex privateMessage = new Regex(@"([0-9]+) <-> ([0-9A-Za-z]+)$");
            Regex broadcast = new Regex (@"^([^0-9]+) <-> ([0-9A-Za-z]+)$");

            List<string> listMessage = new List<string>();
            List<string> listBroadcast= new List<string>();

            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                Match message = privateMessage.Match(input);
                Match cast = broadcast.Match(input);
                //
                if (message.Success)
                {
                    string temp = message.Groups[1].Value;
                    string reversed = "";

                    for (int i = temp.Length - 1; i >= 0; i--)
                    {
                        reversed += temp[i];
                    }


                    listMessage.Add(reversed + " -> "+message.Groups[2].Value);
                    //Console.WriteLine(reversed);
                }
                if (cast.Success)
                {
                    string temp = cast.Groups[2].Value;
                    var newFrequence = "";
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (char.IsUpper(temp[i]))
                        {
                            newFrequence += temp[i].ToString().ToLower();
                        }
                        else
                        {
                            newFrequence += temp[i].ToString().ToUpper();
                        }
                        
                        
                    }
                    listBroadcast.Add(newFrequence+" -> "+cast.Groups[1].Value);

                }



                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(listBroadcast.Count > 0 ? string.Join("\n", listBroadcast) : "None");
            Console.WriteLine("Messages:");
            Console.WriteLine(listMessage.Count > 0 ? string.Join("\n", listMessage) : "None");
        }
    }
}
