using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace VIVALACODE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new List<int> { 2 }, PrimeFactor.breakdown(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new List<int> { 3 }, PrimeFactor.breakdown(3));
        }

        [TestMethod]
        public void TestMethod4()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 2 }, PrimeFactor.breakdown(4));
        }

        [TestMethod]
        public void TestMethod5()
        {
            CollectionAssert.AreEqual(new List<int> { 5 }, PrimeFactor.breakdown(5));
        }

        [TestMethod]
        public void TestMethod6()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeFactor.breakdown(6));
        }

        [TestMethod]
        public void TestMethod7()
        {
            CollectionAssert.AreEqual(new List<int> { 7 }, PrimeFactor.breakdown(7));
        }

        [TestMethod]
        public void TestMethod8()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 2, 2 }, PrimeFactor.breakdown(8));
        }

        [TestMethod]
        public void TestMethod9()
        {
            CollectionAssert.AreEqual(new List<int> { 3, 3 }, PrimeFactor.breakdown(9));
        }

        [TestMethod]
        public void TestMethodBigNumber()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 2, 3, 3, 5, 7, 11, 13, 23, 31 }, PrimeFactor.breakdown(2 * 2 * 3 * 3 * 5 * 7 * 11 * 13 * 23 * 31));
        }
    }
}