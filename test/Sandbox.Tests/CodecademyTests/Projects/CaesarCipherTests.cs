using Sandbox.Codecademy.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodecademyTests.Projects
{
    public class CaesarCipherTests
    {
        [Theory]
        [InlineData("hello", "khoor")]
        [InlineData("HELlo", "khoor")]
        [InlineData("citizen", "flwlchq")]
        [InlineData("cit2izen", "flwlchq")]
        [InlineData("ci_tizen", "flwlchq")]
        public void EncryptTests(string userInput, string expected)
        {
            Assert.Equal(expected, CaesarCipher.Encrypt(userInput));
        }
    }
}
