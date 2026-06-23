namespace SRD_5_2_1.Domain;

public struct AbilityScore
{
    public int Value { get; }
    public Modifier Modifier => GetModifier();

    public AbilityScore(int value) 
    { 
        Value = value;
    }

    public Modifier GetModifier()
    {
        return new Modifier(this);
    }
}