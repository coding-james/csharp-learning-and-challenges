using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class SpinningWordsTest
    {
        [Theory]
        [InlineData("Hey wollef sroirraw", "Hey fellow warriors")]
        [InlineData("This is a test", "This is a test")]
        [InlineData("This is rehtona test", "This is another test")]

        public void BasicTests(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.SpinningWords.SpinWords(input));
        }
    }
}
