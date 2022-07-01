namespace LeetCode;

public class JumpGame2
{
    public JumpGame2() { }

    public int GetMinJumps(int[] steps)
    {
        if (steps[0] == 0) return 0;
        if (steps[0] == 1 && steps.Length == 1) return 0;
        if (steps.Length == 0) return 0;
        if (steps[0] >= steps.Length - 1) return 1;
        else
        {
            int min = steps.Length - 1;
            checkPossibilities(0, steps, 0, ref min);
            return min;
        }
    }

    private void checkPossibilities(int currentIndex, int[] steps, int stepCounter, ref int min)
    {
        if (currentIndex >= steps.Length - 1)
        {
            if (stepCounter < min)
                min = stepCounter;
            return;
        }

        stepCounter++;


        for (int i = 1; i <= steps[currentIndex]; i++)
        {
            checkPossibilities(currentIndex + i, steps, stepCounter, ref min);
        }

    }
}