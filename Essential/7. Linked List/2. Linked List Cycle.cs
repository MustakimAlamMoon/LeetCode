namespace Essential.LinkedList
{
    class LinkedListCycleClass
    {
        /// <summary>
        /// Method-1: Iterative (Best)
        /// TC: O(n)
        /// SC: O(1)
        /// </summary>


        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (fast == slow) return true;
            }

            return false;
        }
    }
}