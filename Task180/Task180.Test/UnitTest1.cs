using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Task180.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,4,4)]
        [InlineData(4,0,4)]
        [InlineData(0,0,0)]
        [InlineData(100, 0,100)]
        public void getmaxValue_Test(int a, int b, int expected)
        {
            var result = Program.maxValue(a, b);

            Assert.Equal(result, expected);

        }
    }
}
