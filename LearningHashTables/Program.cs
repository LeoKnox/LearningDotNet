using System;
using System.Collections;

namespace LearningHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("title", "Website");

            var s = (string)table["title"];
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
