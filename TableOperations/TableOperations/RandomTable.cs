﻿using System;

namespace TableOperations
{
    public class RandomTable
    {
        public int[] PseudoRandom(int[] randomTable,int randomRange)
        {
            

            Random r = new Random();
       
            for (int i = 0; i < randomTable.Length; i++)
            {
                randomTable[i] = r.Next(randomRange);
            }
            return randomTable;
        }
    }
}