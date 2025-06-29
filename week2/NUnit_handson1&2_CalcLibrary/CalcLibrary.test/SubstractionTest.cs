using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.test
{
    [TestFixture]

    public class SubstractionTest
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator = null;
        }

        [Test]
        [TestCase(10, 5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(20, 30, -10)]
        public void Subtract_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Subtraction(a,b);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [Ignore("Temporarily skipping this test")]
        public void ThisTestIsIgnored()
        {
            Assert.Fail("You should not see this test run.");
        }
    }
}
