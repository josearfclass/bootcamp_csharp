using System;
using System.Reflection;

namespace AnonymousExercise
{
    class Program
    {
        class Anonymous
        {
            public object getData()
            {
                return new { Name = "Pepe", EmailID = "pepe@gmail.com" };
            }
        }
        static void Main(string[] args)
        {
            Anonymous anonymous = new Anonymous();
            dynamic anonymousDynamicData = anonymous.getData();
            Console.WriteLine(string.Format("{0} {1}", anonymousDynamicData.Name, anonymousDynamicData.EmailID));

            object anonymousData = anonymous.getData();
            var obj = CastToClass( anonymousData, new { Name = "", EmailID = "" });            
            Console.WriteLine(string.Format("{0} {1}", obj.Name, obj.EmailID));
        }

        public static T CastToClass<T>(object obj, T type) 
        { 
            return (T)obj;
        }

    }
}
