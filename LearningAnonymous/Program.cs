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
        static void Download()
        {
            Network.Download((message) => Console.WriteLine($"Download {message}"));
        }
        class Network
        {
            static public Task Download(Action<String> callback)
            {
                return Task.Run(() => {
                    Thread.Sleep(3000);
                    callback("completed");
                });
            }
        }
    }
}
