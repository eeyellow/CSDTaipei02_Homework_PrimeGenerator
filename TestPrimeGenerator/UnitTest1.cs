using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace VIVALACODE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new List<int> { 2 }, PrimeGenerator.getPrime(2));
        }
    }
}
