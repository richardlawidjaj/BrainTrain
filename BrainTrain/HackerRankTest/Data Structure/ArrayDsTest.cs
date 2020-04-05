using BrainTrain.HackerRank.Data_Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Data_Structure
{
    [TestClass]
    public class ArrayDsTest
    {
        [TestMethod]
        public void ArrayDsUnitTest()
        {
            int[] input= new int[] { 1, 2, 3, 4 };
            var result = ArrayDs.ReverseArray(input);
            Assert.IsTrue(result[0] == 4);
        }
    }
}
