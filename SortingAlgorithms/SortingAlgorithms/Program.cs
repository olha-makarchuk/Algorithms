using SortingAlgorithms;

int[] original = { 9, 4, 3, 8, 9, 10, 2, 5 };

PrintResult("BubbleSort", new BubbleSort { NumArray = Copy(original) }.Sort());
PrintResult("MergeSort", new MergeSort().Sort(Copy(original), 0, original.Length - 1));
PrintResult("QuickSort", new QuickSort().Sort(Copy(original)));
PrintResult("HeapSort", new HeapSort().Sort(Copy(original)));
PrintResult("CountingSort", new CountingSort().Sort(Copy(original)));
PrintResult("InsertionSort", new InsertionSort().Sort(Copy(original)));
PrintResult("SelectionSort", new SelectionSort().Sort(Copy(original)));
PrintResult("ShellSort", new ShellSort().Sort(Copy(original)));
PrintResult("RadixSort", new RadixSort().Sort(Copy(original)));

int[] arr = {
    41, 42, 40, 39, 38, 9, 4, 3, 45, 34, 13,14, 29, 31, 33, 32,
    7, 22, 15, 6, 17, 11, 18, 20, 16, 19, 12, 30,
    28, 25, 27, 23, 8, 9, 10, 2, 5, 1, 26, 24, 21, 
    50, 48, 46, 49, 47, 44, 43, 
};

PrintResult("TimSort", new TimSort().Sort(Copy(arr)));

int[] Copy(int[] arr) => (int[])arr.Clone();

void PrintResult(string name, int[] sorted)
{
    Console.WriteLine($"{name}: {string.Join(", ", sorted)}");
}
