using System;
using System.Reflection;

namespace AsemblyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);
            try  
            {
                Assembly asm = Assembly.LoadFrom(@"/media/testuser/TODO NUEVO/JALA/C#/code/Bootcamp/AssemblyLibrary/obj/Release/net5.0/AssemblyLibrary.dll");
                string FullName = asm.FullName;
                Console.WriteLine("El nombre es"+FullName);
                
                Type[] types = asm.GetTypes();
                
                foreach (Type t in types)
                {
                    Console.WriteLine("Type: {0}", t.FullName);
                }
                
                Type tp = asm.GetType("AssemblyLibrary.Class1");    
                MethodInfo[] methods = tp.GetMethods();
                
                foreach (MethodInfo mi in methods)
                {
                    Console.WriteLine(mi.Name);
                }
                
                Console.WriteLine("///////////// testing method /////////////////");
                MethodInfo staticMethodInfo = tp.GetMethod("Sumar");
                int returnValue = Convert.ToInt32(staticMethodInfo.Invoke(null, new object[] { 2, 5 }));
                var obj = Activator.CreateInstance(tp, new object[] { });
                
                Console.WriteLine("///////////////////////////////////////////////");
            }
            catch  
            {  
                Console.WriteLine("Can't Load Assembly");  
            }
        }
        
        static void DisplayAssembly(Assembly a)  
        {  
            Console.WriteLine("*******Contents in Assembly*********");  
            Console.WriteLine("Information:{0}",a.FullName);  
            Type[] asm = a.GetTypes();  
            foreach (Type tp in asm)  
            {  
                Console.WriteLine("Type:{0}", tp);  
            }  
        } 
    }
}