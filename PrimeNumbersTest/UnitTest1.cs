using System;
using Xunit;
using DevBuild_Lab_PrimeNumbers;

namespace PrimeNumbersTest
{
    public class UnitTest1
    {
        // 1 returns 2
        // 2 returns 3
        // 3 returns 5
        // 5 returns 11
        // 9 returns 23
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(5, 11)]
        [InlineData(9, 23)]
        [InlineData(13, 41)]
        [InlineData(25, 97)]
        [InlineData(90, 463)]
        [InlineData(300, 1987)]

        public void TestGetPrime(int nth, int expected)
        {
            int actual = PrimeNum.GetPrime(nth);
            Assert.Equal(expected, actual);

        }
    }
}
