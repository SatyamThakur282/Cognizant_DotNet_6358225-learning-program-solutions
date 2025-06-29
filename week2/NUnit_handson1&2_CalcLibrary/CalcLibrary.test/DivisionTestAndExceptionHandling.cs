using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.test
{
    [TestFixture]
    public class DivisionTestAndExceptionHandling
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
        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void Divide_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Division(a, b);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            try
            {
                var result = _calculator.Division(10, 0);
                Assert.Fail("Division by zero"); // If no exception is thrown
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero")); // or your exact message
            }
        }

    }
}
