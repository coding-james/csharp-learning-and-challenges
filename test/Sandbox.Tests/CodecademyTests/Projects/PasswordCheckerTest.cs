using Sandbox.Codecademy.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodecademyTests.Projects
{
    public class PasswordCheckerTest
    {
        [Theory]
        [InlineData("word", 1, "Weak")]
        [InlineData("woRD", 2, "Medium")]
        [InlineData("1woRD", 3, "Strong")]
        [InlineData("2woRDsss", 4, "Extremely strong!")]
        [InlineData("2woRDsss!", 5, "Extremely strong!")]
        public void PasswordChecker_Valid(string userInput, int score, string expected)
        {

            // Arrange
            string expectedOutput = $"Your password score is {score} and your password is {expected}";

            // Act
            string result = PasswordChecker.PasswordScore(userInput);

            // Assert
            Assert.Equal(expectedOutput, result);
        }


        [Theory]
        [InlineData("\" \"")]
        [InlineData("123456")]
        [InlineData("password")]
        [InlineData("PASSWORD")]
        [InlineData("qwerty")]
        [InlineData("QWERTY")]
        public void PasswordChecker_Invalid(string userInput)
        {

            // Arrange        
            string expectedOutput = "Your password doesn't meet the minimum requirement";

            // Act
            string result = PasswordChecker.PasswordScore(userInput);

            //Assert
            Assert.Equal(expectedOutput, result);
        }
    }
}
