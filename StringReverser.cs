using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithArrays
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            Stack<char> charStack = new Stack<char>();
            foreach (var ch in input.ToCharArray())
            {
                charStack.Push(ch);
            }

            StringBuilder reverse = new StringBuilder(input.Length);

            while (charStack.Count > 0)
            {
                reverse.Append(charStack.Pop());
            }

            return reverse.ToString();

        }
    }
}
