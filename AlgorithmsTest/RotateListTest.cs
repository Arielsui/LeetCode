using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RotateListTest
    {
        [Theory]
        [MemberDataAttribute("InlineData")]
        public void TestMethod(ListNode head, int k, ListNode output)
        {
            Assert.Equal(output, Solution061.RotateRight(head, k));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var head = new List<int>{1,2,3,4,5}.ToListNode();
                var k = 2;
                var output = new List<int>{4,5,1,2,3}.ToListNode();
                driverData.Add(new object[] { head, k, output });
                head = new List<int>{2,3,4,5,6}.ToListNode();
                k = 6;
                output = new List<int>{4,5,6,2,3}.ToListNode();
                driverData.Add(new object[] { head, k, output });
                return driverData;
            }
        }
    }
}

