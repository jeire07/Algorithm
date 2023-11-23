using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int length;
        if (arr.Length == 1)
        {
            length = 1;
        }
        else
        {
            length = arr.Length - 1;
        }

        int[] answer = new int[length];

        List <int> list = new List<int>();
        if (arr.Length == 1)
        {
            answer[0] = -1;
            return answer;
        }
        else
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }
            list.Remove(list[min]);

            for (int i = 0; i < list.Count; i++)
            {
                answer[i] = list[i];
            }
            return answer;
        }
    }
}