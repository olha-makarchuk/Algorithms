using SearchAlgorithms;


int[] arr = { 34, 64, 25, 12, 22, 11, 90 };
int numberToFind = 22;


BinarySearch binarySearch = new BinarySearch
{
    NumArray = arr,
    SearchedNumber = numberToFind
};

int iterativeResult = binarySearch.SearchIterative();
int recursiveResult = binarySearch.SearchRecursive();


LinearSearch linearSearch = new LinearSearch
{
    NumArray = arr,
    SearchedNumber = numberToFind
};


LongestCommonSubstring longestCommonSubstring = new LongestCommonSubstring
{
    FirstWord = "диск", 
    SecondWord = "тиск"
};

string result = longestCommonSubstring.Search();