namespace SRD_5_2_1.Domain;

public class AbilityScore
{
    public int Value
    { 
        get;
        set => field = (value < 0 || value > 30)
            ?  throw new ArgumentOutOfRangeException("Ability score value must be between 0 and 30")
            : value;
    }

    public int Modifier => (int)Math.Floor((Value - 10) / 2.0);

    public AbilityScore(int value)
    {
        Value = value;
    }
}
