using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityMaxCounters
{
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int[] result = new int[N];
            int m = A.Length;

            int maxCounter = 0;
            int lastUpdate = 0;

            for (int k = 0; k < m; k++)
            {
                if (A[k] == N + 1)
                {
                    lastUpdate = maxCounter;
                }
                else
                {
                    int index = A[k] - 1;
                    result[index] = Increment(result[index], lastUpdate);
                    maxCounter = Math.Max(maxCounter, result[index]);
                }
            }

            UpdateResult(result, lastUpdate);
            Print(result);

            return result;
        }

        private int Increment(int value, int lastUpdate)
        {
            return value < lastUpdate ? lastUpdate + 1 : value + 1;
        }

        private void UpdateResult(int[] result, int lastUpdate)
        {
            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] < lastUpdate)
                {
                    result[i] = lastUpdate;
                }
            }
        }

        public void Print(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
