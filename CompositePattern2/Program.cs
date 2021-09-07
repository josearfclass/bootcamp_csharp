using System;

namespace CompositePattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent hardDisk = new Hardware("Hard Disk", 2000);
            IComponent ram = new Hardware("RAM", 3000);

            ParentHardware cabinet = new ParentHardware("Cabinet");
            
            cabinet.AddComponent(ram);
            cabinet.AddComponent(hardDisk);
            
            cabinet.DisplayPrice();
        }
    }
}