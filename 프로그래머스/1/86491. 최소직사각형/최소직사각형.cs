using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxShort = 0;
        int maxLong = 0;
        int tempShort = 0;
        int tempLong = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            // 짧은 변 찾기
            if(sizes[i, 0] < sizes[i, 1])
            {
                tempShort = sizes[i, 0];
                tempLong  = sizes[i, 1];
            }
            else
            {
                tempShort = sizes[i, 1];
                tempLong  = sizes[i, 0];
            }
            
            // 최댓값만 저장
            if(tempShort > maxShort) maxShort = tempShort;
            if(tempLong > maxLong) maxLong  = tempLong;
        }
        return maxShort * maxLong;
    }
}