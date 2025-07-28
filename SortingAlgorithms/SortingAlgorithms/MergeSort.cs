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

            // Traverse both arrays simultaneously and store the smallest element of both to mergedArr
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

            // If any elements remain in the left array, append them to mergedArr
            while (leftIndex < leftArr.Length)
            {
                mergedArr[mergedIndex++] = leftArr[leftIndex++];
            }

            // If any elements remain in the right array, append them to mergedArr
            while (rightIndex < rightArr.Length)
            {
                mergedArr[mergedIndex++] = rightArr[rightIndex++];
            }

            return mergedArr;
        }
    }
}
