using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class Mumbling
    {
        [Theory]
        [InlineData("A-Bb-Ccc-Dddd", "abcd")]
        [InlineData("R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy", "RqaEzty")]
        [InlineData("C-Ww-Aaa-Tttt", "cwAt")]

        public void BasicTests(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu7.Mumbling.Accum(input));
        }
    }
}
