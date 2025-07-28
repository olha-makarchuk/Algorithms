namespace SortingAlgorithms
{
    public class QuickSort
    {
        public int[] Sort(int[] arr)
        {
            return Sort(arr, 0, arr.Length - 1);
        }

        private int[] Sort(int[] arr, int left, int right)
        {
            if (left >= right)
                return arr;

            int pivotIndex = MedianOfThree(arr, left, right);
            int pivotNewIndex = Partition(arr, left, right, pivotIndex);

            Sort(arr, left, pivotNewIndex - 1);
            Sort(arr, pivotNewIndex + 1, right);

            return arr;
        }

        private int Partition(int[] arr, int left, int right, int pivotIndex)
        {
            int pivotValue = arr[pivotIndex];

            Swap(arr, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (arr[i] < pivotValue)
                {
                    Swap(arr, i, storeIndex);
                    storeIndex++;
                }
            }

            Swap(arr, storeIndex, right);

            return storeIndex;
        }

        private int MedianOfThree(int[] arr, int left, int right)
        {
            int mid = (left + right) / 2;

            int a = arr[left];
            int b = arr[mid];
            int c = arr[right];

            if ((a > b && a < c) || (a > c && a < b))
                return left;
            else if ((b > a && b < c) || (b > c && b < a))
                return mid;
            else
                return right;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
