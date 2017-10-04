using System;

namespace firstProject
{
    public class ErnestStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string fragment = "";

            for (int i = start; i < start + length; i++)
            {
                fragment += candidate[i];
                
            }
            return fragment;
        }

        public override string GetName()
        {
            string name = "";

            Console.WriteLine("Podaj imie: ");
            
            name = Console.ReadLine();

            return name;
        }

        public override string GlueBeginingEnd(string candidate)
        {
            throw new System.NotImplementedException();
        }

        public override int CountOccurences(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            throw new System.NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            throw new System.NotImplementedException();
        }
    }
}