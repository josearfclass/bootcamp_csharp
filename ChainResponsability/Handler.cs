namespace ChainResponsability
{
    public interface Handler
    {
        void SetHandler(Handler handler);

        void Process(File file);

        string GetHandlerName();
    }
}