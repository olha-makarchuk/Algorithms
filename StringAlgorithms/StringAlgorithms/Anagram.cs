namespace StringAlgorithms
{
    public class Anagram
    {
        public bool Check(string str1, string str2)
        {
            if(str1.Length != str2.Length) return false;

            char[] chars1 = str1.ToCharArray();
            char[] chars2 = str2.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return new string(chars1) == new string(chars2);
        }
    }
}
