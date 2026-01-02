namespace SRD5_2_1;

/// <summary>
/// SRD Random implementation.
/// </summary>
public class Random
{
    /// <summary>
    /// Get integer number from the provided scope where whole scope is included
    /// </summary>
    /// <param name="minValue">the lowest possible random number</param>
    /// <param name="maxValue">the highest possible random number</param>
    /// <returns>int</returns>
    public static int Next(int minValue, int maxValue)
    {
        System.Random random = new();
        return random.Next(minValue, maxValue+1);
    }
}