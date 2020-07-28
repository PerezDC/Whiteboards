using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CirclesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.PI, Circles.Circles.Area(1.0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(100 * Math.PI, Circles.Circles.Area(10.0));
        }
    }

}
