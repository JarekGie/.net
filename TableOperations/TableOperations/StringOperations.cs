namespace TableOperations
{
    public class StringOperations
    {
        public string SubString(string stringToCut, int start, int length)
        {
            for (int i = start; i < start + length; i++)
            {
                return stringToCut;
            }
            return "";
        }

        public string ReverseString(string stringToReverse)
        {
            for (int i = stringToReverse.Length - 1; i <= 0; i--)
            {
                return stringToReverse;
            }
            return stringToReverse;
        }
    }
}