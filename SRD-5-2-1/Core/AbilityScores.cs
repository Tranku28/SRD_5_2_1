namespace SRD5_2_1.Core;

/// <summary>
/// Represents six ability scores of a creature
/// </summary>
public class AbilityScores
{
    public int Strength;
    public int Dexterity;
    public int Constitution;
    public int Intelligence;
    public int Wisdom;
    public int Charisma;

    public AbilityScores(int strength = 0, int dexterity = 0, int constitution = 0, int intelligence = 0, int wisdom = 0, int charisma = 0)
    {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }

    public int GetAbility(Ability ability)
    {
        return ability switch
        {
            Ability.Strength => Strength,
            Ability.Dexterity => Dexterity,
            Ability.Constitution => Constitution,
            Ability.Intelligence => Intelligence,
            Ability.Wisdom => Wisdom,
            Ability.Charisma => Charisma,
            _ => 0,
        };
    }
    
    public int GetAbility(int abilityIndex)
    {
        return abilityIndex switch
        {
            0 => Strength,
            1 => Dexterity,
            2 => Constitution,
            3 => Intelligence,
            4 => Wisdom,
            5 => Charisma,
            _ => 0,
        };
    }
}