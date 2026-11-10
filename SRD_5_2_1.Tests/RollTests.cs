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

    public static TheoryData<AbilityScore, ProficiencyBonus, Modifier[], int> RollComponents = new()
    {
        { 
            new AbilityScore(12), 
            ProficiencyBonus.FromLevel(new Level(6)),
            [new("Guidance", 4), new("Ring of Protection", 1)], 
            29 
        },
        { 
            new AbilityScore(20), 
            ProficiencyBonus.FromLevel(new Level(20)),
            [new("Guidance", 4), new("Ring of Protection", 1)], 
            36
        },
        { 
            new AbilityScore(30), 
            ProficiencyBonus.FromLevel(new Level(20)),
            [new("Guidance", 4), new("Ring of Protection", 1)], 
            41
        },
    };

    [Theory]
    [MemberData(nameof(RollComponents))]
    public void Roll_With_Ability_Modifier_And_Proficiency_Bonus_Should_Be_Within_Range(AbilityScore score, ProficiencyBonus bonus, Modifier[] modifiers, int max)
    {
        int i = 0;
        
        while (i < 100)
        {
            int rollResult = Roll.D20Test(score, bonus, modifiers).Value;
            Assert.InRange(rollResult, 1, max);
            
            i++;
        }
    }
}