using System;

namespace FactoryMethod
{
    public class XMLDisplayFactory
    {
        public static DisplayService FactoryMethod(string xmlType)
        {
            DisplayService displayService = null;
            if (string.Equals(xmlType, "ErrorXML", StringComparison.OrdinalIgnoreCase))
            {
                displayService = new ErrorXMLDisplayService();
            }

            if (string.Equals(xmlType, "OrderXML", StringComparison.OrdinalIgnoreCase))
            {
                return new OrderXMLDisplayService();
            }
            
            if (string.Equals(xmlType, "ResponseXML", StringComparison.OrdinalIgnoreCase))
            {
                return new ResponseXMLDisplayService();
            }
            
            if (string.Equals(xmlType, "FeedBackXml", StringComparison.OrdinalIgnoreCase))
            {
                return new FeedbackXMLDisplayService();
            }

            return displayService;
        }
    }
}