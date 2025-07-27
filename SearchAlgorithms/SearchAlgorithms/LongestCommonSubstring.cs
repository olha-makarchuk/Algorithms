namespace SearchAlgorithms
{
    public class LongestCommonSubstring
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }

        public string Search()
        {
            int m = FirstWord.Length;
            int n = SecondWord.Length;
            int[,] dp = new int[m + 1, n + 1];
            int maxLen = 0;
            int endIndex = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (FirstWord[i - 1] == SecondWord[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;

                        if (dp[i, j] > maxLen)
                        {
                            maxLen = dp[i, j];
                            endIndex = i;
                        }
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            return FirstWord.Substring(endIndex - maxLen, maxLen);
        }
    }
}
