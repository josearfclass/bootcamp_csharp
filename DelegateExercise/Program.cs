using System;
using System.Collections.Generic;

namespace DelegateExercise
{
    public enum Operation
    {
        Sum,
        Subtract,
        Multiply
    }
    class Expression
    {
        private int first;
        private int second;
        public Dictionary<Operation, Func<int>> FuncExecute;

        public Expression(int first, int second)
        {
            this.first = first;
            this.second = second;

            FuncExecute = new Dictionary<Operation, Func<int>>(3);
            FuncExecute.Add(Operation.Sum, Sum);
            FuncExecute.Add(Operation.Subtract, Subtract);
            FuncExecute.Add(Operation.Multiply, Multiply);
        }

        private int Sum()
        {
            return first + second;
        }
        
        private int Subtract()
        {
            return first - second;
        }
        private int Multiply()
        {
            return first * second;
        }

        public int ApplyOperator(Operation operation)
        {
            if (FuncExecute.ContainsKey(operation))
            {
                return FuncExecute[operation]();
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Expression expression = new(20, 10);
            var result = expression.ApplyOperator(Operation.Sum);

            Console.WriteLine($"Result: {result}");
        }
    }
}
