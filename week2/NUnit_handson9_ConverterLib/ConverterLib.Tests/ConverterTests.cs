using NUnit.Framework;
using Moq;
using ConverterLib;

namespace ConverterLib.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Mock<IDollarToEuroExchangeRateFeed> _mockFeed;
        private Converter _converter;

        [SetUp]
        public void SetUp()
        {
            _mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            _converter = new System.Converter(_mockFeed.Object);
        }

        [Test]
        public void USDToEuro_ValidDollarAmount_ReturnsExpectedEuroValue()
        {
            // Arrange
            double dollarAmount = 100;
            double mockExchangeRate = 0.85;

            _mockFeed.Setup(feed => feed.GetActualUSDollarValue()).Returns(mockExchangeRate);

            // Act
            double result = _converter.USDToEuro(dollarAmount);

            // Assert
            Assert.That(result, Is.EqualTo(85.0));
        }

        [Test]
        public void USDToEuro_ZeroDollar_ReturnsZeroEuro()
        {
            _mockFeed.Setup(f => f.GetActualUSDollarValue()).Returns(0.85);

            double result = _converter.USDToEuro(0);

            Assert.That(result, Is.EqualTo(0.0));
        }

        [Test]
        public void USDToEuro_NegativeDollarValue_ReturnsNegativeEuroValue()
        {
            _mockFeed.Setup(f => f.GetActualUSDollarValue()).Returns(0.85);

            double result = _converter.USDToEuro(-50);

            Assert.That(result, Is.EqualTo(-42.5));
        }
    }

    internal interface IDollarToEuroExchangeRateFeed
    {
    }
}
