using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTrain.HackerRank.Data_Structure
{
    public static class LeftRotate
    {
        public static int[] RotateLeft(int[] a, int n)
        {
            int tmp = 0;
            for (int i = 0; i < n; i++)
            {
                tmp = a[0];
                for (int j = 0; j < a.Length; j++)
                {
                    
                    if (j == a.Length - 1)
                    {
                        a[j] = tmp;
                    }
                    else {
                        a[j] = a[j + 1];
                    }
                }
            }
            return a;
        }
    }
}
