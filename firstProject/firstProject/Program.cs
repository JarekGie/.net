using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = "Jarek";

            string[] imiona =
            {
                "Jarek",
                "Michał",
                "Justyna",
                "Beatka"
            };
           
            
            // zadanie domowe

            ErnestStringOperations strOp = new ErnestStringOperations();

            string result = strOp.GetName();
            //Console.WriteLine("Podane imie to: {0}",result);

           // string substring = strOp.Substring("bartlomiej", 2, 4);

           // Console.WriteLine("Substring to: " + substring);

           // Console.WriteLine();

            int letterPositionInString = strOp.LetterPositionInString("Jarek", 'a');
            Console.WriteLine("Pozycja " + letterPositionInString);

            //koniec zadania



            int index = FindIndexInTable(imiona, "Jarek");
            Console.WriteLine("index :" + index);


            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine("Imiona: " + imiona[i]);
            }

            string reversed = ReverseString(name);
            string reversed2 = ReverseString("Justyna");

            Console.Write("\n Odwrócony: " + reversed);
            Console.Write("\n " + reversed2);

            Console.WriteLine("\n\n");
            Console.Write("\n substring: " + Substring("Beatka",2, 4));

            Console.WriteLine("\n\n");
            
            Console.Write("\n substring: " + Substring("Jarosław", 2, 4));

            Console.WriteLine("\n\n");

        

            Console.ReadLine();
        }//main

        public static int FindIndexInTable(string[] table, string value)
        {
            
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }//FindIndexInTable


        public static string ReverseString(string candidate)
        {
            string result = "";
            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result += candidate[i];
            }
            return result;

        }//ReverseString

        public static bool IsPalindrom(string candidate)
        {
            string reversedString = ReverseString(candidate);
            return reversedString == candidate;
        }//IsPalindrom

        public static string Substring(string candidate, int start, int lenght)
        {
            string fragment = "";
            for (int i = start; i < start + lenght; i++)
            {
                fragment += candidate[i];
            }
            return fragment;
        }//Substring

        public static string ReplaceInText(string candidate, string find, string replace)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                string sub = Substring(candidate, i, find.Length);
            }
            return null;
        }//ReplaceInText
        

       


        public static string nameTable(string[] name)
        {
            
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Imię w tablicy to: {0}",name[i]);
                return null;
            }
            return null;
        }
        
    }//class
}//namespace
