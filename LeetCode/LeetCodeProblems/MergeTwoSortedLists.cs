namespace LeetCode.LeetCodeProblems
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode firstList, ListNode secondList)
        {
            if (firstList == null)
                return secondList;
            if (secondList == null)
                return firstList;

            if (secondList.val > firstList.val)
            {
                firstList.next = MergeTwoLists(firstList.next, secondList);
                return firstList;
            }

            secondList.next = MergeTwoLists(firstList, secondList.next);
            return secondList;
        }
    }

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
}