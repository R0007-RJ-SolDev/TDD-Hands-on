using System;
using Xunit;

namespace Tddbc.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void _1を渡すと文字列1を返す()
        {
            // 準備 Arrange
            var fizzBuzz = new FizzBuzz();
            // 実行 & 検証
            Assert.Equal("1", fizzBuzz.Convert(1));
        }
    }
}
