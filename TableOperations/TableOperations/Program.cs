﻿using System;
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
            int[] result = bs.Sort(tableRandom);
            
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

           IntOperations en = new IntOperations();

            int[] divideEvenUnEven = en.DivideEvenUneven(new int[10]);


            Console.WriteLine("Parzyste od początku, nieparzyste od końca tablicy");

            for (int i = 0; i < divideEvenUnEven.Length; i++)
            {
                Console.Write(divideEvenUnEven[i] + " ");
            }

           
           Console.WriteLine();


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
