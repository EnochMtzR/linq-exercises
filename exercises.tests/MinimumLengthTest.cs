using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace exercises.tests
{
    public class MinimumLengthTest
    {
        [Test]
        public void GetLargerWordsUpcase_ShouldReturnAllWordsLargerThanMinimumLength_WhenProvided()
        {
            var result = MinimumLength.GetLargerWordsUpcase(
                new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" },
                5);

            result.Should().BeEquivalentTo(new List<string> { "ZEBRA", "ELEPHANT", "RHINO" });
        }
    }
}