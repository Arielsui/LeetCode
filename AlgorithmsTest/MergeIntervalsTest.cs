using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeIntervalsTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(IList<Interval> intervals, IList<Interval> output)
        {
            Assert.Equal(output, Solution056.Merge(intervals));
        }
    }
}

