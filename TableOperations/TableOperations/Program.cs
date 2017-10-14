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





            Console.WriteLine();
            //wypełnianie tablicy liczbami pseudolosowymi

            RandomTable rt = new RandomTable();

            int[] tableRandom = rt.PseudoRandom(new int[10], 10);

            Console.WriteLine("Tablica liczb pseudolosowych: ");
            for (int i = 0; i < tableRandom.Length; i++)
            {
                Console.Write(tableRandom[i] + " ");
            }

            Console.WriteLine();

            //Wygenerujmy długi, powiedzmy 200-elementowy wektor i wyświetlmy go po 15 elementów w każdym wierszu.

            Console.WriteLine("Formatowana tablica: ");
            int counter = 0;
            int[] formatTable = rt.PseudoRandom(new int[200], 10);

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

            //tablica
            //Wygenerować i wyświetlić  na ekranie tablicę 2-wymiarową.

           
            
            Console.WriteLine("Tablica dwuwymiarowa: ");

            RandomTwoDimensionalTable td = new RandomTwoDimensionalTable();

            int[,] twoDimensional = td.TwoDimension(new int[2,10],2,5);

            for (int i = 0; i < twoDimensional.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensional.GetLength(1); j++)
                {
                    Console.Write(twoDimensional[i,j] + " ");
                }
                Console.WriteLine();
            }
            //tablica

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
                    Console.Write(candidate + " To jest palindrom! ");
                }
                else
                {
                    Console.Write(candidate + " To NIE jest palindrom!!!");
                }


                //zmiana tekstu na Wielkie litery (ToUpper)



                Console.ReadLine();
            } //main
        } //class

    }//namespace
