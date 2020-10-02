using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "hello";
            var s2 = s1 ?? "default";

            Console.WriteLine($"s2");
        }
    }
}
