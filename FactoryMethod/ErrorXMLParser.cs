using System;

namespace FactoryMethod
{
    public class ErrorXMLParser : XMLParser
    {
        public string Parse()
        {
            return "XML Error";
        }
    }
}