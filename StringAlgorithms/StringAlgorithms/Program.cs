using StringAlgorithms;

LevenshteinDistance levenshteinDistance = new LevenshteinDistance();
Console.WriteLine(levenshteinDistance.Find("kitten", "sitting")); // Output: 3

Anagram anagram = new Anagram();
Console.WriteLine(anagram.Check("listen", "silent")); // Output: True