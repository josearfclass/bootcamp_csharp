using System.Collections.Generic;
using System.Linq;

namespace OutlookClient
{
    public interface IFolder
    {
        public string Name { get; set; }
        public List<IMessage> Messages { get; set; }
        void AddMessage(IMessage message);
        void RemoveMessage(int messageId);
        void RemoveMessage(IMessage message);
    }

    public class Folder : IFolder
    {
        public string Name { get; set; }
        public List<IMessage> Messages { get; set; }
        public Folder(string name)
        {
            this.Name = name;
            this.Messages = new List<IMessage>();
        }

        public void AddMessage(IMessage message)
        {
            this.Messages.Add(message);
        }
        
        public void RemoveMessage(int messageId)
        {
            IMessage messageToDelete = Messages.Where(message => message.Id == messageId).Single(); 
            this.Messages.Remove(messageToDelete);
        }
        
        public void RemoveMessage(IMessage message)
        {
            this.Messages.Remove(message);
        }
    }
}