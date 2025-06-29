using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsManagerLib.Test
{
    [TestFixture]
    public class AccountsManagerTests
    {
        private AccountsManager _manager;

        [SetUp]
        public void SetUp()
        {
            _manager = new AccountsManager();
        }

        [Test]
        public void ValidateUser_ValidUser11Credentials_ReturnsWelcomeMessage()
        {
            string result = _manager.ValidateUser("user_11", "secret@user11");
            Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void ValidateUser_ValidUser22Credentials_ReturnsWelcomeMessage()
        {
            string result = _manager.ValidateUser("user_22", "secret@user22");
            Assert.That(result, Is.EqualTo("Welcome user_22!!!"));
        }

        [Test]
        public void ValidateUser_InvalidCredentials_ReturnsInvalidMessage()
        {
            string result = _manager.ValidateUser("user_11", "wrongpass");
            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void ValidateUser_EmptyUserId_ThrowsFormatException()
        {
            var ex = Assert.Throws<FormatException>(() => _manager.ValidateUser("", "anyPassword"));
            Assert.That(ex.Message, Is.EqualTo("Both user id and password are mandatory"));
        }

        [Test]
        public void ValidateUser_EmptyPassword_ThrowsFormatException()
        {
            var ex = Assert.Throws<FormatException>(() => _manager.ValidateUser("user_11", ""));
            Assert.That(ex.Message, Is.EqualTo("Both user id and password are mandatory"));
        }

        [Test]
        public void ValidateUser_NullValues_ThrowsFormatException()
        {
            var ex = Assert.Throws<FormatException>(() => _manager.ValidateUser(null, null));
            Assert.That(ex.Message, Is.EqualTo("Both user id and password are mandatory"));
        }
    }
}
