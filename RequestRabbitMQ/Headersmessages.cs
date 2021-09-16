using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequestRabbitMQ
{
    public class Headersmessages
    {
        private const string UName = "guest";
        private const string PWD = "guest";
        private const string HName = "localhost";
        private ConnectionFactory connectionFactory;

        public Headersmessages()
        {
            this.connectionFactory = new ConnectionFactory()
            {
                UserName = UName,
                Password = PWD,
                HostName = HName
            };
        }

        public void SendMessage(string message)
        {
            var connection = this.connectionFactory.CreateConnection();
            var model = connection.CreateModel();
            var properties = model.CreateBasicProperties();

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("format", "pdf");

            properties.Persistent = false;
            properties.Headers = dictionary;

            byte[] messagebuffer = Encoding.Default.GetBytes(message);
            
            Console.WriteLine("BEGIN ###################");
            model.BasicPublish("headers.exchange", "", properties, messagebuffer);
            Console.WriteLine("Message Sent to rabbitmq " + message);
            Console.WriteLine("END ###################");
        }
    }
}