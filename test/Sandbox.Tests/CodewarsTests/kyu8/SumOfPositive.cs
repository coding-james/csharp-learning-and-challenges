using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu8
{
    public class SumOfPositive
    {
        [Theory]
        [InlineData(20, new int[] { 1, -4, 7, 12 })]
        [InlineData(6, new int[] { -10, 2, 2, 2 })]
        [InlineData(15, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(13, new int[] { 1, -2, 3, 4, 5 })]
        [InlineData(9, new int[] { -1, 2, 3, 4, -5 })]
        [InlineData(0, new int[] { -1, -4, -7, -12 })]
        [InlineData(0, new int[] { })]

        public void BasicTests(int expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu8.SumOfPositive.PositiveSum(input));
        }
    }
}