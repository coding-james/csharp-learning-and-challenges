using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class DecodeTheMorseCodeTest
    {
        // CODEWARS: Decode the Morse code
        [Theory]
        [InlineData("HEY JUDE", ".... . -.--   .--- ..- -.. .")]
        [InlineData("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", "- .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --.")]
        [InlineData("1234567890", ".---- ..--- ...-- ....- ..... -.... --... ---.. ----. -----")]
        [InlineData(".,", ".-.-.- --..--")]

        public void Decode(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.DecodeTheMorseCode.Decode(input));
        }
    }
}
