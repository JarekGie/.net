namespace TableOperations
{
    public class IntOperations
    {
        public int[] DivideEvenUneven(int[] evenNumber)
        {
            RandomTable rt = new RandomTable();

            int[] tableRandom = rt.quasiRandom(new int[10]);

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
        }
    }
}