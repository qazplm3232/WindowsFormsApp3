using System;
using Xunit;

namespace WindowsFormsApp3.Tests
{
    public class Class1Tests
    {
        [Fact]
        public void AuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            Class1 class1 = new Class1();
            string validLogin = "validLogin";
            string validPassword = "validPassword";

            // Act
            bool result = class1.AuthenticateUser(validLogin, validPassword);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AuthenticateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            Class1 class1 = new Class1();
            string invalidLogin = "invalidLogin";
            string invalidPassword = "invalidPassword";

            // Act
            bool result = class1.AuthenticateUser(invalidLogin, invalidPassword);

            // Assert
            Assert.False(result);
        }
    }
}
