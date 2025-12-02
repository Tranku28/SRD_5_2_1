namespace SRD5_2_1;

/// <summary>
/// A class for representing all in-game dice single and multiple (same dice) rolls.
/// </summary>
public static class Roll
{
    /// <summary>
    /// D2 roll dice
    /// </summary>
    public static int D2 => Random.Next(1, 2);
    /// <summary>
    /// D3 roll dice
    /// </summary>
    public static int D3 => Random.Next(1, 3);
    /// <summary>
    /// D4 roll dice
    /// </summary>
    public static int D4 => Random.Next(1, 4);
    /// <summary>
    /// D6 roll dice
    /// </summary>
    public static int D6 => Random.Next(1, 6);
    /// <summary>
    /// D8 roll dice
    /// </summary>
    public static int D8 => Random.Next(1, 8);
    /// <summary>
    /// D10 roll dice
    /// </summary>
    public static int D10 => Random.Next(1, 10);
    /// <summary>
    /// D12 roll dice
    /// </summary>
    public static int D12 => Random.Next(1, 12);
    /// <summary>
    /// D20 roll dice
    /// </summary>
    public static int D20 => Random.Next(1, 20);
    /// <summary>
    /// D100 roll dice
    /// </summary>
    public static int D100 => Random.Next(1, 100);

    public static int Multiple(DiceType diceType, int rollCount)
    {
        int result = 0;
        return diceType switch
        {
            DiceType.D2 => CombineRoll(2),
            DiceType.D3 => CombineRoll(3),
            DiceType.D4 => CombineRoll(4),
            DiceType.D6 => CombineRoll(6),
            DiceType.D8 => CombineRoll(8),
            DiceType.D10 => CombineRoll(10),
            DiceType.D12 => CombineRoll(12),
            DiceType.D20 => CombineRoll(20),
            DiceType.D100 => CombineRoll(100),
            _ => 0
        };

        int CombineRoll(int diceSides)
        {
            for (int i = 0; i < rollCount - 1; i++)
            {
                result += Random.Next(1, diceSides);
            }
            
            return result;
        }
    }
}