using Sandbox.Codecademy.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodecademyTests.Projects
{
    public class PasswordCheckerTests
    {
        [Theory]
        [InlineData("word", 1, "Weak")]
        [InlineData("woRD", 2, "Medium")]
        [InlineData("1woRD", 3, "Strong")]
        [InlineData("2woRDsss", 4, "Extremely strong!")]
        [InlineData("2woRDsss!", 5, "Extremely strong!")]
        public void PasswordChecker_Valid(string userInput, int score, string expected)
        {

            var expectedOutput = $"Please enter a password{Environment.NewLine}" +
                                $"Your password score is {score} and your password is {expected}{Environment.NewLine}";

            using (var swPasswordChecker_Valid = new StringWriter())
            {
                Console.SetOut(swPasswordChecker_Valid); using (var srPasswordChecker_Valid = new StringReader(userInput))
                {
                    Console.SetIn(srPasswordChecker_Valid);

                    // Act
                    PasswordChecker.PasswordScore(null);

                    // Assert
                    var result = swPasswordChecker_Valid.ToString();
                    Assert.Equal(expectedOutput, result);
                }
            }
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

            var expectedOutput = $"Please enter a password{Environment.NewLine}" +
                                $"Your password doesn't meet the minimum requirement{Environment.NewLine}";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); using (var sr = new StringReader(userInput))
                {
                    Console.SetIn(sr);

                    // Act
                    PasswordChecker.PasswordScore(null);

                    // Assert
                    var result = sw.ToString();
                    Assert.Equal(expectedOutput, result);
                }
            }
        }
    }
}
