using System;
using FluentAssertions;
using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void 数を文字列に変換する(int num, string expected)
        {
            // 準備 Arrange
            var fizzBuzz = new FizzBuzz();
            // 実行 & 検証
            fizzBuzz.Convert(num).Should().Be(expected);
        }
    }
}
