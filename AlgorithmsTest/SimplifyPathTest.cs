using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SimplifyPathTest
    {
        [Theory]
        [InlineData("/home/", "/home")]
        [InlineData("/a/./b/../../c/", "/c")]
        [InlineData("/", "/")]
        public void TestMethod(string path, string output)
        {
            Assert.Equal(output, Solution071.SimplifyPath(path));
        }
    }
}

