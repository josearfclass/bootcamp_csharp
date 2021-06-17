using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Fibonacci(6);
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
        static string Fibonacci(int n)
        {
            string result = "01";
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                result = result + sum;
                n1 = n2;
                n2 = sum;
            }
            return result;
        }
    }
}
//0 1 1 2 3 5
