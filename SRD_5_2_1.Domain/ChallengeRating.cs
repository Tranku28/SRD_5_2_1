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

    public double Value { get; }

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