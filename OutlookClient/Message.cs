using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace OutlookClient
{
    public interface IMessage
    {
        public int Id { get; set; }
        public IPAddress IpOrigin { get; set; }
        public MailAddress From { get; set; }
        public MailAddress To { get; set; }
        public string Subject { get; set; }
        public List<MailAddress> Cc { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
    public class Message : IMessage
    {
        public static int IdClass=0;
        public int Id { get; set; }
        public IPAddress IpOrigin { get; set; }
        public MailAddress From { get; set; }
        public MailAddress To { get; set; }
        public string Subject { get; set; }
        public List<MailAddress> Cc { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

        public Message(
                IPAddress ipOrigi,
                MailAddress From,
                MailAddress To,
                string Subject,
                List<MailAddress> Cc,
                string body,
                DateTime Date
            )
        {
            this.Id = IdClass;
            this.IpOrigin = ipOrigi;
            this.From = From;
            this.To = To;
            this.Subject = Subject;
            this.Cc = Cc;
            this.Body = body;
            this.Date = Date;

            IdClass++;
        }
    }
}