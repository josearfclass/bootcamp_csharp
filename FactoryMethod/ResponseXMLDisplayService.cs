namespace FactoryMethod
{
    public class ResponseXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new ResponseXMLParser();
        }
    }
}