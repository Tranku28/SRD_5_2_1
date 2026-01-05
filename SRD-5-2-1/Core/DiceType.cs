namespace SRD5_2_1.Core;

/// <summary>
/// Represents a die type used in tabletop RPGs.
/// The numeric value corresponds to the number of sides.
/// </summary>


public enum DiceType
{
    /// <summary>Two-sided dice (coin flip).</summary>
    D2 = 2,
    /// <summary>Three-sided dice.</summary>
    D3 = 3,
    /// <summary>Four-sided dice (tetrahedron).</summary>
    D4 = 4,
    /// <summary>Six-sided dice (standard cube).</summary>
    D6 = 6,
    /// <summary>Eight-sided dice.</summary>
    D8 = 8,
    /// <summary>Ten-sided dice.</summary>
    D10 = 10,
    /// <summary>Twelve-sided dice.</summary>
    D12 = 12,
    /// <summary>Twenty-sided dice (common ability score test dice).</summary>
    D20 = 20,
    /// <summary>Hundred-sided dice (percentile roll).</summary>
    D100 = 100
}
