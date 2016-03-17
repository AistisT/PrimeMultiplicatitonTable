using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeMultiplicationTable;

namespace PrimeMultiplicationTable
{
    [TestClass]
   public class UnitTest
    {
        [TestMethod]
        public void TestPrime1()
        {
            PrimeGenerator calc = new PrimeGenerator();
            List<UInt64> primes = calc.returnPrimes(1);
            Assert.AreEqual((UInt64)2, primes[0]);
        }
        [TestMethod]
        public void TestPrimes5()
        {
            PrimeGenerator calc = new PrimeGenerator();
            List<UInt64> primes = calc.returnPrimes(5);
            List<UInt64> expected = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5, (UInt64)7, (UInt64)11 };
            CollectionAssert.AreEqual(expected, primes);
        }
        [TestMethod]
        public void TestPrimes10()
        {
            PrimeGenerator calc = new PrimeGenerator();
            List<UInt64> primes = calc.returnPrimes(10);
            List<UInt64> expected = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5, (UInt64)7, (UInt64)11, (UInt64)13, (UInt64)17, (UInt64)19, (UInt64)23, (UInt64)29 };
            CollectionAssert.AreEqual(expected, primes);
        }
    }
}

