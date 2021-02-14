using FluentAssertions;
using Xunit;

namespace Adder.UnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 3, 5)]
        public void Add_Integers_CalculatesSum(int a, int b, int expected)
        {
            var sut = new Calculator();

            var result = sut.Add(a, b);

            result.Should().Be(expected);
        }
    }
}