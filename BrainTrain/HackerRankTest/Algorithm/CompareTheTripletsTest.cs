using BrainTrain.HackerRank.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest.Algorithm
{
    [TestClass]
    public  class CompareTheTripletsTest
    {
        [TestMethod]
        public void CompareTheTripletsUnitTest()
        {
            List<int> alice = new List<int> { 5, 6, 7 };
            List<int> bob = new List<int> { 3, 6, 10 };

            var result = CompareTheTriplets.CompareTriplets(alice, bob);
            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result[0] == 2);

        }
    }
}
