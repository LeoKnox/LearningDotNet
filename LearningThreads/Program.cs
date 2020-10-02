using System;
using System.Threading;

namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread mythread = new Thread(new ThreadStart(Work));
                mythread.Start();
            }

            Console.ReadLine();
        }

        static void Work()
        {
            Console.WriteLine("Starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("Doing work");
        }
    }
}
