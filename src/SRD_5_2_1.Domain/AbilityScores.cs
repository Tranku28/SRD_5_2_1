namespace SRD_5_2_1.Domain;

public readonly struct AbilityScores
{
    public AbilityScore Strength { get; init; }
    public AbilityScore Dexterity { get; init; }
    public AbilityScore Constitution { get; init; }
    public AbilityScore Intelligence { get; init; }
    public AbilityScore Wisdom { get; init; }
    public AbilityScore Charisma { get; init; }

    public AbilityScores(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        Strength = Validate(new AbilityScore(strength), nameof(strength));
        Dexterity = Validate(new AbilityScore(dexterity), nameof(dexterity));
        Constitution = Validate(new AbilityScore(constitution), nameof(constitution));
        Intelligence = Validate(new AbilityScore(intelligence), nameof(intelligence));
        Wisdom = Validate(new AbilityScore(wisdom), nameof(wisdom));
        Charisma = Validate(new AbilityScore(charisma), nameof(charisma));
    }

    public static AbilityScore Validate(AbilityScore score, string paramName)
    {
        return score.Value < 1 || score.Value > 30 ? 
            throw new ArgumentOutOfRangeException(
                paramName, 
                "Ability score must be between 1 and 30"
                ) : score;
    }
}
