public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] a = n.ToString().ToCharArray();
        System.Array.Sort(a);
        System.Array.Reverse(a);
        answer = System.Convert.ToInt64(new string(a));
        return answer;
    }
}