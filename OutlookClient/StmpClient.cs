using System;
using GemBox.Email;
using GemBox.Email.Smtp;

namespace OutlookClient
{
    public class StmpClient
    {
        private SmtpClient Stmtp;
        public MailAddress from; 

        public StmpClient(MailAddress from)
        {
            Stmtp = new SmtpClient("smtp.gmail.com");
        }
        
        public void connectSmtpSever()
        {
            // If using Professional version, put your serial key below.
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            
            // By default the connect timeout is 5 sec.
            Stmtp.ConnectTimeout = TimeSpan.FromSeconds(4);

            // Connect to SMTP server.
            Stmtp.Connect();
            Console.WriteLine("Connected.");

            // Authenticate using the credentials; username and password.
            Stmtp.Authenticate("<USERNAME>", "<PASSWORD>");
            
            Console.WriteLine("Authenticated.");
            Console.WriteLine("Disconnected.");
        }
        
        public void SendMessage()
        {}
        
        public void ReceiveMessage()
        {}
    }
}