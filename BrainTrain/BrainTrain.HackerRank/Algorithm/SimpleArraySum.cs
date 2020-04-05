using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTrain.HackerRank.Algorithm
{
    public static class SimpleArraySum
    {
        public static int SimpleArraySumFuction(int[] ar) {

            int result = 0;
            if (ar.Length == 0)
                return 0;
            for (int i = 0; i < ar.Length; i++)
            {
                result = result + ar[i];
            }
            return result;
        }
    }
}
