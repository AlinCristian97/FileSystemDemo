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

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}