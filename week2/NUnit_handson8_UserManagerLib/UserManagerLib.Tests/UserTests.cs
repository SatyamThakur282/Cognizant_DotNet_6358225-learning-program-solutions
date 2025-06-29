namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UserTests
    {
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _user = new User();
        }

        [Test]
        public void ValidatePANCardNumber_ValidInput_ReturnsValid()
        {
            string result = _user.ValidatePANCardNumber("ABCDE1234F");
            Assert.That(result, Is.EqualTo("Valid"));
        }

        [Test]
        public void ValidatePANCardNumber_NullOrEmptyInput_ThrowsNullReferenceException()
        {
            var ex = Assert.Throws<NullReferenceException>(() => _user.ValidatePANCardNumber(null));
            Assert.That(ex.Message, Is.EqualTo("Invalid Pan Card Number"));
        }

        [Test]
        public void ValidatePANCardNumber_InvalidLength_ThrowsFormatException()
        {
            var ex = Assert.Throws<FormatException>(() => _user.ValidatePANCardNumber("ABC123"));
            Assert.That(ex.Message, Is.EqualTo("Pan Card Number Should contain only 10 characters"));
        }

        [Test]
        public void CreateUser_ValidPANCard_UserCreatedSuccessfully()
        {
            var newUser = new User
            {
                FirstName = "John",
                LastName = "Doe",
                EmailId = "john.doe@example.com",
                PANCardNo = "ABCDE1234F"
            };

            Assert.That(() => _user.CreateUser(newUser), Throws.Nothing);
        }

        [Test]
        public void CreateUser_InvalidPANCard_ThrowsFormatException()
        {
            var newUser = new User
            {
                FirstName = "John",
                LastName = "Doe",
                EmailId = "john.doe@example.com",
                PANCardNo = "ABC"
            };

            Assert.Throws<FormatException>(() => _user.CreateUser(newUser));
        }
    }
}