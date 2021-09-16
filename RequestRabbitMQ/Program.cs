using System;

namespace RequestRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esribre 'y' si quieres enviar un mensaje y presiona ENTER");
            string send = Console.ReadLine();
            while (send == "y")
            {
                Console.WriteLine("Esribre el mensaje y presiona ENTER");
                string message = Console.ReadLine();
                Headersmessages headersmessages = new Headersmessages();
                headersmessages.SendMessage(message);
                
                Console.WriteLine("Esribre 'y' si quieres enviar un mensaje y presiona ENTER");
                send = Console.ReadLine();
            }
        }
    }
}