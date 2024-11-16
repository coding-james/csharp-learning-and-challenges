using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class SortTheOddTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 2, 8, 5, 4 }, new int[] { 5, 3, 2, 8, 1, 4 })]
        [InlineData(new int[] { 1, 3, 5, 8, 0 }, new int[] { 5, 3, 1, 8, 0 })]
        [InlineData(new int[] { }, new int[] { })]

        public void BasicTests(int[] expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu6.SortTheOdd.SortArray(input));
        }
    }
}
