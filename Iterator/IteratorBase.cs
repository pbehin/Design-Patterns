using System;

namespace Iterator
{
    public abstract class IteratorBase<T> : IIterator<T>
    {
        public int CurrentIndex { get; private set; } = -1;

        public T Next()
        {
            if (!HasNext())
                throw new IndexOutOfRangeException();
            var key = GetNextIndex();
            return GetItems(key);
        }

        protected abstract T GetItems(int key);
        protected abstract int GetItemsCount();

        private int GetNextIndex()
        {
            return ++CurrentIndex;
        }

        public bool HasNext()
        {
            return GetItemsCount() != 0 && CurrentIndex + 1 < GetItemsCount();
        }

    }
}