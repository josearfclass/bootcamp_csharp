using System;
using System.Net.Mail;

namespace OutlookClient
{
    public class ClientEmail
    {
        public FoldersClient Folders;
        public RulesClient Rules;

        public ClientEmail()
        {
            this.Folders = new FoldersClient();
            this.Rules = new RulesClient();
        }
    }
}