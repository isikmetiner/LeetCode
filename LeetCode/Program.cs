using LeetCode.LeetCodeProblems;
using System;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] stringArr = new string[5] { "Ahmet", "Ahsen", "Ahegül", "Ahu", "Ahdül" };
            string result = LongestCommonPrefix.GetLongestCommonPrefix(stringArr);
        }
    }
}