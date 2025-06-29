using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib.Test
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser _parser;

        [SetUp]
        public void Setup()
        {
            _parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_HttpsUrl_ReturnsHostName()
        {
            // Arrange
            string input = "https://www.example.com/page";
            string expected = "www.example.com";

            // Act
            string result = _parser.ParseHostName(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ParseHostName_HttpUrl_ReturnsHostName()
        {
            string input = "http://test.domain.org/home";
            string expected = "test.domain.org";

            string result = _parser.ParseHostName(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ParseHostName_UnsupportedProtocol_ThrowsFormatException()
        {
            string input = "ftp://files.example.com/download";

            var ex = Assert.Throws<FormatException>(() => _parser.ParseHostName(input));
            Assert.That(ex.Message, Is.EqualTo("Url is not in correct format"));
        }

        [Test]
        public void ParseHostName_NullInput_ThrowsNullReferenceException()
        {
            string input = null;

            Assert.Throws<NullReferenceException>(() => _parser.ParseHostName(input));
        }

        [Test]
        public void ParseHostName_EmptyInput_ThrowsIndexOutOfRangeException()
        {
            string input = "";

            var ex = Assert.Throws<FormatException>(() => _parser.ParseHostName(input));
            Assert.That(ex.Message, Is.EqualTo("Url is not in correct format"));
        }
    }
}
