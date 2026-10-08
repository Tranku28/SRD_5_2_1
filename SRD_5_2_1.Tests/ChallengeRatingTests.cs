using SRD_5_2_1.Domain;

namespace SRD_5_2_1.Tests;

public class ChallengeRatingTests
{
    [Fact]
    public void Challenge_Rating_Value_Between_Zero_And_Thirty()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            ChallengeRating rating = ChallengeRating.FromRoundedValue(40);
        });

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            ChallengeRating rating = ChallengeRating.FromRoundedValue(-50);
        });
    }

    public static TheoryData<ChallengeRating, double> ChallengeRatings => new()
    {
        { ChallengeRating.FromRoundedValue(0.01), 0},
        { ChallengeRating.FromRoundedValue(0.22), 0.25},
        { ChallengeRating.FromRoundedValue(0.33), 0.25},
        { ChallengeRating.FromRoundedValue(0.55), 0.5},
        { ChallengeRating.FromRoundedValue(0.73), 0.5},
        { ChallengeRating.FromRoundedValue(4.5), 5},
        { ChallengeRating.FromRoundedValue(6.75), 7},
        { ChallengeRating.FromRoundedValue(9.88), 10},
        { ChallengeRating.FromRoundedValue(14.1), 14},
        { ChallengeRating.FromRoundedValue(19.23), 19},
        { ChallengeRating.FromRoundedValue(24.65), 25},
        { ChallengeRating.FromRoundedValue(26.24), 26},
        { ChallengeRating.FromRoundedValue(29.89), 30},
        { ChallengeRating.FromRoundedValue(30), 30},
    };

    [Theory]
    [MemberData(nameof(ChallengeRatings))]
    public void Rounding_To_Possible_Challenge_Rating_Value(ChallengeRating rating, double expected)
    {
        Assert.True(rating.Value == expected);
    }

    [Fact]
    public void Challenge_Rating_Cannot_Be_Infinity()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            ChallengeRating.FromRoundedValue(double.PositiveInfinity);
            ChallengeRating.FromRoundedValue(double.NegativeInfinity);
        });
    }

    [Fact]
    public void Challenge_Rating_Not_Nan()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            ChallengeRating.FromRoundedValue(double.NaN);
        });
    }
}