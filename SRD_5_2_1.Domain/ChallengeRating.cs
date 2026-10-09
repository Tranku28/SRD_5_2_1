namespace SRD_5_2_1.Domain;

[Serializable]
public sealed class ChallengeRating
{
    private static readonly double[] AllowedValues =
    [
        0, 0.125, 0.25, 0.5,
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
        21, 22, 23, 24, 25, 26, 27, 28, 29, 30
    ];

    private static readonly Dictionary<double, int> ExperiencePerChallengeRating = new()
    {
        { 0,     0  },
        { 0.125, 25 },
        { 0.25,  50 },
        { 0.5,   100 },
        { 1,     200 },
        { 2,     450 },
        { 3,     700 },
        { 4,     1_100 },
        { 5,     1_800 },
        { 6,     2_300 },
        { 7,     2_900 },
        { 8,     3_900 },
        { 9,     5_000 },
        { 10,    5_900 },
        { 11,    7_200 },
        { 12,    8_400 },
        { 13,    10_000 },
        { 14,    11_500 },
        { 15,    13_000 },
        { 16,    15_000 },
        { 17,    18_000 },
        { 18,    20_000 },
        { 19,    22_000 },
        { 20,    25_000 },
        { 21,    33_000 },
        { 22,    41_000 },
        { 23,    50_000 },
        { 24,    62_000 },
        { 25,    75_000 },
        { 26,    90_000 },
        { 27,    105_000 },
        { 28,    120_000 },
        { 29,    135_000 },
        { 30,    155_000 }
    };
    public double Value { get; }
    public int Experience => ExperiencePerChallengeRating[Value];

    private ChallengeRating(double value) => Value = value;

    public static ChallengeRating FromRoundedValue(double value)
    {
        if (!double.IsFinite(value) || value < 0 || value > 30)
            throw new ArgumentOutOfRangeException(nameof(value));

        var rounded = AllowedValues
            .OrderBy(candidate => Math.Abs(candidate - value))
            .ThenByDescending(candidate => candidate)
            .First();

        return new ChallengeRating(rounded);
    }
}