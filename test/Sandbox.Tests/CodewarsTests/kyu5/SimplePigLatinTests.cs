using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class SimplePigLatinTests
    {
        [Theory]
        [InlineData("hisTay siay ymay tringsay", "This is my string")]
        [InlineData("igPay atinlay siay oolcay", "Pig latin is cool")]
        [InlineData("elloHay orldway !", "Hello world !")]

        public void BasicTests(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu5.SimplePigLatin.PigIt(input));
        }
    }
}
