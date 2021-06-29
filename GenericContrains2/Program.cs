﻿using System;

namespace GenericContrains2
{
    class Program
    {
        public class UniqueInstance<T> where T : new()
        {
            public static T Unique = new();
        }

        class Person : UniqueInstance<Person>
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            Person.Unique.Name = "pepe";
            Console.WriteLine(Person.Unique.Name);
        }
    }
}
