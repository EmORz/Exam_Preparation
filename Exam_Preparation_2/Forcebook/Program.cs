using System;
using System.Collections.Generic;
using System.Linq;

namespace Forcebook
{
    class Program
    {
        class Foorcebook
        {
            public Foorcebook()
            {
            }

            public Foorcebook(string name, string side)
            {
                Name = name;
                Side = side;
            }

            public string Name { get; set; }
            public string Side { get; set; }

        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, List<Foorcebook>> data = new Dictionary<string, List<Foorcebook>>();
            List<Foorcebook> sides = new List<Foorcebook>();
            List<Foorcebook> names = new List<Foorcebook>();


            while (input != "Lumpawaroo")
            {
                string[] delimeter = input.Split('|', '-', '>');
                string[] dataForJadai = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


                if (input.ToString().Contains("|"))
                {
                    var side = delimeter[0];
                    var name = delimeter[1].Trim();
                    Foorcebook fb = new Foorcebook();
                    fb.Name = name;

                    if (data.ContainsKey(name) == false)
                    {
                        List<Foorcebook> current = new List<Foorcebook>();
                        current.Add(fb);
                        data.Add(side, current);
                    }
                }
                //if (input.ToString().Contains("->"))
                //{
                //    var name = delimeter[0].ToString().Trim();
                //    var side = delimeter[delimeter.Length-1].Trim();
                //    Foorcebook returnSide = new Foorcebook();
                //    returnSide.Name = name;
                //    returnSide.Side = side;
                //    if (data.ContainsKey(name) == false)
                //    {
                //        List<Foorcebook> current = new List<Foorcebook>();
                //        current.Add(returnSide);
                //        Console.WriteLine($"{name} joins the {side} side!");
                //        data.Add(side, current );
                //    }
                //    if (names.Contains(returnSide) == true)
                //    {
                //        Console.WriteLine($"{name} joins the {side} side!");
                //        //List<Foorcebook> current = new List<Foorcebook>();
                //        //current.Add(returnSide);
                //        //data[side] = current;
                //    }
                //}
                input = Console.ReadLine();
            }
            foreach (var item in data.OrderBy(x => x.Value.Count))
            {
                Console.WriteLine($"Side: {item.Key.Trim()}, Members: {item.Value.Count}");
                foreach (var i in item.Value.OrderByDescending(m => m))
                {
                    Console.WriteLine("! "+i.Name);
                }

            }
        }
    }
}
