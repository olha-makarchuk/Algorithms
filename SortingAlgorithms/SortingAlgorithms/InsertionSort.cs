namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            for (int i =1; i<arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j>=0 && arr[j]> key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;

            }
            return arr;
        }
    }
}
