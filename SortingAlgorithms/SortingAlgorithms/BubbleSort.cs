namespace SortingAlgorithms
{
    //O(N²)
    public class BubbleSort
    {
        public int[] NumArray { get; set; }

        public int[] Sort()
        {
            for (int i = 0; i < NumArray.Length - 1; i++)
            {
                for (int j = 0; j < NumArray.Length - i - 1; j++)
                {
                    if (NumArray[j] > NumArray[j + 1])
                    {
                        int temp_j = NumArray[j];
                        NumArray[j] = NumArray[j + 1];
                        NumArray[j + 1] = temp_j;
                    }
                }
            }

            return NumArray;
        }
    }
}
