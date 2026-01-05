namespace SRD5_2_1.Core
{
    /// <summary>
    /// Provides functionality for simulating dice rolls commonly used in tabletop RPGs.
    /// Supports single rolls for standard dice types and multiple rolls combined into a total.
    /// </summary>
    /// <remarks>
    /// This class uses <see cref="SRD5_2_1.Core.Random"/> internally to generate pseudo-random results.
    /// </remarks>
    public static class Roll
    {
        /// <summary>
        /// Rolls a two-sided die (D2).
        /// </summary>
        public static int D2 => Random.Next(1, 2);

        /// <summary>
        /// Rolls a three-sided die (D3).
        /// </summary>
        public static int D3 => Random.Next(1, 3);

        /// <summary>
        /// Rolls a four-sided die (D4).
        /// </summary>
        public static int D4 => Random.Next(1, 4);

        /// <summary>
        /// Rolls a six-sided die (D6).
        /// </summary>
        public static int D6 => Random.Next(1, 6);

        /// <summary>
        /// Rolls an eight-sided die (D8).
        /// </summary>
        public static int D8 => Random.Next(1, 8);

        /// <summary>
        /// Rolls a ten-sided die (D10).
        /// </summary>
        public static int D10 => Random.Next(1, 10);

        /// <summary>
        /// Rolls a twelve-sided die (D12).
        /// </summary>
        public static int D12 => Random.Next(1, 12);

        /// <summary>
        /// Rolls a twenty-sided die (D20).
        /// </summary>
        public static int D20 => Random.Next(1, 20);

        /// <summary>
        /// Rolls a hundred-sided die (D100).
        /// </summary>
        public static int D100 => Random.Next(1, 100);

        /// <summary>
        /// Rolls multiple dice of the same type and returns the combined result.
        /// </summary>
        /// <param name="diceType">The type of dice to roll (e.g., <see cref="DiceType.D6"/>).</param>
        /// <param name="rollCount">The number of dice to roll. Must be greater than zero.</param>
        /// <returns>The sum of all rolled dice.</returns>
        /// <example>
        /// Example usage:
        /// <code>
        /// int total = Roll.Multiple(DiceType.D6, 3); // Rolls 3 six-sided dice and sums the result
        /// </code>
        /// </example>
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
                for (int i = 0; i < rollCount; i++)
                {
                    result += Random.Next(1, diceSides + 1);
                }

                return result;
            }
        }
    }
}
