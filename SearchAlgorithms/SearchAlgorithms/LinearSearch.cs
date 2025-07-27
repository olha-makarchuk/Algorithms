namespace SearchAlgorithms
{
    //O(N)
    public class LinearSearch
    {
        public int[] NumArray { get; set; }
        public int SearchedNumber { get; set; }

        public int Search()
        {
            for (int i = 0; i < NumArray.Length; i++)
            {
                if (NumArray[i] == SearchedNumber)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
