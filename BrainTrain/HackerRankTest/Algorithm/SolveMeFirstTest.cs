using BrainTrain.HackerRank.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTest.Algorithm
{
    [TestClass]
    public class SolveMeFirstTest
    {
        [TestMethod]
        public void SolveMeFirstUnitTest() {

            int a = 2;
            int b = 3;
            int result=SolveMeFirst.SolveMeFirstFunction(a, b);
            Assert.IsTrue(result == 5);
        }
        
    }
}
