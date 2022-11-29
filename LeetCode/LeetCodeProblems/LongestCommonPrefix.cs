namespace LeetCode.LeetCodeProblems
{
    public static class LongestCommonPrefix
    {
        public static string GetLongestCommonPrefix(string[] input)
        {
            if (input == null || input.Length == 0 || input.Length > 200)
            {
                System.Console.WriteLine("Girilen dizideki kelime sayısı 1 ile 200 arasında olmalıdır!");
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 200)
                {
                    System.Console.WriteLine("Girilen dizideki kelime harflerinin sayısı 200 karakteri geçmemelidir!");
                }
            }

            int initialCount = input[0].Length;

            string output = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                int count = input[i].Length;

                for (int j = 0; j < initialCount; j++)
                {
                    if (j == count || input[i][j] != output[j])
                    {
                        output = output.Substring(0, j);

                        initialCount = output.Length;

                        if (initialCount == 0)
                        {
                            return "";
                        }

                        break;
                    }
                }
            }

            return output;
        }
    }
}