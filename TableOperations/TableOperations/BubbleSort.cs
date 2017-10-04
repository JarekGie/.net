using System.Reflection.Emit;

namespace TableOperations
{
    public class BubbleSort
    {
        public int[] sort(int[] tableToSort)
        {
            int temp;
            for (int i = 0; i < tableToSort.Length; i++)
            {
                for (int j = 0; j < tableToSort.Length; j++)
                {
                    if (tableToSort[i] < tableToSort[j])
                    {
                        temp = tableToSort[i];
                        tableToSort[i] = tableToSort[j];
                        tableToSort[j] = temp;
                    }
                }

            }

            return tableToSort;
        }
    }
}