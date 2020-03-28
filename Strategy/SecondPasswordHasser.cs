using System;
using System.Linq;

namespace Strategy
{
    internal class SecondPasswordHasser : IPasswordHasher
    {
        public byte[] Hash(string password)
        {
            return password.Reverse().Select(ch => Convert.ToByte(ch+4)).ToArray();
        }
    }
}