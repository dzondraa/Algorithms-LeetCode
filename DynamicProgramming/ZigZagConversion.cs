using System.Text;

namespace LeetCode;

public class ZigZagConversion
{
    public ZigZagConversion() { }

    public string Execute(string s, int numRows)
    {
        if (numRows == 1) return s;
        StringBuilder sb = new StringBuilder();
        int increment = (numRows - 1) * 2;
        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < s.Length;)
            {
                if (i == 0 || i == numRows - 1)
                {
                    sb.Append(s[j]);
                }
                else
                {
                    sb.Append(s[j]);
                    int temp_increment = increment - 2 * i;
                    if (j + temp_increment < s.Length)
                        sb.Append(s[(j + temp_increment)]);
                }
                j = j + increment;
            }
        }
        return sb.ToString();

    }
}