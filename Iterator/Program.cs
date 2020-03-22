using System;
using System.Linq;
using System.Threading;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregate = new AggregateObject<int>(new[] { 1, 2, 4, 8 });
            var iterator1 = aggregate.GetArrayIterator();
            while (iterator1.HasNext())
            {
                var iterator2 = aggregate.GetDicIterator();
                for (; iterator2.HasNext();)
                {
                    Console.WriteLine($"\t{iterator2.Next()}");
                }
                Console.WriteLine(iterator1.Next());
            }
        }
    }
}
