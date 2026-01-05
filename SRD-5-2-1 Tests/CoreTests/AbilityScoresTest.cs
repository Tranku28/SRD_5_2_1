using SRD5_2_1.Core;

namespace SRD_5_2_1_Tests.CoreTests;

public class AbilityScoresTest
{
    public static IEnumerable<object[]> GetAbilityIndexes => Enumerable.Range(0, 5).Select(i => new object[] { i });
    
    [Theory]
    [MemberData(nameof(GetAbilityIndexes))]
    public void Test_GetAbilityScore(int value)
    {
        AbilityScores abilityScores = new AbilityScores(value, value, value, value, value, value);
        Assert.True(abilityScores.GetAbility(value) <= 30 && abilityScores.GetAbility(value) >= 0);
    }
}