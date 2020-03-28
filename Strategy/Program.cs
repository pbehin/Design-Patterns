using System;
using System.Linq;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "this is a text ot be hashed.";
            
            IHasher hasher = new Hasher(new DefaultPasswordHasher());
            
            var defaultHash = hasher.PasswordHasher.Hash(password);

            hasher.SetPasswordHasher(new SecondPasswordHasser());

            var secondHash = hasher.PasswordHasher.Hash(password);

            if(defaultHash.SequenceEqual(secondHash))
                Console.WriteLine("two sequences are equal.");
            Console.WriteLine("two sequences have deference order.");
        }
    }
}
