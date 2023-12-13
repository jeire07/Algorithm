using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int index1 = 0;
        int index2 = 0;

        for(int i = 0; i < goal.Length; i++)
        {
            if(cards1[index1] == goal[i])
            {
                if(index1 < cards1.Length - 1)
                {
                    index1++;
                }
            }
            else if(cards2[index2] == goal[i])
            {
                if (index2 < cards2.Length - 1)
                {
                    index2++;
                }
            }
            else
            {
                return "No";
            }
        }
        return "Yes";
    }
}