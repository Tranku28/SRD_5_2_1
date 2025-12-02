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
}