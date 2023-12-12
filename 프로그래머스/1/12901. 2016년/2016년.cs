public class Solution {
    public string solution(int a, int b) {
        string[] week = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        int[] days = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int dayCount = 0;

        for(int i = 1; i < a; i++)
        {
            dayCount += days[i-1];
        }
        dayCount += b - 1;

        int weekday = (dayCount + 5) % 7;
        return week[weekday];
    }
}