using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void TestMultiplication3()
        {
            MultiplicationTable  table = new MultiplicationTable();
            List<UInt64> provided = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5 };
            List<List<UInt64>> returned = table.returnTable(provided);
            List<List<UInt64>> expected = new List<List<UInt64>>();
            expected.Add(new List<UInt64> { (UInt64)4, (UInt64)6, (UInt64)10 });
            expected.Add(new List<UInt64> { (UInt64)6, (UInt64)9, (UInt64)15 });
            expected.Add(new List<UInt64> { (UInt64)10, (UInt64)15, (UInt64)25 });
            //2d couldnt get 2d testing pass, even if debugg shows both 2d list exactly the same, passes when testing list on each own
            CollectionAssert.AreEqual(expected[0], returned[0]);
            CollectionAssert.AreEqual(expected[1], returned[1]);
            CollectionAssert.AreEqual(expected[2], returned[2]);
        }
    }
}

