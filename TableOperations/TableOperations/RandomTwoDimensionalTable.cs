using System;

namespace TableOperations
{
    public class RandomTwoDimensionalTable
    {
        public int[,] TwoDimension(int[,] twoDimensional, int ilw, int ilk, int range)
        {
            ilw = 5;
            ilk = 10;
            int[,] twoDimensionalTable = new int[ilw, ilk];

            Random random = new Random();
            for (int i = 0; i < twoDimensionalTable.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalTable.GetLength(1); j++)
                {
                    twoDimensionalTable[i, j] = random.Next(range);
                }
            }
            return twoDimensionalTable;
        }
    }
}