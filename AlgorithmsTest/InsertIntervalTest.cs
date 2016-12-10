using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class InsertIntervalTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(IList<Interval> intervals, Interval newInterval, IList<Interval> output)
        {
            Assert.Equal(output, Solution057.Insert(intervals, newInterval));
        }
    }
}

