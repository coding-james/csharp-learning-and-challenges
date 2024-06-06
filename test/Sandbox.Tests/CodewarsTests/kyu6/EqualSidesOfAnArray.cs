using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class EqualSidesOfAnArray
    {
        [Theory]
        [InlineData(3, new int[] { 1, 2, 3, 4, 3, 2, 1 })]
        [InlineData(1, new int[] { 1, 100, 50, -51, 1, 1 })]
        [InlineData(-1, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(3, new int[] { 20, 10, 30, 10, 10, 15, 35 })]
        [InlineData(0, new int[] { })]
        [InlineData(0, new int[] { 20, 10, -80, 10, 10, 15, 35 })]
        [InlineData(-1, new int[] { 8, 8 })]
        [InlineData(0, new int[] { 8, 0 })]
        [InlineData(1, new int[] { 0, 8 })]


        public void BasicTests(int expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu6.EqualSidesOfAnArray.FindEvenIndex(input));
        }
    }
}