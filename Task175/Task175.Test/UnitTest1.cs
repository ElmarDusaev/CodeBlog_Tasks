using System;
using Xunit;
using Task175;
using Task175.Repository;

namespace Task175.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(@"Repositoriy\Data.txt", true)]
        [InlineData(@"", false)]
        public void CreateStatisticFile_Test(string path, bool status)
        {
            var res = Data.CreateStatisticFile(path);
            bool expected = status;
            Assert.Equal(expected, res);
        }

    }
}
