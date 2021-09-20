using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace exercises.tests
{
    public class NumbersInRangeTest
    {
        [Test]
        public void NumbersInRange_ShouldReturnNumbersInsideRange_WhenProvided()
        {
            var result = NumbersInRange.GetNumbersInRange(new List<int> { 67, 92, 153, 15 }, 30, 100);

            result.Should().BeEquivalentTo(new List<int> { 67, 92 });
        }

        [Test]
        public void NumbersInRange_ShouldReturnEmptyList_WhenInputDoesNotContainNumbersInRange()
        {
            var result = NumbersInRange.GetNumbersInRange(new List<int> { 0, -24, 29, 30, 100, 150, 300 }, 30, 100);

            result.Should().BeEquivalentTo(new List<int> { });
        }
    }
}