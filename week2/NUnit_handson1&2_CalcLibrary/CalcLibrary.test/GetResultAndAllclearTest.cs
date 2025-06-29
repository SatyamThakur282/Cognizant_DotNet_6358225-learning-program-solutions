using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.test
{
    [TestFixture]
    public class GetResultAndAllclearTest
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [Test]
        public void TestAddAndClear()
        {
            // Step 1: Add two numbers
            _calculator.Addition(10, 5);

            // Step 2: Verify result is correct
            Assert.AreEqual(15, _calculator.GetResult, "Addition result mismatch");

            // Step 3: Clear the result
            _calculator.AllClear();

            // Step 4: Verify result is reset to 0
            Assert.AreEqual(0, _calculator.GetResult, "Result was not cleared correctly");
        }
    }
}
