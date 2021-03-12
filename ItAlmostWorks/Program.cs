using System;
using System.Collections.Generic;
using System.Linq;

namespace ItAlmostWorks
{
    class Program
    {
        //static void main(string[] args)
        //{
        //    var generateddata = enumerable.range(1, 5).select(index => new personmodel
        //    {
        //        id = index,
        //        firstname = "hello",
        //        lastname = "world"
        //    }).toarray();

        //    foreach (var person in generateddata)
        //    {
        //        person.lastname = person.id switch
        //        {
        //            < 3 and > 1 => "ivanchenko",
        //            4 => "klimov",
        //            _ => "unknown"
        //        };
        //    }

        //    foreach (var person in generateddata)
        //        console.writeline($"{ person.firstname } { person.lastname } ({ person.id })");

        //}

        static void Main(string[] args)
        {
            Record1 r1a = new("Ilya", "Klimov");
            Record1 r1b = new("Ilya", "Klimov");
            Record1 r1c = new("Vasya", "Pupkin");

            Class1 c1a = new("Ilya", "Klimov");
            Class1 c1b = new("Ilya", "Klimov");
            Class1 c1c = new("Vasya", "Pupkin");

            Console.WriteLine("Record Type: ");
            Console.WriteLine($"To String: { r1a }");
            Console.WriteLine($"Are the two objects equal: { Equals(r1a, r1b) }");
            Console.WriteLine($"Are the two objects reference equals: { ReferenceEquals(r1a, r1b) }");

            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String: { c1a }");
            Console.WriteLine($"Are the two objects equal: { Equals(c1a, c1b) }");
            Console.WriteLine($"Are the two objects reference equals: { ReferenceEquals(c1a, c1b) }");
        }

        // a Record is just a fancy class. A class with extra stuff
        // It is immutable - the values cannot be changed
        // It is like a readonly class
        public record Record1(string FirstName, string LastName);

        public record Record2(string FirstName, string LastName)
        {
            internal string FirstName { get; init; } = FirstName;
        }

        public class Class1
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }

            public Class1(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }
    }
}
