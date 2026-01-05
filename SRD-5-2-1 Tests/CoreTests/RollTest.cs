using SRD5_2_1.Core;
namespace SRD_5_2_1_Tests.CoreTests;

public class RollTest
{
    private const int LOWEST_DICE_RESULT = 1;

    [Fact]
    public void Test_Roll()
    {
        Assert.True(Roll.D2 <= 2 && Roll.D2 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D3 <= 3 && Roll.D3 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D4 <= 4 && Roll.D4 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D6 <= 6 && Roll.D6 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D8 <= 8 && Roll.D8 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D10 <= 10 && Roll.D10 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D12 <= 12 && Roll.D12 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D20 <= 20 && Roll.D20 >= LOWEST_DICE_RESULT);
        Assert.True(Roll.D100 <= 100 && Roll.D100 >= LOWEST_DICE_RESULT);
    }

    [Theory]
    [InlineData(DiceType.D2)]
    [InlineData(DiceType.D3)]
    [InlineData(DiceType.D4)]
    [InlineData(DiceType.D6)]
    [InlineData(DiceType.D8)]
    [InlineData(DiceType.D10)]
    [InlineData(DiceType.D12)]
    [InlineData(DiceType.D20)]
    [InlineData(DiceType.D100)]
    public void Test_Multiple(DiceType diceType, int diceCount = 5)
    {
        Assert.True(
            Roll.Multiple(diceType, diceCount) >= diceCount && 
            Roll.Multiple(diceType, diceCount) <= diceCount * (int)diceType
            );
    }
}