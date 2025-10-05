namespace Essential.Queue
{
    class ImplementStackUsingQueuesClass
    {
        /// <summary>
        /// Method-1: One Queue (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public class MyStack
        {
            Queue<int> que;

            public MyStack()
            {
                que = new Queue<int>();
            }

            // TC: O(n)
            // SC: O(1)
            public void Push(int x)
            {
                que.Enqueue(x);

                for (int i = 0; i < que.Count - 1; i++)
                {
                    que.Enqueue(que.Dequeue());
                }
            }

            // TC: O(1)
            // SC: O(1)
            public int Pop()
            {
                return que.Dequeue();
            }

            // TC: O(1)
            // SC: O(1)
            public int Top()
            {
                return que.Peek();
            }

            // TC: O(1)
            // SC: O(1)
            public bool Empty()
            {
                return !que.Any();
            }
        }
    }
}
