namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }
    }
}
