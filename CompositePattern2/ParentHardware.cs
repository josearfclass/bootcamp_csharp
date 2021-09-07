using System;
using System.Collections.Generic;

namespace CompositePattern2
{
    public class ParentHardware : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();

        public ParentHardware(string name)
        {
            this.Name = name;
        }
        
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        
        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}