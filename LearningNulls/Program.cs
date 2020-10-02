using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = null; // "hello";
            var s2 = s1 ?? "default";

            Console.WriteLine(s2);
        }
    }
}
