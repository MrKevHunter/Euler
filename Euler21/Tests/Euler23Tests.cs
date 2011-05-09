using System.Collections.Generic;
using System.Diagnostics;
using Euler.Core.Extensions;
using NUnit.Framework;
using System.Linq;

namespace Euler21.Tests
{
    [TestFixture]
    public class Euler23Tests
    {
        [Test]
        public void CanGetAllDivisors()
        {
            IEnumerable<int> properDivisors = 220.GetProperDivisors();
            Assert.That(properDivisors.Contains(1));
            Assert.That(properDivisors.Contains(2));
            Assert.That(properDivisors.Contains(4));
            Assert.That(properDivisors.Contains(5));
            Assert.That(properDivisors.Contains(10));
            Assert.That(properDivisors.Contains(11));
            Assert.That(properDivisors.Contains(22));
            Assert.That(properDivisors.Contains(44));
            Assert.That(properDivisors.Contains(55));
            Assert.That(properDivisors.Contains(110));
        }

        [Test]
        public void CanGetSumOfDivisors()
        {
            int sum = 220.GetProperDivisors().Sum();
            Assert.That(sum,Is.EqualTo(284));
        }

        [Test]
        public void CanGetDivisorsOfSum()
        {
            int sum = 220.GetProperDivisors().Sum();
            IEnumerable<int> properDivisors = sum.GetProperDivisors();
            Assert.That(properDivisors.Contains(1));
            Assert.That(properDivisors.Contains(2));
            Assert.That(properDivisors.Contains(4));
            Assert.That(properDivisors.Contains(71));
            Assert.That(properDivisors.Contains(142));
            
        }
    }
}