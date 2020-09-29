using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Downloading complete");
            });
        }
    }
}
