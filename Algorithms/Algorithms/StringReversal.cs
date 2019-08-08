using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StringReversal
    {
        public string Reverse(string source)
        {
            var reversedString = new StringBuilder();
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentNullException();
            for (int i = source.Length; i > 0; i--)
                reversedString.Append(source[i - 1]);
            return reversedString.ToString();
        }
    }
}
