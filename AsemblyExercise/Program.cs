using System;
using System.Reflection;

namespace AsemblyExercise
{
    class Program
    {
        public Assembly asembly;
        public Type library;
        
        public Program()
        {
            try  
            {
                asembly = Assembly.LoadFrom(@"/media/testuser/TODO NUEVO/JALA/C#/code/Bootcamp/AssemblyLibrary/obj/Release/net5.0/AssemblyLibrary.dll");
                library = asembly.GetType("AssemblyLibrary.Class1");
            }
            catch  
            {  
                Console.WriteLine("Can't Load Assembly");  
            }
        }

        public int sumar(int num1, int num2)
        {
            MethodInfo staticMethodInfo = library.GetMethod("Sumar");
            return Convert.ToInt32(staticMethodInfo.Invoke(null, new object[] { num1, num2 }));
        }
        
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("//////////// Ejemplo como libreria");
            Console.WriteLine(program.sumar(3, 5));
            Console.WriteLine("//////////////////////");
        }
    }
}