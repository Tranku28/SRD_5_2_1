using SRD_5_2_1.Domain;

namespace SRD_5_2_1.Tests;

public class ProficiencyBonusTest()
{
    public static TheoryData<ChallengeRating, int> ChallengeRatings => new()
    {
        { ChallengeRating.FromRoundedValue(0), 2},
        { ChallengeRating.FromRoundedValue(0.125), 2},
        { ChallengeRating.FromRoundedValue(0.25), 2},
        { ChallengeRating.FromRoundedValue(0.5), 2},
        { ChallengeRating.FromRoundedValue(4), 2},
        { ChallengeRating.FromRoundedValue(6), 3},
        { ChallengeRating.FromRoundedValue(9), 4},
        { ChallengeRating.FromRoundedValue(14), 5},
        { ChallengeRating.FromRoundedValue(19), 6},
        { ChallengeRating.FromRoundedValue(24), 7},
        { ChallengeRating.FromRoundedValue(26), 8},
        { ChallengeRating.FromRoundedValue(29), 9},
        { ChallengeRating.FromRoundedValue(30), 9},
    };

    [Theory]
    [MemberData(nameof(ChallengeRatings))]
    public void Challenge_Rating_Proficiency_Bonus_Calculation(ChallengeRating rating, int expected)
    {
        ProficiencyBonus bonus = ProficiencyBonus.FromChallengeRating(rating);
        Assert.True(bonus.Value == expected);
    }
}