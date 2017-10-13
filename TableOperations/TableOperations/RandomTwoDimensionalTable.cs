using System;

namespace TableOperations
{
    public class RandomTwoDimensionalTable
    {
        public int[,] TwoDimension(int[,] twoDimensional)
        {
            int[,] twoDimensionalTable = new int[2, 5];

            Random random = new Random();
            for (int i = 0; i < twoDimensionalTable.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalTable.GetLength(1); j++)
                {
                    twoDimensionalTable[i, j] = random.Next(10);
                }
            }
            return twoDimensional;
        }
    }
}