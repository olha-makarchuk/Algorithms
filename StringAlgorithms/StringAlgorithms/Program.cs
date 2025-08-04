using StringAlgorithms;

LevenshteinDistance levenshteinDistance = new LevenshteinDistance();
Console.WriteLine(levenshteinDistance.Find("kitten", "sitting")); // Output: 3

Anagram anagram = new Anagram();
Console.WriteLine(anagram.Check("listen", "silent")); // Output: True

Palindrome palindrome = new Palindrome();
palindrome.Check("acbabca");

KMP_Algorithm_for_Pattern_Searching kmp = new KMP_Algorithm_for_Pattern_Searching();
List<int> result = kmp.Search("aaba", "aabaacaadaabaaba");
