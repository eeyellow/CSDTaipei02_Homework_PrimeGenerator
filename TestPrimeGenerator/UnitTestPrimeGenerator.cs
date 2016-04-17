using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace VIVALACODE
{
    [TestClass]
    public class UnitTest_PrimeGenerator
    {
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new List<int> { 2 }, PrimeGenerator.getPrime(2));
        }

        [Ignore]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeGenerator.getPrime(3));
        }

        [Ignore]
        public void TestMethod4()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeGenerator.getPrime(4));
        }
    }
}
