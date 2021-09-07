using System;

namespace CompositePattern2
{
    public class Hardware : IComponent
    {
        public int Price { get; set; }
        public String Name { get; set; }

        public Hardware(String name, int price)
        {
            this.Price = price;
            this.Name = name;
        }
        
        public void DisplayPrice()
        {
            Console.WriteLine(Name + " " + Price);
        }
    }
}