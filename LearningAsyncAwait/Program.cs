using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }
        static async void Download()
        {
            Task.Run(async() =>
            {
                await Network.Download();
                Console.WriteLine("Download complete");
            });
        }
        class Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
    }
}
