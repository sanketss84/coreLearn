using System;
using Xunit;
using Shouldly;

namespace coreLearn.Library.xUnitTests
{
    //https://xunit.github.io/docs/getting-started/netcore/cmdline
    public class ShouldlyDemo
    {
        [Fact]
        public void PassingTest()
        {
            var value = 5;
            value.ShouldBe(5);
            value.ShouldBeGreaterThan(4);
            value.ShouldBeGreaterThanOrEqualTo(5);
            value.ShouldBeInRange(0, 10);
            value.ShouldBeLessThan(6);            
            value.ShouldBeOneOf(2, 5, 7);
        }

    }
}
