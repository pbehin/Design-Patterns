namespace Iterator
{
    public interface IIterator<out T>
    {
        T Next();
        bool HasNext();
    }
}