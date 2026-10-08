namespace SRD_5_2_1.Domain;

public struct ProficiencyBonus
{
    public int Value { get;}
    
    private ProficiencyBonus(int value)
    {
        Value = value;
    }

    public static ProficiencyBonus FromChallengeRating(ChallengeRating rating)
    {
        return rating.Value switch
        {
            <= 4 => new(2),
            < 9 => new(3),
            < 13 => new(4),
            < 17 => new(5),
            < 21 => new(6),
            < 25 => new(7),
            < 29 => new(8),
            _ => new(9)
        };
    }
}