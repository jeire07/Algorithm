using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        int[] tempArray = new int[array.Length];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            Array.Copy(array, tempArray, array.Length);
            Array.Sort(tempArray, commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1);
            
            int index = commands[i, 0] + commands[i, 2] - 2;
            answer[i] = tempArray[index];
        }
        return answer;
    }
}