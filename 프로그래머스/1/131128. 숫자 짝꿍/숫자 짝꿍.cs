using System;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";

        // 중복되는 수 전부 추출
        for (int i = 0; i < X.Length; i++)
        {
            char digit = X[i];

            if (Y.IndexOf(digit) != -1)
            {
                answer += digit;

                Y = Y.Remove(Y.IndexOf(digit), 1);
            }
        }

        if (answer == "")
        {
            return "-1";
        }
        else
        {
            // 최고로 큰 수 생성
            char[] digitArray = answer.ToCharArray();
            Array.Sort(digitArray);
            Array.Reverse(digitArray);

            // 0으로만 구성된 문자열이면 0 1개가 되어야 하므로 정수로 바꿨다가 다시 바꾼다.
            int digits = int.Parse(answer);
            answer = digits.ToString();

            answer = new string(digitArray);
            return answer;
        }
    }
}