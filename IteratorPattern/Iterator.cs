namespace IteratorPattern
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Next();
        void Remove();
    }
}