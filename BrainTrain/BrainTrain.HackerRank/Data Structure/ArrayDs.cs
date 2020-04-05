using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTrain.HackerRank.Data_Structure
{
    public static class ArrayDs
    {
        public static int[] ReverseArray(int[] ar) {
            int[] res = new int[ar.Length];
            for (int i = 0; i < ar.Length; i++)
            {
                res[i] = ar[ar.Length - i - 1];
            }
            return res;
        }
    }
}
