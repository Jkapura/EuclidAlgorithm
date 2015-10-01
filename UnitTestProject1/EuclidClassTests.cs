using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCDLogic;

namespace UnitTest
{
    [TestClass]
    public class EuclidClassTests
    {
        [TestMethod]
        public void FindGCDZeroArgsTestMethod()
        {
            //arange
            int first = 0;
            int second = 28;
            int expected = 0;
            //act
            int actual = EuclidClass.FindGCD(first, second);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindGCDTwoArgsTestMethod()
        {
            //arange
            int first = 32;
            int second = 28;
            int expected = 4;
            //act
            int actual = EuclidClass.FindGCD(first, second);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindGCDThreeArgsTestMethod()
        {
            int first = 1173;
            int second = 323;
            int third = 187;

            int expected = 17;

            int actual = EuclidClass.FindGCD(first, second, third);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FindGCDFiveArgsTestMethod()
        {
            int[] num = new int[5] { 169, 273, 247, 52, 780 };
            int expected = 13;

            int actual = EuclidClass.FindGCD(num);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FindBinaryGCDTwoArgs()
        {
            //arange
            int first = 32;
            int second = 28;
            int expected = 4;
            //act
            int actual = EuclidClass.FindBinaryGCD(first, second);
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void FindGCDBinaryThreeArgsTestMethod()
        {
            int first = 1173;
            int second = 323;
            int third = 187;

            int expected = 17;

            int actual = EuclidClass.FindBinaryGCD(first, second, third);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindGCDBinaryFiveArgsTestMethod()
        {
            int[] num = new int[5] { 169, 273, 247, 52, 780 };
            int expected = 13;

            int actual = EuclidClass.FindBinaryGCD(num);
            Assert.AreEqual(expected, actual);

        }
    }
}
