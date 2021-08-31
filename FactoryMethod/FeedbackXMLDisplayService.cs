namespace FactoryMethod
{
    public class FeedbackXMLDisplayService : DisplayService
    {
        protected override XMLParser getParser()
        {
            return new FeedbackXML();
        }
    }
}