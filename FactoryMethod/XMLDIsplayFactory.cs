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
                displayService = new OrderXMLDisplayService();
            }
            
            if (string.Equals(xmlType, "ResponseXML", StringComparison.OrdinalIgnoreCase))
            {
                displayService = new ResponseXMLDisplayService();
            }
            
            if (string.Equals(xmlType, "FeedBackXml", StringComparison.OrdinalIgnoreCase))
            {
                displayService = new FeedbackXMLDisplayService();
            }

            return displayService;
        }
    }
}