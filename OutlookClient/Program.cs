using System;
using System.Net;
using System.Net.Mail;

namespace OutlookClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientEmail client = new ClientEmail();

            IMessage message = new Message(
                    IPAddress.Parse("192.168.1.1"),
                    new MailAddress("from@gmail.com"),
                    new MailAddress("to@gmail.com"),
                    "Subject",
                    null,
                    "body of the message",
                    new DateTime()
                );

            IMessage message2 = new Message(
                    IPAddress.Parse("192.168.1.1"),
                    new MailAddress("from@gmail.com"),
                    new MailAddress("to@gmail.com"),
                    "Subject",
                    null,
                    "body of the message",
                    new DateTime()
                );

            Console.WriteLine(message.Id);
            Console.WriteLine(message2.Id);

            Console.WriteLine("Directories for the email client");
            foreach (var folder in client.Folders.Folders)
            {
                Console.WriteLine(folder.Name);
                
            }
            Console.WriteLine("/////////////////////////////////");
            
            
        }
    }
}