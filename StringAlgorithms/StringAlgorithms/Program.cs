using StringAlgorithms;

LevenshteinDistance levenshteinDistance = new LevenshteinDistance();
Console.WriteLine(levenshteinDistance.Find("kitten", "sitting")); // Output: 3