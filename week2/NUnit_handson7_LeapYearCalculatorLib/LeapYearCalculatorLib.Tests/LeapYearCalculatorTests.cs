namespace LeapYearCalculatorLib.Tests
{
    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new LeapYearCalculator();
        }

        // Valid leap years → returns 1
        [TestCase(2000, 1)]
        [TestCase(2020, 1)]
        [TestCase(2400, 1)]

        // Valid non-leap years → returns 0
        [TestCase(2019, 0)]
        [TestCase(2100, 0)]
        [TestCase(2023, 0)]

        // Invalid years → returns -1
        [TestCase(1700, -1)]
        [TestCase(10000, -1)]
        [TestCase(1500, -1)]
        public void IsLeapYear_YearInput_ExpectedResult(int year, int expected)
        {
            int result = _calculator.IsLeapYear(year);
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}