namespace SortingAlgorithms
{
    //O(n log n)  
    public class MergeSort
    {
        public int[] Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (end + start) / 2;
                int[] leftArr = Sort(array, start, middle);
                int[] rightArr = Sort(array, middle + 1, end);
                int[] mergedArr = Sort(leftArr, rightArr);
                return mergedArr;
            }
            return new int[] { array[start] };
        }

        public int[] Sort(int[] leftArr, int[] rightArr)
        {
            int[] mergedArr = new int[leftArr.Length + rightArr.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;

            while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                if (leftArr[leftIndex] < rightArr[rightIndex])
                {
                    mergedArr[mergedIndex++] = leftArr[leftIndex++];
                }
                else
                {
                    mergedArr[mergedIndex++] = rightArr[rightIndex++];
                }
            }

            while (leftIndex < leftArr.Length)
            {
                mergedArr[mergedIndex++] = leftArr[leftIndex++];
            }

            while (rightIndex < rightArr.Length)
            {
                mergedArr[mergedIndex++] = rightArr[rightIndex++];
            }

            return mergedArr;
        }
    }
}
