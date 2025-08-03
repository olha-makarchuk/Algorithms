namespace SortingAlgorithms
{
    //O(n log n)
    public class TimSort
    {
        private readonly MergeSort mergeSort = new();

        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return arr;

            int runSize = 4;

            // 1. Сортування кожного run за допомогою Insertion Sort
            for (int i = 0; i < arr.Length; i += runSize)
            {
                int right = Math.Min(i + runSize - 1, arr.Length - 1);
                InsertionSort(arr, i, right);
            }

            // 2. Поступове злиття відсортованих блоків
            for (int size = runSize; size < arr.Length; size *= 2)
            {
                for (int left = 0; left < arr.Length; left += 2 * size)
                {
                    int mid = Math.Min(left + size - 1, arr.Length - 1);
                    int right = Math.Min(left + 2 * size - 1, arr.Length - 1);

                    if (mid >= right) continue;

                    int[] leftRun = mergeSort.Sort(arr, left, mid);
                    int[] rightRun = mergeSort.Sort(arr, mid + 1, right);
                    int[] merged = mergeSort.Sort(leftRun, rightRun);

                    // Копіюємо назад у оригінальний масив
                    for (int i = 0; i < merged.Length; i++)
                    {
                        arr[left + i] = merged[i];
                    }
                }
            }

            return arr;
        }

        private void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= left && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
    }
}
