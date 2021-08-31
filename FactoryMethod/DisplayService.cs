using System;

namespace FactoryMethod
{
    public abstract class DisplayService
    {
        public void Display()
        {
            XMLParser XmlParser = getParser();
            Console.WriteLine(XmlParser.Parse());
        }

        protected abstract XMLParser getParser();
    }
}