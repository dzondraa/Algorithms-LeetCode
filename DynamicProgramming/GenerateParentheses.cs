namespace LeetCode;
public class GenerateParentheses
{
    private readonly int _inputN;
    public GenerateParentheses(int n)
    {
        _inputN = n;
    }

    public IEnumerable<string> Execute()
    {

        var output = new List<string>();
        solve(0, _inputN * 2, "", output);
        return output;
    }

    private void solve(int open, int num, string str, List<string> output)
    {
        if (num == 0)
        {
            output.Add(str);
            return;
        }

        if (num > open)
            solve(open + 1, num - 1, str + "(", output);

        if (open > 0)
        {
            solve(open - 1, num - 1, str + ")", output);
        }
    }
}