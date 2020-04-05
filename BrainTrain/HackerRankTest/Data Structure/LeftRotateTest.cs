using BrainTrain.HackerRank.Data_Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Data_Structure
{
    [TestClass]
    public class LeftRotateTest
    {
        [TestMethod]
        public void RotateLeftUnitTeest() {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            var result = LeftRotate.RotateLeft(a, 1);
            Assert.IsTrue(result[0] == 2);
        }

        [TestMethod]
        public void RotateLeftUnitTest2()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            var result = LeftRotate.RotateLeft(a, 2);
            Assert.IsTrue(result[0] == 3);
        }

    }
}
