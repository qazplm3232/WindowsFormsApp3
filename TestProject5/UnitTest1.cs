using WindowsFormsApp6;

namespace XUnitDemo
{
    public class UnitTest1
    {
        [Fact]
        public void TestUserValidation_ValidUser()
        {
            // Arrange
            
            string validLogin = "validUser";
            string validPassword = "validPassword";

            // Act

            bool isValid = Form1.AuthenticateUser(validLogin, validPassword);

            // Assert
            Assert.True(isValid, "Îæèäàëîñü, ÷òî ïîëüçîâàòåëü áóäåò äåéñòâèòåëüíûì.");
        }

        [Fact]
        public void TestUserValidation_InvalidUser()
        {
            // Arrange
            string invalidLogin = "invalidUser";
            string invalidPassword = "invalidPassword";

            // Act
            //bool isValid = Àâòîðèçàöèÿ.IsUserValid(invalidLogin, invalidPassword);

            // Assert
            Assert.Equal(invalidLogin, "test");
            Assert.Equal(invalidPassword, "test");
        }
    }
}