using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        List<int> answerList = new List<int>();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        for (char c = 'A'; c <= 'Z'; c++)
        {
            int minIndex = 101;
            foreach (string str in keymap)
            {
                int curIndex = str.IndexOf(c);
                if (curIndex != -1 && curIndex < minIndex)
                    minIndex = curIndex;
            }
            
            if (minIndex != 101)
                dict.Add(c, minIndex + 1);
        }
        
        for (int i = 0; i < targets.Length; i++)
        {
            int total = 0;
            for (int j = 0; j < targets[i].Length; j++)
            {
                if (dict.ContainsKey(targets[i][j]))
                    total += dict[targets[i][j]];
                else
                {
                    total = -1;
                    break;
                }
            }
            answerList.Add(total);
        }
        return answerList.ToArray();
    }
}