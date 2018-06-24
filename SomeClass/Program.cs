using System;
using System.Collections;
using System.Collections.Generic;

namespace SomeClass
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());

            Person first = new Person();
            first.Name = name;

            List<Person> persons = new List<Person>();
            persons.Add(first);

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Name: {i} {first.Name[i % first.Name.Length]} => {first.Age++ % first.Name.Length}");
            }

            
        }
    }
}
