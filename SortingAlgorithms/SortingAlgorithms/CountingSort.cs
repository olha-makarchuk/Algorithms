namespace SortingAlgorithms
{
    //O(n + k)
    public class CountingSort
    {
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            int min = FindMin(arr);
            int max = FindMax(arr);
            int offset = -min;

            int[] count = CountNumbers(arr, max, offset);
            return SortNumbers(arr, count, offset);
        }

        public int[] CountNumbers(int[] arr, int max, int offset)
        {
            int[] count = new int[max + offset + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] + offset]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            return count;
        }

        public int[] SortNumbers(int[] arr, int[] count, int offset)
        {
            int[] sorted = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int val = arr[i];
                sorted[--count[val + offset]] = val;
            }

            return sorted;
        }

        public int FindMax(int[] arr)
        {
            int max = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }
    }
}
