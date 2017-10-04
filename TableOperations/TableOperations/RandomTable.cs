using System;

namespace TableOperations
{
    public class RandomTable
    {
        public int[] quasiRandom(int[] randomTable)
        {
            

            Random r = new Random();

            for (int i = 0; i < randomTable.Length; i++)
            {
                randomTable[i] = r.Next(10);
            }
            return randomTable;
        }
    }
}