using System;
using System.Collections.Generic;

namespace learningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();
            pancakes.Push("blueberry");
            pancakes.Push("chocolate");
            pancakes.Push("bacon");
            foreach(var pancake in pancakes)
            {
                Console.WriteLine(pancake);
            }
            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Peek());
            Console.ReadLine();
        }
    }
}
