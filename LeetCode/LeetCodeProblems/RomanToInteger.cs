using System;
using System.Collections.Generic;

namespace LeetCode.LeetCodeProblems
{
    public static class RomanToInteger
    {
        public static int ConvertRomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Bir değer giriniz!");
            }

            char[] chars = s.ToCharArray();

            if (!(chars.Length >= 1 && chars.Length <= 15))
            {
                Console.WriteLine("Girilen metin 1 ile 15 karakter arasında olmalıdır!");
            }

            int result = 0;
            int firstValue, secondValue;

            Dictionary<char, int> dictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'I' || chars[i] == 'V' || chars[i] == 'X' || chars[i] == 'L' || chars[i] == 'C' || chars[i] == 'D' || chars[i] == 'M')
                {
                    firstValue = dictionary[chars[i]];

                    if (i != chars.Length - 1)
                    {
                        secondValue = dictionary[chars[i + 1]];

                        if (secondValue > firstValue)
                        {
                            firstValue = secondValue - firstValue;
                            i++;
                        }
                    }

                    result += firstValue;
                }
                else
                {
                    Console.WriteLine("Girilen metin sadece I, V, X, L, C, D, M karakterlerini içermelidir!");
                }
            }

            return result;
        }
    }
}