using System;

namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // tuple can be used to return items from function since traditionally only one item can be returned.
            // Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "atk", true);
            var myTuple = Tuple.Create(1, "atk", true); // alternate way to create tuple cleaner and easier to implement
            Console.WriteLine(myTuple.Item2);
            Console.ReadLine();
        }
    }
}
