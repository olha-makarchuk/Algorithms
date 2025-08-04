namespace StringAlgorithms
{
    public class Palindrome
    {
        public bool Check(string str)
        {
            int mid = str.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
