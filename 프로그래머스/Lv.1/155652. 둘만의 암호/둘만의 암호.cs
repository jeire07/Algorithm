using System;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        StringBuilder sb = new StringBuilder();
        char[] chars = new char[26 - skip.Length];

        for (int i = 0, j = 0; j <= 'z' - 'a'; j++)
        {
            char c = (char)((int)'a' + j);
            if (!skip.Contains(c))
            {
                chars[i] = c;
                i++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            int newIndex = Array.IndexOf(chars, s[i]) + index;
            int newAsciiIndex = newIndex >= chars.Length ? newIndex % chars.Length : newIndex;
            char newAscii = chars[newAsciiIndex];

            sb.Append(newAscii);
        }
        return sb.ToString();
    }
}