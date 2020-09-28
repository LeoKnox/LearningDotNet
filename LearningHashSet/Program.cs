using System;
using System.Collections.Generic;

namespace LearningHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<string>();

            myHash.Add("Hello");
            myHash.Add("Hello");

            Console.WriteLine(myHash.Count);

            string[] s = new string[] { "Hello" };

            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
