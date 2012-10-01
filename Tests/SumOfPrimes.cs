using System;
using System.Collections.Generic;
using NUnit.Framework;
using SumOfPrimes;


namespace Tests
{
    [TestFixture]
    public class SumOfPrimes
    {
        [Test]
        public void TestPrimality()
        {
            ISumOfPrimes sop = new SimpleSumOfPrimes();

            List<int> primes = sop.FindPrimes(5);

            Assert.IsTrue(primes.Contains(1));
            Assert.IsTrue(primes.Contains(2));
            Assert.IsTrue(primes.Contains(3));
            Assert.IsTrue(primes.Contains(5));
            Assert.IsTrue(primes.Contains(7));
        }
    }
}
