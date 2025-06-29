using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.test
{
    [TestFixture]

    public class MultiplicationTest
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
        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(0, 5, 0)]
        public void Multiply_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Multiplication(a,b);
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
