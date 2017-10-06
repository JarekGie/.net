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

            //suma elementów tablicy

            int suma = 0;
            for (int i = 0; i < tableRandom.Length; i++)
            {
                suma += tableRandom[i];
            }
            
            Console.Write("Suma elementów tablicy to: " + suma);
            Console.WriteLine();

            // parzyste od początku tablicy, a nieparzyste od końca

            int[] parzyste = rt.quasiRandom(new int[30]);

           // int k = tableRandom.Length - 1;

            for(int i = 0,j = 0,k = tableRandom.Length - 1; i < tableRandom.Length; i++)
            {
                if (tableRandom[i] % 2 == 0)
                {
                    parzyste[j] = tableRandom[i];
                    i++;
                }
                else
                {
                    parzyste[j] = tableRandom[i];
                    k--;
                }
            }



            //wycinanie fragmentu stringu

            StringOperations sub = new StringOperations();

            Console.WriteLine("Wpisz jakiś tekst do przycięcia: ");
            int start = 2;
            int toCut = 4;
            string jakisTekst = sub.SubString(Console.ReadLine(), start, toCut);

            Console.Write(jakisTekst);
           Console.WriteLine();
            



            //odwracanie stringu
            Console.WriteLine("Wpisz jakiś tekst do odwrócenia: ");
            
            string reverseString = sub.ReverseString(Console.ReadLine());
            
            Console.Write(reverseString);
            Console.WriteLine();

            // Is It Palindrom???

            Console.WriteLine("Wpisz tekst do sprawdzenia: ");
            string candidate = Console.ReadLine();
            string isPalindrom = sub.ReverseString(candidate);

            if (candidate == isPalindrom)
            {
                Console.Write("To jest palindrom! ");
            }
            else
            {
                Console.Write("To NIE jest palindrom!!!");
            }


            //zmiana tekstu na Wielkie litery (ToUpper)



            Console.ReadLine();
        }//main
    }//class
}//namespace
