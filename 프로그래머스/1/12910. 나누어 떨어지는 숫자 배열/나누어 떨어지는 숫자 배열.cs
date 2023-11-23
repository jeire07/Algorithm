using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] { };
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] % divisor) == 0)
            {
                list.Add(arr[i]);
            }
        }
        if(list.Count == 0)
        {
            answer = new int[] { -1 };
            return answer;
        }
        answer = new int[list.Count];

        for (int i = 0; i < list.Count; i++)
        {
            int index = i;
            for (int j = 1 + i; j < list.Count; j++)
            {
                if (list[index] > list[j])
                {
                    index = j;
                }
            }
            int temp = list[i];
            list[i] = list[index];
            list[index] = temp;
        }
        for(int i = 0; i < list.Count; i++)
        {
            answer[i] = list[i];
        }
        return answer;
    }
}