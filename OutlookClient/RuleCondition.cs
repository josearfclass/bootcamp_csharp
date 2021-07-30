namespace OutlookClient
{
    public interface IRuleCondition
    {
        bool ValidCondition(IMessage message);
    }

    public class FromCondition : IRuleCondition
    {
        public string FromEmail { get; set; }

        public FromCondition(string fromEmail)
        {
            this.FromEmail = fromEmail;
        }
        public bool ValidCondition(IMessage message)
        {
            if (message.From.ToString() == this.FromEmail)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}