using NUnit.Framework;
using Moq;
using ConverterLib;

namespace ConverterLib.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void USDToEuro_ValidDollarAmount_ReturnsExpectedEuroValue()
        {
            // Arrange
            var mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            mockFeed.Setup(x => x.GetExchangeRate()).Returns(0.85); // Mocked exchange rate

            var converter = new Converter(mockFeed.Object);
            double dollar = 100;

            // Act
            double result = converter.USDToEuro(dollar);

            // Assert (Single Assertion Rule)
            Assert.That(result, Is.EqualTo(85.0).Within(0.01));
        }

        [Test]
        public void USDToEuro_ZeroDollar_ReturnsZero()
        {
            // Arrange
            var mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            mockFeed.Setup(x => x.GetExchangeRate()).Returns(0.85);

            var converter = new Converter(mockFeed.Object);

            // Act
            double result = converter.USDToEuro(0);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void USDToEuro_NegativeDollar_ReturnsNegativeEuro()
        {
            // Arrange
            var mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            mockFeed.Setup(x => x.GetExchangeRate()).Returns(0.75);

            var converter = new Converter(mockFeed.Object);

            // Act
            double result = converter.USDToEuro(-40);

            // Assert
            Assert.That(result, Is.EqualTo(-30).Within(0.01));
        }
    }
}
