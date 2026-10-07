using SRD_5_2_1.Domain;
namespace SRD_5_2_1.Tests;

public class AbilityScoreTests
{
    [Fact]
    public void Value_Must_Be_Between_Zero_Thirty()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            AbilityScore score = new(45);
        });
    }

    [Theory]
    [InlineData(0, -5)]
    [InlineData(1, -5)]
    [InlineData(8, -1)]
    [InlineData(15, 2)]
    [InlineData(30, 10)]
    public void Test_Modifier_Calculation(int value, int expectedModifier)
    {
        AbilityScore score = new(value);
        Assert.True(score.Modifier == expectedModifier);
    }
}
