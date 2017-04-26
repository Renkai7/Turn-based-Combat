using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class assigns values to a character

public class BaseHeroClass : BaseCharacterClass {

    // Turn into Persona class later 

    public BaseHeroClass()
    {
        CharacterName = "Tsukino";
        CharacterClassDescription = "Main protagonist";
        Strength = 2;
        Magic = 2;
        Endurance = 2;
        Agility = 3;
        Luck = 1;
    }
	
}
