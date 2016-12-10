using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SpiralMatrixIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, int[,] output)
        {
            Assert.Equal(output, Solution059.GenerateMatrix(n));
        }
    }
}

