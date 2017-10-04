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

            string jakisTekst = sub.SubString("JarekGolab",2, 3);

            Console.Write(jakisTekst);
           
                
            
            Console.WriteLine();

            //odwracanie stringu
            string reverseString = sub.ReverseString("Jakiś");
            
            Console.Write(reverseString);
           

            //zmiana tekstu na Wielkie litery (ToUpper)

            

            Console.ReadLine();
        }//main
    }//class
}//namespace
