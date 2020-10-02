using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            int? s1 = 1; // "hello";
            int s2 = s1 ?? 2;

            Console.WriteLine(s2);
        }
    }
}
