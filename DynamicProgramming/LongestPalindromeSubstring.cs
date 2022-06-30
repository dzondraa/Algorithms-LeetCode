using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestPalindromeSubstring
    {
        public string Execute(string s)
        {
            int start = 0;
            int end = 0;
            int[,] table = new int[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                table[i, i] = 1;
            }
            for(int i = 1; i < s.Length; i++)
            {
                int value = s[i] == s[i - 1] ? 1 : 0;
                table[i - 1, i] = value;
                if(value == 1) { start = i - 1; end = i; }
            }

            int elementsToSkip = 2;
            while (elementsToSkip < s.Length)
            {
                for(int i = 0; i < s.Length - elementsToSkip; i++)
                {
                    int value = (s[i] == s[i + elementsToSkip] && table[i + 1, i + elementsToSkip - 1] == 1) ? 1 : 0;
                    table[i, i + elementsToSkip] = value;
                    if (value == 1) { start = i; end = i + elementsToSkip; }

                }
                elementsToSkip++;
            }

            return s.Substring(start, end - start + 1);
           
        }
    }
}