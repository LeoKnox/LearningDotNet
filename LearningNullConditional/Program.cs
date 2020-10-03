using System;

namespace LearningNullConditional
{
    class Program
    {
        class Person
        {
            public string Name { get; set;  }
        }
        static void Main(string[] args)
        {
            Person person = new Person() { }; // wht if this was null? would give errror
            Console.WriteLine(person?.Name ?? "This hero has no name!");
        }
    }
}
