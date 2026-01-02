namespace SRD5_2_1
{
    /// <summary>
    /// Get integer number from the provided scope where whole scope is included
    /// </summary>
    /// <remarks>
    /// This class is designed for dice roll simulations in tabletop RPG systems.
    /// It guarantees that both <paramref name="minValue"/> and <paramref name="maxValue"/> are possible outcomes.
    /// </remarks>
    public static class Random
    {
        /// <summary>
        /// Returns a pseudo-random integer within the specified inclusive range.
        /// </summary>
        /// <param name="minValue">The lowest possible random number (inclusive).</param>
        /// <param name="maxValue">The highest possible random number (inclusive).</param>
        /// <returns>An integer between <paramref name="minValue"/> and <paramref name="maxValue"/>, inclusive.</returns>
        /// <example>
        /// Example usage:
        /// <code>
        /// int roll = Random.Next(1, 6); // Possible results: 1, 2, 3, 4, 5, 6
        /// </code>
        /// </example>
        public static int Next(int minValue, int maxValue)
        {
            System.Random random = new();
            return random.Next(minValue, maxValue + 1);
        }
    }
}