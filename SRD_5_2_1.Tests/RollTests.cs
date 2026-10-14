using SRD_5_2_1.Domain;

namespace SRD_5_2_1.Tests;

public class RollTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    [InlineData(12)]
    [InlineData(20)]
    public void Roll_Result_Should_Be_Within_Range(int sides)
    {
        for (var i = 0; i < 100; i++)
        {
            var result = sides switch
            {
                3 => Roll.D3(),
                4 => Roll.D4(),
                6 => Roll.D6(),
                8 => Roll.D8(),
                10 => Roll.D10(),
                12 => Roll.D12(),
                20 => Roll.D20(),
                _ => throw new ArgumentOutOfRangeException(nameof(sides))
            };

            Assert.InRange(result.Value, 1, sides);
        }
    }
}