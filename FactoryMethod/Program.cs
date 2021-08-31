using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayService error = XMLDisplayFactory.FactoryMethod("errorxml");
            error.Display();
            
            DisplayService order = XMLDisplayFactory.FactoryMethod("orderxml");
            order.Display();
            
            DisplayService response = XMLDisplayFactory.FactoryMethod("responsexml");
            response.Display();
            
            DisplayService feedback = XMLDisplayFactory.FactoryMethod("feedbackxml");
            feedback.Display();
        }
    }
}