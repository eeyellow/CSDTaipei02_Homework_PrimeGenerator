using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace VIVALACODE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new List<int> { 2 }, PrimeGenerator.getPrime(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeGenerator.getPrime(3));
        }
    }
}
