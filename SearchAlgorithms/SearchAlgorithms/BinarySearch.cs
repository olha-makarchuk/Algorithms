namespace SearchAlgorithms
{
    //O(log n)
    public class BinarySearch
    {
        public int[] NumArray { get; set; }
        public int SearchedNumber { get; set; }

        public int SearchIterative()
        {
            int low = 0;
            int high = NumArray.Length - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;

                if (NumArray[middle] == SearchedNumber)
                {
                    return middle;
                }

                if (NumArray[middle] < SearchedNumber)
                {
                    low = middle + 1;
                }
                else if (NumArray[middle] > SearchedNumber)
                {
                    high = middle - 1;
                }
            }

            return -1;
        }

        public int SearchRecursive()
        {
            return SearchRecursiveCircle(NumArray, SearchedNumber, 0, NumArray.Length - 1);
        }

        public int SearchRecursiveCircle(int[] array, int number, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int middle = (low + high) / 2;

            if (array[middle] == number)
            {
                return middle;
            }

            if (array[middle] < number)
            {
                return SearchRecursiveCircle(array, number, middle + 1, high);
            }
            else if (array[middle] > number)
            {
                return SearchRecursiveCircle(array, number, low, middle - 1);
            }

            return -1;
        }
    }
}
