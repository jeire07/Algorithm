public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            answer += numbers[i];
        }
        return answer / numbers.Length;
    }
}