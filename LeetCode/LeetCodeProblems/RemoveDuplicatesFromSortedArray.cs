namespace LeetCode.LeetCodeProblems
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int[] RemoveDuplicates(int[] inputArray)
        {
            int index = 1;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] != inputArray[i + 1])
                {
                    inputArray[index] = inputArray[i + 1];
                    index++;
                }
            }

            int[] outputArray = new int[index];

            for (int i = 0; i < index; i++)
            {
                outputArray[i] = inputArray[i];
            }

            return outputArray;
        }
    }
}