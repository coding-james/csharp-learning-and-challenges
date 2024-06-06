using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    public class StringMix
    {
        [Theory]
        [InlineData("my&friend&Paul has heavy hats! &", "my friend John has many many friends &", "2:nnnnn/1:aaaa/1:hhh/2:mmm/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss")]
        [InlineData("mmmmm m nnnnn y&friend&Paul has heavy hats! &", "my frie n d Joh n has ma n y ma n y frie n ds n&", "1:mmmmmm/=:nnnnnn/1:aaaa/1:hhh/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss")]
        [InlineData("Are the kids at home? aaaaa fffff", "Yes they are here! aaaaa fffff", "=:aaaaaa/2:eeeee/=:fffff/1:tt/2:rr/=:hh")]

        public void StingMix_Compare_Strings(string input1, string input2, string expected)
        {
            Assert.Equal(expected, Codewars.kyu4.StringMix.Mix(input1, input2));
        }
    }
}
