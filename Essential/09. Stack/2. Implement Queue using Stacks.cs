namespace Essential.Stack
{
    class ImplementQueueUsingStacksClass
    {
        /// <summary>
        /// Method-1: Two Stacks (Best)
        /// TC: Amortized O(1)
        /// SC: O(n)
        /// </summary>

        public class MyQueue
        {
            Stack<int> input = new Stack<int>();
            Stack<int> output = new Stack<int>();

            public MyQueue()
            {
            }

            // TC: O(1)
            // SC: O(n)

            public void Push(int x)
            {
                input.Push(x);
            }

            // TC: O(1)
            // SC: O(1)

            public int Pop()
            {
                int x = Peek();
                output.Pop();
                return x;
            }

            // TC: Amortized O(1)
            // SC: O(1)

            public int Peek()
            {
                if (output.Count == 0)
                {
                    while (input.Any())
                    {
                        output.Push(input.Pop());
                    }
                }

                return output.Peek();
            }

            // TC: O(1)
            // SC: O(1)

            public bool Empty()
            {
                return input.Count == 0 && output.Count == 0;
            }
        }
    }
}
