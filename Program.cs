using System;
using System.Collections.Generic;

namespace LearningDootNet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> adventurers = new List<string>();
            adventurers.Add("Aelien");
            adventurers.Add("Eveehi");
            adventurers.Add("Xingu");

            Console.WriteLine(adventurers.Count);
            foreach (var adventurer in adventurers)
            {
                Console.WriteLine(adventurer);
            }
            Console.WriteLine($" second adventurer is {adventurers[1]}");
            Console.ReadLine();
        }
    }
}
