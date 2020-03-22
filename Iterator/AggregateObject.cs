using System.Collections.Generic;

namespace Iterator
{
    public class AggregateObject<T>
    {
        public AggregateObject(params T[] items)
        {
            Items = new List<T>(items);
        }

        private List<T> Items { get; }

        public IIterator<T> GetArrayIterator()
        {
            return new ArrayIterator<T>(Items.ToArray());
        }

        public IIterator<T> GetDicIterator()
        {
            return new DicIterator<T>(Items);
        }
    }
}