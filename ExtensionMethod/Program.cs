using System;
using System.Collections;
using System.Linq;

namespace ExtensionMethod
{
    public static class IntExtensions
    {
        public static bool Validates(this object field, Hashtable validations)
        {
            bool valid = true;
            if (validations.ContainsKey("presence"))
            {
                if ((bool) validations["presence"] && field != null)
                {
                    valid =  true;   
                }
            }

            if (validations.ContainsKey("absence"))
            {
                valid = field == null;
            }
            return valid;
        }
        public static bool Presence(this object i, bool validate)
        {
            return i != null;
        }
        public static bool IsGreaterAndLessThan(this int i, int value,int value2)
        {
            return i > value && i < value2;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            
            Console.WriteLine(value.Presence(true));
            
            int? value2 = null;
            Console.WriteLine(value2.Presence(true));
            
            Console.WriteLine(value.IsGreaterAndLessThan(100, 200));
            
            Hashtable validate = new Hashtable();
            
            validate.Add("presence", true);
            int value3 = 3;
            Console.WriteLine(value3.Validates(validate));
        }
    }
}