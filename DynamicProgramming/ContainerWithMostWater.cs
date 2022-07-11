namespace LeetCode;

/// <summary>
/// Leetcode problem on <see href="https://leetcode.com/problems/container-with-most-water/">this link</see>
/// </summary>
public class ContainerWithMostWater
{
    public int Execute(int[] height)
    {
        int l = 0, r = height.Count() - 1;
        int capacity = 0;
        while (l < r)
        {
            capacity = Math.Max(
                capacity,
                calculateCapacity(l, r, height[l], height[r])
            );

            if (height[l] < height[r])
                l++;
            else
                r--;
        }
        return capacity;
    }

    private int calculateCapacity(int x1, int x2, int y1, int y2)
    {
        return (x2 - x1) * (int)Math.Min(y1, y2);
    }
}