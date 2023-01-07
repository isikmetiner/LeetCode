using System;

namespace LeetCode.LeetCodeProblems
{
    public static class RemoveElement
    {
        public static int RemoveElementMethod(int[] nums, int val)
        {
            Constraints(nums, val);

            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            for (int i = j; i < nums.Length; i++)
            {
                nums[i] = '_';
            }

            return j;
        }

        private static void Constraints(int[] nums, int val)
        {
            if (nums.Length > 100)
            {
                Console.WriteLine("Verilen sayi dizisi uzunlugu 100 den fazla olamaz");
            }

            if (val > 100)
            {
                Console.WriteLine("Verilen sayi dizisinden cikartilmak istenen sayi 100 den buyuk olamaz");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 50)
                {
                    Console.WriteLine("Verilen sayi dizisinde bulunan her hangi bir sayi 50 den buyuk olamaz");
                    break;
                }
            }
        }
    }
}