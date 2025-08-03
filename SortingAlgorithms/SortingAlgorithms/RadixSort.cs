namespace SortingAlgorithms
{
    public class RadixSort
    {
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            int max = GetMax(arr);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                arr = CountingSortByDigit(arr, exp);
            }

            return arr;
        }

        private int[] CountingSortByDigit(int[] arr, int exp)
        {
            int[] output = new int[arr.Length];
            int[] count = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[--count[digit]] = arr[i];
            }

            return output;
        }

        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
