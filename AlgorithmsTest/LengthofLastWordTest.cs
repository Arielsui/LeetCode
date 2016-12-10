using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class LengthofLastWordTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution058.LengthOfLastWord(s));
        }
    }
}

