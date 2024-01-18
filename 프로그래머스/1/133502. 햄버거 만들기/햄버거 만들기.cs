using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient)
    {
        int answer = 0;

        List<int> Layer = new List<int>();
        List<int> burger = new List<int>{ 1, 2, 3, 1 };

        for(int i = 0; i < ingredient.Length; i++)
        {
            Layer.Add(ingredient[i]);

            if(Layer.Count >= 4)
            {
                if (Layer.GetRange(Layer.Count - 4, 4).SequenceEqual(burger))
                {
                    Layer.RemoveRange(Layer.Count - 4, 4);
                    answer++;
                }
            }
        }

        return answer;
    }
}