﻿using System;

namespace TableOperations
{
    public class IntOperations
    {
        RandomTable rt = new RandomTable();

        public int[] DivideEvenUneven(int[] evenNumber)
        {
            

            int[] tableRandom = rt.PseudoRandom(new int[10],10);

            for (int i = 0, j = 0, k = tableRandom.Length - 1; i < tableRandom.Length; i++)
            {
                if (tableRandom[i] % 2 == 0)
                {
                    evenNumber[j] = tableRandom[i];
                    j++;
                }
                else
                {
                    evenNumber[k] = tableRandom[i];
                    k--;
                }
            }
            return evenNumber;
        }//DivideEvenUneven

        /*public int[] FormatTable(int[] fotmatTable)
        {
            Console.Write("Formatowana tabela");
            int counter = 0;
            int[] formatTable = rt.PseudoRandom(new int[200]);

            for (int i = 0; i < formatTable.Length; i++)
            {
                Console.Write(formatTable[i] + " ");
                if (counter == 15)
                {
                    Console.WriteLine();
                }
            }
            return formatTable;

        }//FormatTable*/
    }//IntOperations
}//namespace