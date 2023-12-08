using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            answer[i] = -1;  // 밑에 탐색 반복문에서 검색 실패할 경우 이 값이 그대로 할당된다
            
            int count = 1;  // 바로 앞의 글자부터 시작해야 하므로 -1이다
            while(i - count >= 0)  // 인덱스는 0보다 커야 한다
            {
                if (s[i] == s[i - count])
                {
                    answer[i] = count;  // 같은 글자가 나온 경우 count 값이 이동한 글자 수이다.
                    break;
                }
                count++;  // 같지 않을 경우 한글자 더 앞으로 가서 재탐색한다.
            }
        }
        return answer;
    }
}