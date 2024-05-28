using Microsoft.SqlServer.Server;
using System;
using Xunit;

namespace WindowsFormsApp6.Tests
{
    public class Form1Tests
    {
        [Fact]
        public void NewAuthenticateUser_ValidLoginAndPassword_ReturnsTrue()
        {
            // Arrange
            var form1 = new Form1();
            string validLogin = "validLogin";
            string validPassword = "validPassword";

            // Act
            bool result = form1.NewAuthenticateUser(validLogin, validPassword);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void NewAuthenticateUser_InvalidLoginOrPassword_ReturnsFalse()
        {
            // Arrange
            var form1 = new Form1();
            string invalidLogin = "invalidLogin";
            string invalidPassword = "invalidPassword";

            // Act
            bool result = form1.NewAuthenticateUser(invalidLogin, invalidPassword);

            // Assert
            Assert.False(result);
        }
    }
}
