using System;

//Należy rozdzielić elementy parzyste od nieparzystych umieszczając parzyste od początku nowego wektora 
//a nieparzyste – od końca.

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
       
    }//IntOperations
}//namespace