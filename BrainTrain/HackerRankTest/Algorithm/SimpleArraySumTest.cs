using BrainTrain.HackerRank.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTest.Algorithm
{
    [TestClass]
    public class SimpleArraySumTest
    {
        [TestMethod]
        public void SimpleArraySumUnitTest()
        {
            int[] ar = new int[] { 1, 2, 3 };
            int result = SimpleArraySum.SimpleArraySumFuction(ar);
            Assert.IsTrue(result == 6);
        }

        [TestMethod]
        public void SimpleArraySumUnitEmptyArrayTest()
        {
            int[] ar=new int[0]; 
            int result = SimpleArraySum.SimpleArraySumFuction(ar);
            Assert.IsTrue(result == 0);
        }
    }
}
