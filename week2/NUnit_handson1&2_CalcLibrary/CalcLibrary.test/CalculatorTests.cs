using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.test
{
    [TestFixture]
    public class CalculatorTests
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
        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void Add_WhenCalled_ReturnsExpectedSum(int a, int b, int expected)
        {
            int result = (int) _calculator.Addition(a,b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Temporarily skipping this test")]
        public void ThisTestIsIgnored()
        {
            Assert.Fail("You should not see this test run.");
        }
    }
}
