using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTrain.HackerRank.Algorithm
{
    public static class CompareTheTriplets
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int bob=0, alice = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if(a[i] < b[i])
                {
                    bob++;
                }
            }
            return new List<int> { alice, bob };
        }
    }
}
