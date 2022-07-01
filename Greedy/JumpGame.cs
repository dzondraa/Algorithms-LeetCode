namespace LeetCode;

public class JumpGame2Greedy {
    public int Execute(int[] nums) {
        int res = 0;
        int l = 0, r = 0;

        while(r < nums.Length - 1) {
            int farest = 0;
            for(int i = l; i < r + 1; i++) {
                farest = Math.Max(farest, i + nums[i]);
            }

            l = r + 1;
            r = farest;
            res += 1;
        }

        return res;
    }
}