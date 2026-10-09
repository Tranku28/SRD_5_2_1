using SRD_5_2_1.Domain;

namespace SRD_5_2_1.Tests;

public class LevelTests
{
    [Fact]
    public void Level_Between_One_And_Twenty()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            Level level = new(25);
        });

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            Level level = new(-32);
        });
    }

    [Fact]
    public void Level_Up_Cannot_Exceed_Level_Cap()
    {
        Level level = new(20);

        Assert.False(level.Up());
        Assert.Equal(20, level.Value);
    }

    [Fact]
    public void Can_Level_Up_Only_When_Threshold_Reached_And_Level_Below_20()
    {
        Level level1 = new(6);
        Assert.False(level1.CanLevelUp());

        Level level2 = new(1)
        {
            XP = 300
        };
        Assert.True(level2.CanLevelUp());

        Level level3 = new(20)
        {
            XP = 355_100
        };
        Assert.False(level3.CanLevelUp());
    }
}