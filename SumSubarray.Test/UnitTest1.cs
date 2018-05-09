using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumSubarray.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 1, 2, 3, 4, 5, 6 };
            SplitArray sa = new SplitArray();
            bool result = sa.isSumEqual(arr);

            // Expected true
            // {1,1,2,3,4} and {5,6} => sum = 11
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 1, 3, 2, 6 };
            SplitArray sa = new SplitArray();
            bool result = sa.isSumEqual(arr);

            // Expected true
            // {1,3,2} and {6} => sum = 6
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 1, 5, 7 };
            SplitArray sa = new SplitArray();
            bool result = sa.isSumEqual(arr);

            // Expected false
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] arr = { 1, 2, 3, 4, 5, 5 };
            SplitArray sa = new SplitArray();
            bool result = sa.isSumEqual(arr);

            // Expected true
            // {1,2,3,4} and {5,5} => sum = 10
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            SplitArray sa = new SplitArray();
            bool result = sa.isSumEqual(arr);

            // Expected false
            Assert.AreEqual(false, result);
        }
    }
}
