using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TableOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //wypełnianie tablicy liczbami pseudolosowymi

            RandomTable rt = new RandomTable();
            
            int[] tableRandom = rt.quasiRandom(new int[10]);

            Console.WriteLine("Tablica liczb pseudolosowych: ");
            for (int i = 0; i < tableRandom.Length; i++)
            {
                Console.Write(tableRandom[i] + " ");
            }

            Console.WriteLine();

            //sortowanie bąbelkowe

            Console.WriteLine("Sortowanie bąbelkowe: ");
            
            BubbleSort bs = new BubbleSort();
            int[] result = bs.sort(tableRandom);
            
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
            //wycinanie fragmentu stringu
            StringOperations sub = new StringOperations();

            string jakisTekst = sub.subString("JarekGolab", 4, 6);

            
                Console.Write(jakisTekst);
            
            Console.WriteLine();

            //odwracanie stringu

            for (int i = jakisTekst.Length - 1; i >= 0; i--)
            {
                Console.Write(jakisTekst[i]);
            }

            //zmiana tekstu na Wielkie litery (ToUpper)

            string text = "jakiś";
            string text2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 95)
                {
                  // text2= (char) text[i] - 32;
                }
            }

            Console.ReadLine();
        }//main
    }//class
}//namespace
