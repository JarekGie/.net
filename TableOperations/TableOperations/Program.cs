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

            Console.WriteLine();
            //wypełnianie tablicy liczbami pseudolosowymi

            RandomTable randomTable = new RandomTable();

            int[] tableRandom = randomTable.PseudoRandom(new int[10], 10);

            Console.WriteLine("Tablica liczb pseudolosowych: ");
            for (int i = 0; i < tableRandom.Length; i++)
            {
                Console.Write(tableRandom[i] + " ");
            }

            Console.WriteLine();

            //Wygenerujmy długi, powiedzmy 200-elementowy wektor i wyświetlmy go po 15 elementów w każdym wierszu.

            Console.WriteLine("Formatowana tablica z nowym wierszem co 15 element: ");
            int counter = 0;
            int countOfRow = 200;
            int range = 10;
            int[] formatTable = randomTable.PseudoRandom(new int[countOfRow], range);

            for (int i = 0; i < formatTable.Length; i++)
            {
                Console.Write(formatTable[i] + " ");
                counter++;
                if (counter == 15)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }

            Console.WriteLine();

           
            //Wygenerować i wyświetlić  na ekranie tablicę 2-wymiarową.

           
            
            Console.WriteLine("Tablica dwuwymiarowa: ");

            RandomTwoDimensionalTable twoDimens = new RandomTwoDimensionalTable();

            int[,] twoDimensional = twoDimens.TwoDimension(4,10,10);

            for (int i = 0; i < twoDimensional.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensional.GetLength(1); j++)
                {
                    Console.Write(twoDimensional[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            /*
             zmodyfikować powyższy program wyświetlając obliczone sumy wierszy i kolumn
             – odpowiednio na końcach wierszy i pod kolumnami
             */
           
            int countOfcols = 10;
            int sumOfrows;
            int[] sumOfcols = new int[countOfcols];

            Console.WriteLine("Suma wierszy i kolumn w tablicy:");

            sumOfrows = 0;

            for (int i = 0; i < twoDimensional.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensional.GetLength(1); j++)
                {
                    sumOfcols[j] +=  twoDimensional[i,j];

                    Console.Write(twoDimensional[i,j] + " ");

                    sumOfrows += twoDimensional[i, j];
                }
                Console.WriteLine(" " + sumOfrows);
                sumOfrows = 0;
            }
            for (int i = 0; i < countOfcols; i++)
            {
                Console.Write(sumOfcols[i] + " ");
            }

            Console.WriteLine("\n\n");
                //sortowanie bąbelkowe

                Console.WriteLine("Sortowanie bąbelkowe: ");

                BubbleSort bubbleSort = new BubbleSort();
                int[] result = bubbleSort.Sort(tableRandom);

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

                IntOperations evenUneven = new IntOperations();
                int[] divideEvenUnEven = evenUneven.DivideEvenUneven(new int[10]);


                Console.WriteLine("Parzyste od początku, nieparzyste od końca tablicy");

                for (int i = 0; i < divideEvenUnEven.Length; i++)
                {
                    Console.Write(divideEvenUnEven[i] + " ");
                }

                Console.WriteLine();
            





            //wycinanie fragmentu stringu

            StringOperations subString = new StringOperations();

                Console.WriteLine("Wpisz jakiś tekst do przycięcia: ");
                int start = 2;
                int toCut = 4;
                string jakisTekst = subString.SubString(Console.ReadLine(), start, toCut);
                Console.Write(jakisTekst);
                Console.WriteLine();







                //odwracanie stringu
                Console.WriteLine("Wpisz jakiś tekst do odwrócenia: ");

                string reverseString = subString.ReverseString(Console.ReadLine());

                Console.Write(reverseString);
                Console.WriteLine();






                // Is It Palindrom???

                Console.WriteLine("Wpisz tekst do sprawdzenia: ");
                string candidate = Console.ReadLine();
                string isPalindrom = subString.ReverseString(candidate);

                if (candidate == isPalindrom)
                {
                    Console.Write(candidate + " To jest palindrom! ");
                }
                else
                {
                    Console.Write(candidate + " To NIE jest palindrom!!!");
                }
                
             Console.ReadLine();
            } //main
        } //class

    }//namespace
