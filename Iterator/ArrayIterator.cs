namespace Iterator
{
    public class ArrayIterator<T> : IteratorBase<T>
    {
        public T[] Items { get; }

        public ArrayIterator(T[] items)
        {
            Items = items;
        }

        protected override T GetItems(int key)
        {
            return Items[key];
        }

        protected override int GetItemsCount()
        {
            return Items.Length;
        }
    }
}