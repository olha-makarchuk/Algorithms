using SortingAlgorithms;

int[] arr = { 34, 64, 25, 12, 22, 11, 90 };

BubbleSort bubbleSort = new() { NumArray = arr };

MergeSort mergeSort = new();
mergeSort.Sort(arr, 0, arr.Length - 1);

QuickSort quickSort = new();
quickSort.Sort(arr);
