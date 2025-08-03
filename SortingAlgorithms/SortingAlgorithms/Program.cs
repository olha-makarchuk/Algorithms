using SortingAlgorithms;

int[] arr = { 34, 64, 25, 12, 22, 11, 90 };

BubbleSort bubbleSort = new() { NumArray = arr };

MergeSort mergeSort = new();
mergeSort.Sort(arr, 0, arr.Length - 1);

QuickSort quickSort = new();
quickSort.Sort(arr);

arr = [9, 4, 3, 8, 10, 2, 5];
HeapSort heapSort = new();
heapSort.Sort(arr);

arr = [9, 4, -3, 8, 9, 10, 2, 5];
CountingSort countingSort = new();
countingSort.Sort(arr);

arr = [9, 4, -3, 8, 9, 10, 2, 5];
InsertionSort insertionSort = new();
insertionSort.Sort(arr);

arr = [9, 4, -3, 8, 9, 10, 2, 5];
SelectionSort selectionSort = new();
selectionSort.Sort(arr);