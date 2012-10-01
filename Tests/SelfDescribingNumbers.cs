using System.Diagnostics;
using NUnit.Framework;
using SelfDescribingNumbers;

namespace Tests
{
    [TestFixture]
    public class SelfDescribingNumbersTests
    {
        [TestCase(3324332)]
        [TestCase(1211)]
        [TestCase(34235235232)]
        [Test]
        public void InvalidTestForLinearSelfDescribingNumber(long n)
        {
            ISelfDescribingFinder finder = new LinearSelfDescribingNumberFinder();

            Assert.IsFalse(finder.Test(n), "A self describing number was passed to me, a negative test.");
        }

        [TestCase(3324332)]
        [TestCase(1211)]
        [TestCase(444231233)]
        [Test]
        public void InvalidTestForSelfDescribingNumber(long n)
        {
            ISelfDescribingFinder finder = new SimpleSelfDescribingNumberfinder();

            Assert.IsFalse(finder.Test(n), "A self describing number was passed to me, a negative test.");
        }


        [Test]
        [TestCase(2020)]
        [TestCase(1210)]
        [TestCase(6210001000)]
        public void PerformanceTest(long n)
        {
            ISelfDescribingFinder finderLinear = new LinearSelfDescribingNumberFinder();
            ISelfDescribingFinder finderSimple = new SimpleSelfDescribingNumberfinder();

            var swSimple = new Stopwatch();
            var swLinear = new Stopwatch();

            finderLinear.Test(n);
            finderSimple.Test(n);

            swSimple.Start();
            finderSimple.Test(n);
            swSimple.Stop();

            swLinear.Start();
            finderLinear.Test(n);
            swLinear.Stop();

            Assert.IsTrue(swLinear.Elapsed < swSimple.Elapsed, "The simple implementation is faster. wtf?");
        }

        [TestCase(2020)]
        [TestCase(1210)]
        [TestCase(6210001000)]
        [Test]
        public void ValidTestForLinearSelfDescribingNumber(long n)
        {
            ISelfDescribingFinder finder = new LinearSelfDescribingNumberFinder();

            Assert.IsTrue(finder.Test(n), "Not a self describing number.");
        }

        [TestCase(2020)]
        [TestCase(1210)]
        [TestCase(6210001000)]
        [Test]
        public void ValidTestForSelfDescribingNumber(long n)
        {
            ISelfDescribingFinder finder = new SimpleSelfDescribingNumberfinder();

            Assert.IsTrue(finder.Test(n), "Not a self describing number.");
        }
    }
}