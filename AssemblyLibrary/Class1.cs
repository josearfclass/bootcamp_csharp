using System;

namespace AssemblyLibrary
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The main method calling");
        }

        public static void Sumar(int num1,int num2)
        {
            Console.WriteLine($"Sumar numeros {num1} + {num2} es {num1+num2}");
            Console.WriteLine("Funcionando correctamente");
        }

        public void Metodo1()
        {
            Console.WriteLine("desde el metodo en Class 1");
        }
    }
}