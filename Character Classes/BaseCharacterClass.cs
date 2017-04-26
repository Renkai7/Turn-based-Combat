using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class hold base information on characters in game - Name, Stats, Level

public class BaseCharacterClass {
    
    // Base class for Stats

    private string characterName;
    private string characterClassDescription;
    private int characterLevel;

    // Stats
    private int strength;
    private int magic;
    private int endurance;
    private int agility;
    private int luck;

    private int currentEXP;
    private int requiredEXP;

    // Get & Set

    public string CharacterName { get; set; }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public List<BaseAbilities> playerAbilities = new List<BaseAbilities>();

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }

    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }

    public int CurrentEXP { get; set; }

    public int RequiredEXP { get; set; }

    public int CharacterLevel { get; set; }
}
