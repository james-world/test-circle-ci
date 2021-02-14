using FluentAssertions;
using Xunit;

namespace Adder.UnitTests
{
    public class ParserTests
    {
        [Fact]
        public void Parse_StringArrayParam_ReturnsIntegerPair()
        {
            var input = new[] {"2", "3"};
            var expected = (2, 3);
            
            var sut = new Parser();

            var result = sut.Parse(input);

            result.Should().Be(expected);
        }
    }
}