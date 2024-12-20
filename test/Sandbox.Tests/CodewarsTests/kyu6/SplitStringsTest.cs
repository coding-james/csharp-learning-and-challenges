﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class SplitStringsTest
    {
        // CODEWARS: Split Strings
        [Theory]
        [InlineData(new string[] { "ab", "c_" }, "abc")]
        [InlineData(new string[] { "ab", "cd", "ef" }, "abcdef")]


        public void SplitString(string[] expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.SplitStrings.SplitString(input));
        }
    }
}
