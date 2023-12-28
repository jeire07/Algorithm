using System;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] baseBabbling = { "aya", "ye", "woo", "ma" };

        for(int i = 0; i < babbling.Length; i++)
        {
            if (baseBabbling.Contains(babbling[i]))
            {
                answer += 1;
            }
            else
            {
                string base1 = "";
                string base2 = "";

                for(int j = 0; j < babbling[i].Length; j++)
                {
                    base1 += babbling[i][j];

                    // 같은 단어가 2번 연속 나왔다면 base1 == base2가 되므로 걸러진다.
                    if(base1 != base2 & baseBabbling.Contains(base1))
                    {
                        base2 = base1;
                        base1 = "";  // 발음할 수 있는 단어이면 base1을 비운다.
                    }
                }

                // 발음할 수 없는 경우에는 base1이 비어있을 수 없다.
                if(base1 == "")
                {
                    answer += 1;
                }
            }
        }
        return answer;
    }
}