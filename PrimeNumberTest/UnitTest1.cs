using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(PrimeNumber.PrimeNumber.isPrimeNumber(7));
            Assert.IsTrue(PrimeNumber.PrimeNumber.isPrimeNumber(3));
            Assert.IsTrue(PrimeNumber.PrimeNumber.isPrimeNumber(1));
            Assert.IsTrue(PrimeNumber.PrimeNumber.isPrimeNumber(9));
        }
    }
}
