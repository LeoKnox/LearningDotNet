using System;
using System.Collections;

namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("new string");
            int i = 123;
            object o = i;
            i = 15; // does not change o
            o = 10;
            i = (int)o; // int required to cast o into i
            Console.WriteLine(o);
            Console.WriteLine((string)list[0]);
            Console.ReadLine();
        }
    }
}
