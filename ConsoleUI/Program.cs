using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"E:\Temp\Demos\FileSystem\TextFiles\Test.txt";
            
            var people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                var newPerson = new Person
                {
                    FirstName = entries[0],
                    LastName = entries[1],
                    Url = entries[2]
                };
                
                people.Add(newPerson);
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");
            }
        }
    }
}