namespace FactoryMethod
{
    public class OrderXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new OrderXMLParser();
        }
    }
}