using System;
using System.Collections;

namespace InterfacesExercise
{
    class Program
    {
        class Person
        {
            public string Name;
        }

        class PersonComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return ( new CaseInsensitiveComparer() ).Compare( ( (Person)x ).Name, ( (Person)y ).Name );
            }
        }
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person { Name = "Simon" },
                new Person { Name = "jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" }
            };

            Console.WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                Console.WriteLine($" {person.Name}");
            }

            Console.WriteLine("Use Person's IComparable implementaion to sort");
            Array.Sort( people, new PersonComparer() );
            foreach (var person in people)
            {
                Console.WriteLine($" {person.Name}");
            }
        }
    }
}
