using FluentAssertions;
using SRD_5_2_1.Domain;

namespace SRD_5_2_1_Tests
{
    public class CharacterCreationTests
    {
        [Fact]
        public void Should_Create_Ability_Scores_When_Values_In_Range()
        {
            Action act = () => new AbilityScores(0, 10, 10, 31, 10, 0);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        // Modifier value should be calculated on ability score provided
        // Range for modifiers should be a number between -5 and +10

        public AbilityScore score = new(10);

        [Fact]
        public void Modifier_For_Score_10_Should_Be_0()
        {
            Modifier mod = new(score);

            Assert.Equal(0, mod.Value);
        }
    }
}