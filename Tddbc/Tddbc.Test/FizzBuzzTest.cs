using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using FluentAssertions.Primitives;
using Xunit;

namespace Tddbc.Test
{
    namespace FizzBuzzTest
    {
        public class 数を文字列に変換する
        {
            private readonly FizzBuzz _fizzBuzz;
            public 数を文字列に変換する()
            {
                _fizzBuzz = new FizzBuzz();
            }

            [Theory]
            [InlineData(3)]
            [InlineData(6)]
            public void _3の倍数の時は数の代わりにFizzと変換する(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("Fizz");
            }

            [Theory]
            [InlineData(5)]
            [InlineData(10)]
            public void _5の倍数の時は数の代わりにBuzzと変換する(int num)
            {
                _fizzBuzz.Convert(num).Should().Be("Buzz");
            }

            [Theory]
            [InlineData(1, "1")]
            [InlineData(2, "2")]
            public void その他の文字の時はそのまま文字列に変換する(int num, string expected)
            {
                _fizzBuzz.Convert(num).Should().Be(expected);
            }
        }
    }
}
