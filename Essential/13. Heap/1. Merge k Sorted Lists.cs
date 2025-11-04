namespace Essential.Heap
{
    class MergeKSortedListsClass
    {
        /// <summary>
        /// Method-1: Divide And Conquer (Best)
        /// TC: O(N log k)
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

        public ListNode mergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode h = new ListNode(0);
            ListNode ans = h;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    h.next = l1;
                    h = h.next;
                    l1 = l1.next;
                }
                else
                {
                    h.next = l2;
                    h = h.next;
                    l2 = l2.next;
                }
            }

            if (l1 == null)
            {
                h.next = l2;
            }
            if (l2 == null)
            {
                h.next = l1;
            }

            return ans.next;
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            int interval = 1;

            while (interval < lists.Length)
            {
                for (int i = 0; i + interval < lists.Length; i = i + interval * 2)
                {
                    lists[i] = mergeTwoLists(lists[i], lists[i + interval]);
                }
                interval *= 2;
            }

            return lists[0];
        }
    }
}
