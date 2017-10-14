namespace TableOperations
{
    public class StringOperations
    {
        public string SubString(string stringToCut, int start, int length)
        {
            string subString = "";
            for (int i = start; i < start + length; i++)
            {
                subString += stringToCut[i];
            }
            return subString;
        }

        public string ReverseString(string stringToReverse)
        {
            string reverse = "";
            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                reverse += stringToReverse[i];
            }
            return reverse;
        }

        public bool IsPalindrom(string candidate)
        {
            for (int i = 0, j = candidate.Length - 1; i < j; i++, j--)
            {
                if (candidate[i] != candidate[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}