﻿namespace Essential.Stack
{
    class ValidParenthesesClass
    {
        /// <summary>
        /// Method-1: Stack (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }

            return stack.Count == 0;
        }
    }
}
