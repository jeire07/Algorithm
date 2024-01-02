using System;

public class Solution {
    public int solution(string s) {
        int answer = 1;
        char refChar = 'A';
        int refCnt = 0;
        int notRefCnt = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(refChar == 'A')
                refChar = s[i];
            
            if(s[i] == refChar)
                refCnt++;
            else
                notRefCnt++;
            
            if(refCnt == notRefCnt && i != s.Length - 1)
            {
                refChar = 'A';
                refCnt = 0;
                notRefCnt = 0;
                answer++;
            }
        }
        return answer;
    }
}