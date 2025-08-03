namespace StringAlgorithms
{
    public class LevenshteinDistance
    {
        public int Find(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;

            int[,] arr = new int[m+1, n+1];

            for(int i = 0; i<= m; i++)
            {
                arr[i,0] = i;
            }            
            
            for(int i = 0; i<= n; i++)
            {
                arr[0,i] = i;
            }

            PrintArray(arr);

            for(int i = 1; i<=m; i++)
            {
                for (int j = 1; j<=n; j++)
                {
                    if (str1[i-1] == str2[j-1])
                    {
                        arr[i, j] = arr[i - 1, j - 1];
                    }
                    else
                    {
                        arr[i,j] = 1 + Math.Min(arr[i-1, j-1],Math.Min(arr[i - 1, j], arr[i, j - 1]));
                    }
                }
            }

            PrintArray(arr);

            return arr[arr.GetLength(0)-1, arr.GetLength(1)-1];
        }

        public void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write(arr[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
