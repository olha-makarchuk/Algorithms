using System.IO;

namespace StringAlgorithms
{
    public class KMP_Algorithm_for_Pattern_Searching
    {
        public void makeLps(string pattern, int[] lps)
        {
            int len = 0;

            lps[0] = 0;

            int i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
        }

        public List<int> Search(string pattern, string txt)
        {
            int n = txt.Length;
            int m = pattern.Length;

            int[] lps = new int[m];
            List<int> res = new List<int>();

            makeLps(pattern, lps);

            // Pointers i and j, for traversing 
            // the text and pattern
            int i = 0;
            int j = 0;

            while (i < n)
            {

                // If characters match, move both pointers forward
                if (txt[i] == pattern[j])
                {
                    i++;
                    j++;

                    // If the entire pattern is matched 
                    // store the start index in result
                    if (j == m)
                    {
                        res.Add(i - j);

                        // Use LPS of previous index to 
                        // skip unnecessary comparisons
                        j = lps[j - 1];
                    }
                }

                // If there is a mismatch
                else
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }
            return res;
        }
    }
}
