using System;
using System.Linq;

namespace Strategy
{
    public class DefaultPasswordHasher : IPasswordHasher
    {
        public byte[] Hash(string password)
        {
            return password.Reverse().Select(ch => Convert.ToByte(ch)).ToArray();
        }
    }
}