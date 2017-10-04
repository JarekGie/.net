
namespace firstProject
{
    public class TablesOperations
    {
        public int[] GetElementsFromTable(int[] table, int greaterThan) //ta
        {
            int[] result = new int[table.Length];
            for (int i = 0,j = 0; i < table.Length; i++)
            {
                if (table[i] > greaterThan)
                {
                    result[j] = table[i];
                    j++;
                }
            }
            return result;
        }//GetElementsFromTable
    }//class
}//namespace