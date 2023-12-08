using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> sums = new List<int>();

        // 모든 경우의 수 합 계산 후 추가
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];

                // 중복 검사 후 리스트에 추가
                if (!sums.Contains(sum))
                {
                    sums.Add(sum);
                }
            }
        }

        // 리스트 정렬
        sums.Sort();

        int[] answer = sums.ToArray();
        return answer;
    }
}