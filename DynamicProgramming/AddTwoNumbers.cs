namespace LeetCode;

public class AddTwoNumbers
{
    public ListNode Execute(ListNode l1, ListNode l2)
    {
        ListNode output = new ListNode(0, null);
        ListNode current = output;
        var res = Calculate(l1, l2, 1, 0, current);
        return output;
    }

    private static ListNode Calculate(ListNode node1, ListNode node2, long tens, int rest, ListNode node)
    {
        if (node1 is null && node2 is null) return node;

        long first = node1 == null ? 0 : node1.val;
        long second = node2 == null ? 0 : node2.val;

        long sum = first + second + rest;

        if (sum >= 10) rest = 1;
        else rest = 0;

        node.val = (int)(sum % 10);

        var next1 = node1 is not null ? node1.next : null;
        var next2 = node2 is not null ? node2.next : null;

        bool areBothNull = next1 is null && next2 is null;
        if (!areBothNull) node.next = new ListNode();

        return areBothNull ? Adapt(node, rest) : Calculate
            (
                next1,
                next2,
                tens * 10,
                rest,
                node.next
            );
    }

    private static ListNode Adapt(ListNode node, int rest)
    {
        if (rest == 1)
        {
            node.next = new ListNode(1, null);
            return node.next;
        }
        else return node;

    }

}
public class ListNode
{
    public long val;
    public ListNode next;
    public ListNode(long val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
