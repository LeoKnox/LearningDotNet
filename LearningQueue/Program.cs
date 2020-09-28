using System;
using System.Collections.Generic;

namespace LearningQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQ = new Queue<int>();
            myQ.Enqueue(1);
            myQ.Enqueue(2);
            myQ.Enqueue(3);
            foreach (var q in myQ)
            {
                Console.WriteLine(q);
            }
            myQ.Dequeue();
            foreach (var q in myQ)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }
    }
}
