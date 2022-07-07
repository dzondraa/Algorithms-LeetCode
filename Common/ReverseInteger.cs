namespace LeetCode;

/// <summary>
/// Leetcode problem on <see href="https://leetcode.com/problems/reverse-integer/">this link</see>
/// </summary>
public class ReverseInteger
{
    public int Execute(int x)
    {
        bool isNegative = false;

        if (x < 0)
        {
            isNegative = true;
            x = x * -1;
        }

        string y = x.ToString();
        char[] arr = y.ToCharArray();
        Array.Reverse(arr);

        var newArr = new string(arr);
        int res = 0;

        if (Int32.TryParse(newArr, out res))
        {
            res *= isNegative ? -1 : 1;
        }
        return res;
    }
}