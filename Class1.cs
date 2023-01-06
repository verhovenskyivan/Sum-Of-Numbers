using System;
public class Sum
{
    public int GetSum(int a, int b)
    {
        int max = Math.Max(a, b);
        int min = Math.Min(a, b);
        int result = 0;
        for (int i = min; i <= max; i++)
        {
            result += i;
        }
        return result;
    }
}