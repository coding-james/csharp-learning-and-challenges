﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class IsANumberPrimeTest
    {
        // CODEWARS: Is a number prime?
        [Theory]
        [InlineData(false, 0)]
        [InlineData(false, 1)]
        [InlineData(true, 2)]
        [InlineData(false, 9)]

        public void IsPrime(bool expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu6.IsANumberPrime.IsPrime(input));
        }
    }
}
