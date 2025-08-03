namespace SortingAlgorithms
{
    //O(nlog n)

    public class ShellSort
    {
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];

                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }
            return arr;
        }
    }
}
