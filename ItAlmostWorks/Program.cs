using System;
using System.Collections.Generic;
using System.Linq;

namespace ItAlmostWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatedData = Enumerable.Range(1, 5).Select(index => new PersonModel
            {
                Id = index,
                FirstName = "Hello",
                LastName = "World"
            }).ToArray();

            foreach (var person in generatedData)
            {
                person.LastName = person.Id switch
                {
                    < 3 and > 1 => "Ivanchenko",
                    4 => "Klimov",
                    _ => "Unknown"
                };
            }

            foreach (var person in generatedData)
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Id })");

        }
    }
}
