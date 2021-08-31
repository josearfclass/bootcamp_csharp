namespace FactoryMethod
{
    public class ErrorXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new ErrorXMLParser();
        }
    }
}