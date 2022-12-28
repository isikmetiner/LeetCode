using System;
using LeetCode.LeetCodeProblems;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 5, 5 };
            int[] arrayResult = RemoveDuplicatesFromSortedArray.RemoveDuplicates(array);
        }
    }
}