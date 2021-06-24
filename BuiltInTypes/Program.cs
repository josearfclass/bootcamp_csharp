using System;
using System.Collections.Generic;

namespace BuiltInTypes
{
    class Program
    {
        public struct DetailedInteger
        {
            public int Number;
            private List<string> detail;

            public DetailedInteger(int Number)
            {
                this.Number = Number;
                detail = new List<string>();
            }

            public void AddDetail(string detail)
            {
                this.detail.Add(detail);
            }

            public override string ToString()
            {
                return $"{this.Number} [{string.Join(", ", detail)}]";
            }
        }
        public static void Main()
        {
            var n1 = new DetailedInteger(0);
            n1.AddDetail("A");
            Console.WriteLine(n1);

            var n2 = n1;
            n2.Number = 7;
            n2.AddDetail("B");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
