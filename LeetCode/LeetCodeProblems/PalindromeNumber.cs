using System;

namespace LeetCode.LeetCodeProblems
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (x < 10)
                return true;

            int digits = (int)Math.Floor(Math.Log10(x));

            for (int i = 0; i < (digits / 2) + 1; i++)
            {
                int a = (x / (int)Math.Pow(10, i)) % 10;
                int b = (x / (int)Math.Pow(10, digits - i)) % 10;

                if (a != b)
                    return false;
            }

            return true;
        }
    }
}