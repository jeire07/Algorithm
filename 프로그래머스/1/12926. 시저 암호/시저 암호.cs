public class Solution {
    public string solution(string s, int n) {
        int bound = 26 - n;
        char[] cArr = s.ToCharArray();

        for (int i = 0; i<cArr.Length; i++)
        {
            if (cArr[i] > 0x20)
                cArr[i] = (cArr[i] & 0x1F) <= bound ? (char)(cArr[i] + n) : (char)(cArr[i] - bound);
        }

        return new string(cArr);
    }
}