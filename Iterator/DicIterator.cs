using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    internal class DicIterator<T> : IteratorBase<T>
    {
        public Dictionary<int, T> Items { get; }

        public DicIterator(List<T> items)
        {
            Items = items.Select((index, itm) => new { Index = index, Item = itm })
                .ToDictionary(arg => arg.Item, arg => arg.Index);
        }

        protected override T GetItems(int key)
        {
            return Items[key];
        }

        protected override int GetItemsCount()
        {
            return Items.Count;
        }

        
    }
}