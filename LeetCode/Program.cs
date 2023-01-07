using System;
using LeetCode.LeetCodeProblems;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int result = RemoveElement.RemoveElementMethod(array, 2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}