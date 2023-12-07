public class Solution {
    public string[] solution(string[] strings, int n) {
        // 정렬 기준 설정하는 비교자(Comparer)를 사용
        System.Array.Sort(strings, (x, y) =>
        {
            // n번째 인덱스의 문자를 기준으로 비교
            int compareResult = x[n].CompareTo(y[n]);

            // n번째 인덱스의 문자가 같으면 전체 문자열을 기준으로 사전순 정렬
            if (compareResult == 0)
            {
                return x.CompareTo(y);
            }

            return compareResult;
        });

        return strings;
    }
}