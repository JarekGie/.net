using System;

namespace TableOperations
{
    public class RandomTwoDimensionalTable
    {
        public int[,] TwoDimension(int countOfRows, int countOfCols, int range)
        {
           
            int[,] twoDimensionalTable = new int[countOfRows, countOfCols];

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