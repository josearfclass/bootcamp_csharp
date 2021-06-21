using System;

namespace VariableDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte var1 = -100;
            sbyte var2 = -128;
            short var3 = 3540;
            ushort var4 = 64876;
            uint var5 = 2147483648;
            int var6 = -1141583228;
            long var7 = -123372036854770;
            int var8 = 2_000_000;
            int var9 = 0b_0001_1110_1000_0100_1000_0000;
            int var10 = 0x_001E_8480;
            decimal var11 = 3.141592653589793238M;
            double var12 = 1.60217657;
            decimal var13 = 7.8184261974584555216535342341M;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);
            Console.WriteLine(var7);
            Console.WriteLine(var8);
            Console.WriteLine(var9);
            Console.WriteLine(var10);
            Console.WriteLine(var11);
            Console.WriteLine(var12);
            Console.WriteLine(var13);
        }
    }
}
