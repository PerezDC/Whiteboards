using CountDistinctElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CountDistinctElementsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 8, 6, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 9 };
            Assert.AreEqual(7, DistinctElements.DistinctElementsCheck(myArray));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] myArray1 = { 5,4,6,3,1,85,4,2,3,4,6,8,4,351,65,65,3,13,521,35,3,132,1,35,321,3 };
            Assert.AreNotEqual(5, DistinctElements.DistinctElementsCheck(myArray1));
        }
    }
}
