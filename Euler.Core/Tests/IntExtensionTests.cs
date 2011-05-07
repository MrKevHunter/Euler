using System.Collections.Generic;
using NUnit.Framework;
using Euler.Core.Extensions;
using System.Linq;

namespace Euler.Core.Tests
{
    [TestFixture]
    public class IntExtensionTests
    {
        [Test]
        public void TestForPerfectNumber()
        {
            IEnumerable<int> enumerable = 28.GetProperDivisors();
            Assert.That(enumerable.Contains(1));
            Assert.That(enumerable.Contains(2));
            Assert.That(enumerable.Contains(4));
            Assert.That(enumerable.Contains(7));
            Assert.That(enumerable.Contains(14));
        }
        [Test]

        public void IsAbundant()
        {
            Assert.That(24.GetDivisorNumberType()==DivisorNumberType.Abundent);
        }
    }
}