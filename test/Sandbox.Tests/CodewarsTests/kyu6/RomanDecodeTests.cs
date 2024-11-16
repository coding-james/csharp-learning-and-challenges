using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class RomanDecodeTests
    {
        // CODEWARS: Roman Numerals Decoder
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(21, "XXI")]
        [InlineData(25, "XXV")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(2000, "MM")]
        [InlineData(3000, "MMM")]
        [InlineData(1954, "MCMLIV")]
        [InlineData(1990, "MCMXC")]
        [InlineData(2008, "MMVIII")]
        [InlineData(2014, "MMXIV")]

        public void DecodeRoman(int expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.RomanDecode.Solution(input));
        }
    }
}
