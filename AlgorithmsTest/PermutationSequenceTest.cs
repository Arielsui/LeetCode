using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class PermutationSequenceTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, int k, string output)
        {
            Assert.Equal(output, Solution060.GetPermutation(n, k));
        }
    }
}

