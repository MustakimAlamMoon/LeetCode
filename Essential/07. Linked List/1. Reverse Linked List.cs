namespace Essential.LinkedList
{
    class ReverseLinkedListClass
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

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prevNode = null;

            while (head != null)
            {
                ListNode nextNode = head.next;
                head.next = prevNode;
                prevNode = head;
                head = nextNode;
            }

            return prevNode;
        }
    }
}
